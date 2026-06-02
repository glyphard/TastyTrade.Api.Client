using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the option chain response.
/// </summary>
public class OptionChainResponse
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public OptionChainResponseData Data { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}

/// <summary>
/// Represents the option chain response data.
/// </summary>
public class OptionChainResponseData
{
    /// <summary>
    /// Gets or sets the items.
    /// </summary>
    [JsonPropertyName("items")]
    public List<OptionChainResponseDataItem> Items { get; set; }
}

/// <summary>
/// Represents the option chain response data item.
/// </summary>
public class OptionChainResponseDataItem
{
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
    /// Gets or sets the active.
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// Gets or sets the strike price.
    /// </summary>
    [JsonPropertyName("strike-price")]
    [JsonConverter(typeof(DecimalOrStringJsonConverter))]
    public decimal StrikePrice { get; set; }

    /// <summary>
    /// Gets or sets the root symbol.
    /// </summary>
    [JsonPropertyName("root-symbol")]
    public string RootSymbol { get; set; }

    /// <summary>
    /// Gets or sets the underlying symbol.
    /// </summary>
    [JsonPropertyName("underlying-symbol")]
    public string UnderlyingSymbol { get; set; }

    /// <summary>
    /// Gets or sets the expiration date.
    /// </summary>
    [JsonPropertyName("expiration-date")]
    public string ExpirationDate { get; set; }

    /// <summary>
    /// Gets or sets the exercise style.
    /// </summary>
    [JsonPropertyName("exercise-style")]
    public string ExerciseStyle { get; set; }

    /// <summary>
    /// Gets or sets the shares per contract.
    /// </summary>
    [JsonPropertyName("shares-per-contract")]
    public int SharesPerContract { get; set; }

    /// <summary>
    /// Gets or sets the option type.
    /// </summary>
    [JsonPropertyName("option-type")]
    public string OptionType { get; set; }

    /// <summary>
    /// Gets or sets the option chain type.
    /// </summary>
    [JsonPropertyName("option-chain-type")]
    public string OptionChainType { get; set; }

    /// <summary>
    /// Gets or sets the expiration type.
    /// </summary>
    [JsonPropertyName("expiration-type")]
    public string ExpirationType { get; set; }

    /// <summary>
    /// Gets or sets the settlement type.
    /// </summary>
    [JsonPropertyName("settlement-type")]
    public string SettlementType { get; set; }

    /// <summary>
    /// Gets or sets the stops trading at.
    /// </summary>
    [JsonPropertyName("stops-trading-at")]
    public DateTime StopsTradingAt { get; set; }

    /// <summary>
    /// Gets or sets the market time instrument collection.
    /// </summary>
    [JsonPropertyName("market-time-instrument-collection")]
    public string MarketTimeInstrumentCollection { get; set; }

    /// <summary>
    /// Gets or sets the days to expiration.
    /// </summary>
    [JsonPropertyName("days-to-expiration")]
    public int DaysToExpiration { get; set; }

    /// <summary>
    /// Gets or sets the expires at.
    /// </summary>
    [JsonPropertyName("expires-at")]
    public DateTime ExpiresAt { get; set; }

    /// <summary>
    /// Gets or sets the is closing only.
    /// </summary>
    [JsonPropertyName("is-closing-only")]
    public bool IsClosingOnly { get; set; }

    /// <summary>
    /// Gets or sets the streamer symbol.
    /// </summary>
    [JsonPropertyName("streamer-symbol")]
    public string StreamerSymbol { get; set; }
}
