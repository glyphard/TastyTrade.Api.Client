using System;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the trading status response.
/// </summary>
public class TradingStatusResponse
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public TradingStatusData Data { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}

/// <summary>
/// Represents the trading status data.
/// </summary>
public class TradingStatusData
{
    /// <summary>
    /// Gets or sets the account number.
    /// </summary>
    [JsonPropertyName("account-number")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the equities margin calculation type.
    /// </summary>
    [JsonPropertyName("equities-margin-calculation-type")]
    public string EquitiesMarginCalculationType { get; set; }

    /// <summary>
    /// Gets or sets the fee schedule name.
    /// </summary>
    [JsonPropertyName("fee-schedule-name")]
    public string FeeScheduleName { get; set; }

    /// <summary>
    /// Gets or sets the futures margin rate multiplier.
    /// </summary>
    [JsonPropertyName("futures-margin-rate-multiplier")]
    public string FuturesMarginRateMultiplier { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the are deep itm carry options enabled.
    /// </summary>
    [JsonPropertyName("are-deep-itm-carry-options-enabled")]
    public bool AreDeepItmCarryOptionsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the are far otm net options restricted.
    /// </summary>
    [JsonPropertyName("are-far-otm-net-options-restricted")]
    public bool AreFarOtmNetOptionsRestricted { get; set; }

    /// <summary>
    /// Gets or sets the are options values restricted to nlv.
    /// </summary>
    [JsonPropertyName("are-options-values-restricted-to-nlv")]
    public bool AreOptionsValuesRestrictedToNlv { get; set; }

    /// <summary>
    /// Gets or sets the are single tick expiring hedges ignored.
    /// </summary>
    [JsonPropertyName("are-single-tick-expiring-hedges-ignored")]
    public bool AreSingleTickExpiringHedgesIgnored { get; set; }

    /// <summary>
    /// Gets or sets the has intraday equities margin.
    /// </summary>
    [JsonPropertyName("has-intraday-equities-margin")]
    public bool HasIntradayEquitiesMargin { get; set; }

    /// <summary>
    /// Gets or sets the is aggregated at clearing.
    /// </summary>
    [JsonPropertyName("is-aggregated-at-clearing")]
    public bool IsAggregatedAtClearing { get; set; }

    /// <summary>
    /// Gets or sets the is closed.
    /// </summary>
    [JsonPropertyName("is-closed")]
    public bool IsClosed { get; set; }

    /// <summary>
    /// Gets or sets the is closing only.
    /// </summary>
    [JsonPropertyName("is-closing-only")]
    public bool IsClosingOnly { get; set; }

    /// <summary>
    /// Gets or sets the is cryptocurrency closing only.
    /// </summary>
    [JsonPropertyName("is-cryptocurrency-closing-only")]
    public bool IsCryptocurrencyClosingOnly { get; set; }

    /// <summary>
    /// Gets or sets the is cryptocurrency enabled.
    /// </summary>
    [JsonPropertyName("is-cryptocurrency-enabled")]
    public bool IsCryptocurrencyEnabled { get; set; }

    /// <summary>
    /// Gets or sets the is equity offering closing only.
    /// </summary>
    [JsonPropertyName("is-equity-offering-closing-only")]
    public bool IsEquityOfferingClosingOnly { get; set; }

    /// <summary>
    /// Gets or sets the is equity offering enabled.
    /// </summary>
    [JsonPropertyName("is-equity-offering-enabled")]
    public bool IsEquityOfferingEnabled { get; set; }

    /// <summary>
    /// Gets or sets the is frozen.
    /// </summary>
    [JsonPropertyName("is-frozen")]
    public bool IsFrozen { get; set; }

    /// <summary>
    /// Gets or sets the is full equity margin required.
    /// </summary>
    [JsonPropertyName("is-full-equity-margin-required")]
    public bool IsFullEquityMarginRequired { get; set; }

    /// <summary>
    /// Gets or sets the is futures closing only.
    /// </summary>
    [JsonPropertyName("is-futures-closing-only")]
    public bool IsFuturesClosingOnly { get; set; }

    /// <summary>
    /// Gets or sets the is futures enabled.
    /// </summary>
    [JsonPropertyName("is-futures-enabled")]
    public bool IsFuturesEnabled { get; set; }

    /// <summary>
    /// Gets or sets the is futures intra day enabled.
    /// </summary>
    [JsonPropertyName("is-futures-intra-day-enabled")]
    public bool IsFuturesIntraDayEnabled { get; set; }

    /// <summary>
    /// Gets or sets the is in day trade equity maintenance call.
    /// </summary>
    [JsonPropertyName("is-in-day-trade-equity-maintenance-call")]
    public bool IsInDayTradeEquityMaintenanceCall { get; set; }

    /// <summary>
    /// Gets or sets the is in margin call.
    /// </summary>
    [JsonPropertyName("is-in-margin-call")]
    public bool IsInMarginCall { get; set; }

    /// <summary>
    /// Gets or sets the is pattern day trader.
    /// </summary>
    [JsonPropertyName("is-pattern-day-trader")]
    public bool IsPatternDayTrader { get; set; }

    /// <summary>
    /// Gets or sets the is portfolio margin enabled.
    /// </summary>
    [JsonPropertyName("is-portfolio-margin-enabled")]
    public bool IsPortfolioMarginEnabled { get; set; }

    /// <summary>
    /// Gets or sets the is risk reducing only.
    /// </summary>
    [JsonPropertyName("is-risk-reducing-only")]
    public bool IsRiskReducingOnly { get; set; }

    /// <summary>
    /// Gets or sets the is roll the day forward enabled.
    /// </summary>
    [JsonPropertyName("is-roll-the-day-forward-enabled")]
    public bool IsRollTheDayForwardEnabled { get; set; }

    /// <summary>
    /// Gets or sets the is small notional futures intra day enabled.
    /// </summary>
    [JsonPropertyName("is-small-notional-futures-intra-day-enabled")]
    public bool IsSmallNotionalFuturesIntraDayEnabled { get; set; }

    /// <summary>
    /// Gets or sets the short calls enabled.
    /// </summary>
    [JsonPropertyName("short-calls-enabled")]
    public bool ShortCallsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the options level.
    /// </summary>
    [JsonPropertyName("options-level")]
    public string OptionsLevel { get; set; }

    /// <summary>
    /// Gets or sets the small notional futures margin rate multiplier.
    /// </summary>
    [JsonPropertyName("small-notional-futures-margin-rate-multiplier")]
    public string SmallNotionalFuturesMarginRateMultiplier { get; set; }

    /// <summary>
    /// Gets or sets the enhanced fraud safeguards enabled at.
    /// </summary>
    [JsonPropertyName("enhanced-fraud-safeguards-enabled-at")]
    public DateTimeOffset EnhancedFraudSafeguardsEnabledAt { get; set; }

    /// <summary>
    /// Gets or sets the updated at.
    /// </summary>
    [JsonPropertyName("updated-at")]
    public DateTimeOffset UpdatedAt { get; set; }
}
