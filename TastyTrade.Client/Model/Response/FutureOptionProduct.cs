using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the future option product.
/// </summary>
public class FutureOptionProduct
{
    /// <summary>
    /// Gets or sets the root symbol.
    /// </summary>
    [JsonPropertyName("root-symbol")]
    public string RootSymbol { get; set; }

    /// <summary>
    /// Gets or sets the cash settled.
    /// </summary>
    [JsonPropertyName("cash-settled")]
    public bool CashSettled { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the clearing code.
    /// </summary>
    [JsonPropertyName("clearing-code")]
    public string ClearingCode { get; set; }

    /// <summary>
    /// Gets or sets the clearing exchange code.
    /// </summary>
    [JsonPropertyName("clearing-exchange-code")]
    public string ClearingExchangeCode { get; set; }

    /// <summary>
    /// Gets or sets the clearing price multiplier.
    /// </summary>
    [JsonPropertyName("clearing-price-multiplier")]
    public string ClearingPriceMultiplier { get; set; }

    /// <summary>
    /// Gets or sets the display factor.
    /// </summary>
    [JsonPropertyName("display-factor")]
    public string DisplayFactor { get; set; }

    /// <summary>
    /// Gets or sets the exchange.
    /// </summary>
    [JsonPropertyName("exchange")]
    public string Exchange { get; set; }

    /// <summary>
    /// Gets or sets the product type.
    /// </summary>
    [JsonPropertyName("product-type")]
    public string ProductType { get; set; }

    /// <summary>
    /// Gets or sets the expiration type.
    /// </summary>
    [JsonPropertyName("expiration-type")]
    public string ExpirationType { get; set; }

    /// <summary>
    /// Gets or sets the settlement delay days.
    /// </summary>
    [JsonPropertyName("settlement-delay-days")]
    public int SettlementDelayDays { get; set; }

    /// <summary>
    /// Gets or sets the is rollover.
    /// </summary>
    [JsonPropertyName("is-rollover")]
    public bool IsRollover { get; set; }

    /// <summary>
    /// Gets or sets the market sector.
    /// </summary>
    [JsonPropertyName("market-sector")]
    public string MarketSector { get; set; }

    /// <summary>
    /// Gets or sets the supported.
    /// </summary>
    [JsonPropertyName("supported")]
    public bool Supported { get; set; }

    /// <summary>
    /// Gets or sets the future product.
    /// </summary>
    [JsonPropertyName("future-product")]
    public FutureProduct FutureProduct { get; set; }

    /// <summary>
    /// Gets or sets the futures trading cutoff times.
    /// </summary>
    [JsonPropertyName("futures-trading-cutoff-times")]
    public List<FuturesTradingCutoffTime> FuturesTradingCutoffTimes { get; set; }

    /// <summary>
    /// Gets or sets the legacy code.
    /// </summary>
    [JsonPropertyName("legacy-code")]
    public string LegacyCode { get; set; }

    /// <summary>
    /// Gets or sets the clearport code.
    /// </summary>
    [JsonPropertyName("clearport-code")]
    public string ClearportCode { get; set; }
}

/// <summary>
/// Represents the futures trading cutoff time.
/// </summary>
public class FuturesTradingCutoffTime
{
    /// <summary>
    /// Gets or sets the timezone.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; }

    /// <summary>
    /// Gets or sets the offset seconds.
    /// </summary>
    [JsonPropertyName("offset-seconds")]
    public int OffsetSeconds { get; set; }

    /// <summary>
    /// Gets or sets the timing.
    /// </summary>
    [JsonPropertyName("timing")]
    public string Timing { get; set; }
}
