﻿using aspnetcore_apexcharts.Models.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace aspnetcore_apexcharts.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class SubTitle : TextAttribute
    {
        public string Align { get; set; }
    }
}