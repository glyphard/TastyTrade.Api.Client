using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response;

public class TickSize
{
    [JsonPropertyName("value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? Value { get; set; }

    [JsonPropertyName("threshold")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? Threshold { get; set; }
}
