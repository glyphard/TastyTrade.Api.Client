using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response
{
    /// <summary>
    /// Represents the order response.
    /// </summary>
    public class OrderResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public OrderItem Data { get; set; }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }
    }
}
