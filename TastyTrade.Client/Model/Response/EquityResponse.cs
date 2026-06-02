using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the equity response.
/// </summary>
public class EquityResponse
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public EquityResponseData Data { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}

/// <summary>
/// Represents the equity response data.
/// </summary>
public class EquityResponseData
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the symbol.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    /// <summary>
    /// Gets or sets the instrument type.
    /// </summary>
    [JsonPropertyName("instrument-type")]
    public string InstrumentType { get; set; }

    /// <summary>
    /// Gets or sets the cusip.
    /// </summary>
    [JsonPropertyName("cusip")]
    public string Cusip { get; set; }

    /// <summary>
    /// Gets or sets the short description.
    /// </summary>
    [JsonPropertyName("short-description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// Gets or sets the is index.
    /// </summary>
    [JsonPropertyName("is-index")]
    public bool IsIndex { get; set; }

    /// <summary>
    /// Gets or sets the listed market.
    /// </summary>
    [JsonPropertyName("listed-market")]
    public string ListedMarket { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the lendability.
    /// </summary>
    [JsonPropertyName("lendability")]
    public string Lendability { get; set; }

    /// <summary>
    /// Gets or sets the market time instrument collection.
    /// </summary>
    [JsonPropertyName("market-time-instrument-collection")]
    public string MarketTimeInstrumentCollection { get; set; }

    /// <summary>
    /// Gets or sets the is closing only.
    /// </summary>
    [JsonPropertyName("is-closing-only")]
    public bool IsClosingOnly { get; set; }

    /// <summary>
    /// Gets or sets the is options closing only.
    /// </summary>
    [JsonPropertyName("is-options-closing-only")]
    public bool IsOptionsClosingOnly { get; set; }

    /// <summary>
    /// Gets or sets the active.
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// Gets or sets the is illiquid.
    /// </summary>
    [JsonPropertyName("is-illiquid")]
    public bool IsIlliquid { get; set; }

    /// <summary>
    /// Gets or sets the is etf.
    /// </summary>
    [JsonPropertyName("is-etf")]
    public bool IsEtf { get; set; }

    /// <summary>
    /// Gets or sets the is fraud risk.
    /// </summary>
    [JsonPropertyName("is-fraud-risk")]
    public bool IsFraudRisk { get; set; }

    /// <summary>
    /// Gets or sets the streamer symbol.
    /// </summary>
    [JsonPropertyName("streamer-symbol")]
    public string StreamerSymbol { get; set; }

    /// <summary>
    /// Gets or sets the bypass manual review.
    /// </summary>
    [JsonPropertyName("bypass-manual-review")]
    public bool BypassManualReview { get; set; }

    /// <summary>
    /// Gets or sets the tick sizes.
    /// </summary>
    [JsonPropertyName("tick-sizes")]
    public TickSize[] TickSizes { get; set; }

    /// <summary>
    /// Gets or sets the option tick sizes.
    /// </summary>
    [JsonPropertyName("option-tick-sizes")]
    public TickSize[] OptionTickSizes { get; set; }
}
