using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the search response.
/// </summary>
public class SearchResponse
{
    /// <summary>
    /// Gets or sets the symbol.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the listed market.
    /// </summary>
    [JsonPropertyName("listed-market")]
    public string ListedMarket { get; set; }

    /// <summary>
    /// Gets or sets the price increments.
    /// </summary>
    [JsonPropertyName("price-increments")]
    public string PriceIncrements { get; set; }

    /// <summary>
    /// Gets or sets the trading hours.
    /// </summary>
    [JsonPropertyName("trading-hours")]
    public string TradingHours { get; set; }

    /// <summary>
    /// Gets or sets the options.
    /// </summary>
    [JsonPropertyName("options")]
    public string Options { get; set; }

    /// <summary>
    /// Gets or sets the instrument type.
    /// </summary>
    [JsonPropertyName("instrument-type")]
    public string InstrumentType { get; set; }
}
