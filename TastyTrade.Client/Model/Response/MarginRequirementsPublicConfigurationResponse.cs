using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TastyTrade.Client.Model.Response
{
    public class MarginRequirementsPublicConfigurationResponse
    {
        [JsonPropertyName("data")]
        public MarginRequirementsPublicConfiguration Data { get; set; }
    }
    public class MarginRequirementsPublicConfiguration
    {
        [JsonPropertyName("risk-free-rate")]
        public string RiskFreeRate { get; set; }

    }
}
