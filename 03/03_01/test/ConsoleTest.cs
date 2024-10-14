namespace test;

[TestClass]
[TestCategory("Console")]
public class ConsoleTest
{
    private static readonly string _filename = "ioConfig.json";

    public static IEnumerable<Object[]> IoConfigs
    {
        get
        {
            var json = File.ReadAllText(_filename);
            var config = Newtonsoft.Json.JsonConvert.DeserializeObject<IoConfig>(json);
            foreach (var item in config.IoConfigArray)
            {
                yield return new Object[] { item };
            }
        }
    }

    [TestMethod]
    [DynamicData(nameof(IoConfigs))]
    public void InputOutputTest(IoConfigElement config)
    {
        CultureInfo.CurrentCulture = new CultureInfo("nl-BE");
        if (config is null)
        {
            throw new ArgumentNullException(nameof(config), "The 'IoConfigs' parameter can't be null.");
        }

        if (config.Inputs.Length == 0 && config.Outputs.Length == 0)
        {
            Assert.Fail("No inputs or outputs were provided. Please contact your teacher.");
        }

        // Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);

        var inputString = string.Join("\n", config.Inputs);
        var textReader = new StringReader(inputString);
        Console.SetIn(textReader);

        // Act
        var args = new string[0];
        var entrypoint = typeof(Program).Assembly.EntryPoint!;
        entrypoint.Invoke(null, new object[] { args });
        var sb = writer.GetStringBuilder();
        var fullOutput = sb.ToString();
        var outputAsLines = fullOutput.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

        // Write to debug what the input for the test is
        System.Diagnostics.Debug.WriteLine(inputString);

        foreach (var output in config.Outputs)
        {
            if (output.Type == TestType.String)
            {
                StringAssert.Contains(fullOutput, output.StringConfig.Value);
            }
            else if (output.Type == TestType.Double)
            {
                var exactValue = output.DoubleConfig.Value;
                var delta = output.DoubleConfig.Delta;
                // Get the lower bound and upper bound
                var lowerBound = exactValue - delta;
                var upperBound = exactValue + delta;
                // Create a list of strings containing all possible values
                var possibleValues = new List<string>();
                // Populate the list with all possible values, this can be a double rounded to 1 or 2 decimals
                for (double i = lowerBound; i <= upperBound; i += 0.01)
                {
                    if (!possibleValues.Contains(i.ToString("N0")))
                        possibleValues.Add(i.ToString("N0"));
                    if (!possibleValues.Contains(i.ToString("N1")))
                        possibleValues.Add(i.ToString("N1"));
                    if (!possibleValues.Contains(i.ToString("N2")))
                        possibleValues.Add(i.ToString("N2"));
                }

                Assert.IsTrue(possibleValues.Any(s => fullOutput.Contains(s)), $"Jouw output is de volgende: \n{fullOutput}\n Deze bevat geen getal tussen {lowerBound:N2} en {upperBound:N2}");
            }
        }
    }
}