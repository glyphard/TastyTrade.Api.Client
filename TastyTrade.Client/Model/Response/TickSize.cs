using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the tick size.
/// </summary>
public class TickSize
{
    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    [JsonPropertyName("value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? Value { get; set; }

    /// <summary>
    /// Gets or sets the threshold.
    /// </summary>
    [JsonPropertyName("threshold")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? Threshold { get; set; }
}
