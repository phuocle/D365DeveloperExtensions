﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PluginDeployer.Spkl.Config
{
    public class SolutionPackageMap
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public MapTypes map;
        public string from;
        public string to;
    }
}