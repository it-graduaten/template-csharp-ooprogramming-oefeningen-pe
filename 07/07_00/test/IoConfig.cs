using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public partial class IoConfig
    {
        [JsonProperty("codegradeAssignmentName")]
        public string CodegradeAssignmentName { get; set; }

        [JsonProperty("fixtures")]
        public string[] Fixtures { get; set; }

        [JsonProperty("ioConfig")]
        public IoConfigElement[] IoConfigIoConfig { get; set; }

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
        public string[] Outputs { get; set; }

        [JsonProperty("ignoreCulture")]
        public bool IgnoreCulture { get; set; } = false;
    }
}