using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response.Streaming
{
    /// <summary>
    /// Defines streaming account update type values.
    /// </summary>
    public enum StreamingAccountUpdateType {
        /// <summary>
        /// Represents order.
        /// </summary>
        [JsonStringEnumMemberName("Order")]
        Order = 0
    }
    /// <summary>
    /// Represents the streaming account order update.
    /// </summary>
    public class StreamingAccountOrderUpdate
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("type")]
        public StreamingAccountUpdateType Type { get; set; }
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public PlacedOrderReceipt Data { get; set; }
        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public long Timestamp  { get; set; }
    }
}
