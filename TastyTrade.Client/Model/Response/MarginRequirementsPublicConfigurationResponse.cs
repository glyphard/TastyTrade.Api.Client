using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TastyTrade.Client.Model.Response
{
    /// <summary>
    /// Represents the margin requirements public configuration response.
    /// </summary>
    public class MarginRequirementsPublicConfigurationResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public MarginRequirementsPublicConfiguration Data { get; set; }
    }
    /// <summary>
    /// Represents the margin requirements public configuration.
    /// </summary>
    public class MarginRequirementsPublicConfiguration
    {
        /// <summary>
        /// Gets or sets the risk free rate.
        /// </summary>
        [JsonPropertyName("risk-free-rate")]
        public string RiskFreeRate { get; set; }

    }
}
