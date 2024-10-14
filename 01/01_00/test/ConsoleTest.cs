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
            foreach (var item in config.IoConfigIoConfig)
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


            // Assert
            StringAssert.Contains(fullOutput, output, $"~De verwachte output kon niet worden gevonden in jouw output.~{fullOutput}~{output}", StringComparison.InvariantCulture);
        }
    }
}

