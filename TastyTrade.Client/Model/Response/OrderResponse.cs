using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response
{
    public class OrderResponse
    {
        [JsonPropertyName("data")]
        public OrderItem Data { get; set; }

        [JsonPropertyName("context")]
        public string Context { get; set; }
    }
}
