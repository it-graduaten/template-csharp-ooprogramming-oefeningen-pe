using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public enum TestType
    {
        String,
        Double
    }

    public partial class IoConfig
    {
        [JsonProperty("codegradeAssignmentName")]
        public string CodegradeAssignmentName { get; set; }

        [JsonProperty("fixtures")]
        public string[] Fixtures { get; set; }

        [JsonProperty("ioConfig")]
        public IoConfigElement[] IoConfigArray { get; set; }

        [JsonProperty("testClasses")]
        public bool TestClasses { get; set; }

        [JsonProperty("testConsole")]
        public bool TestConsole { get; set; }
    }

    public partial class IoConfigElement
    {
        [JsonProperty("inputs")]
        public string[] Inputs { get; set; }

        [JsonProperty("outputs")]
        public OutputElement[] Outputs { get; set; }

        [JsonProperty("ignoreCulture")]
        public bool IgnoreCulture { get; set; } = false;
    }

    public partial class OutputElement
    {
        [JsonProperty("type")]
        public TestType Type { get; set; }

        [JsonProperty("stringConfig")]
        public StringConfigElement? StringConfig { get; set; }

        [JsonProperty("doubleConfig")]
        public DoubleConfigElement? DoubleConfig { get; set; }
    }

    public partial class StringConfigElement
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class DoubleConfigElement
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("delta")]
        public double Delta { get; set; }
    }
}