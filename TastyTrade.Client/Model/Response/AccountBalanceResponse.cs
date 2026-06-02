using System;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the account balance response.
/// </summary>
public class AccountBalanceResponse
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public AccountBalanceData Data { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}

/// <summary>
/// Represents the account balance data.
/// </summary>
public class AccountBalanceData
{
    /// <summary>
    /// Gets or sets the account number.
    /// </summary>
    [JsonPropertyName("account-number")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the available trading funds.
    /// </summary>
    [JsonPropertyName("available-trading-funds")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? AvailableTradingFunds { get; set; }

    /// <summary>
    /// Gets or sets the bond margin requirement.
    /// </summary>
    [JsonPropertyName("bond-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? BondMarginRequirement { get; set; }

    /// <summary>
    /// Gets or sets the cash available to withdraw.
    /// </summary>
    [JsonPropertyName("cash-available-to-withdraw")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? CashAvailableToWithdraw { get; set; }

    /// <summary>
    /// Gets or sets the cash balance.
    /// </summary>
    [JsonPropertyName("cash-balance")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? CashBalance { get; set; }

    /// <summary>
    /// Gets or sets the cash settle balance.
    /// </summary>
    [JsonPropertyName("cash-settle-balance")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? CashSettleBalance { get; set; }

    /// <summary>
    /// Gets or sets the closed loop available balance.
    /// </summary>
    [JsonPropertyName("closed-loop-available-balance")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ClosedLoopAvailableBalance { get; set; }

    /// <summary>
    /// Gets or sets the cryptocurrency margin requirement.
    /// </summary>
    [JsonPropertyName("cryptocurrency-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? CryptocurrencyMarginRequirement { get; set; }

    /// <summary>
    /// Gets or sets the currency.
    /// </summary>
    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or sets the day equity call value.
    /// </summary>
    [JsonPropertyName("day-equity-call-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? DayEquityCallValue { get; set; }

    /// <summary>
    /// Gets or sets the day trade excess.
    /// </summary>
    [JsonPropertyName("day-trade-excess")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? DayTradeExcess { get; set; }

    /// <summary>
    /// Gets or sets the day trading buying power.
    /// </summary>
    [JsonPropertyName("day-trading-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? DayTradingBuyingPower { get; set; }

    /// <summary>
    /// Gets or sets the day trading call value.
    /// </summary>
    [JsonPropertyName("day-trading-call-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? DayTradingCallValue { get; set; }

    /// <summary>
    /// Gets or sets the derivative buying power.
    /// </summary>
    [JsonPropertyName("derivative-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? DerivativeBuyingPower { get; set; }

    /// <summary>
    /// Gets or sets the equity buying power.
    /// </summary>
    [JsonPropertyName("equity-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? EquityBuyingPower { get; set; }

    /// <summary>
    /// Gets or sets the equity offering margin requirement.
    /// </summary>
    [JsonPropertyName("equity-offering-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? EquityOfferingMarginRequirement { get; set; }

    /// <summary>
    /// Gets or sets the futures margin requirement.
    /// </summary>
    [JsonPropertyName("futures-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? FuturesMarginRequirement { get; set; }

    /// <summary>
    /// Gets or sets the long bond value.
    /// </summary>
    [JsonPropertyName("long-bond-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongBondValue { get; set; }

    /// <summary>
    /// Gets or sets the long cryptocurrency value.
    /// </summary>
    [JsonPropertyName("long-cryptocurrency-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongCryptocurrencyValue { get; set; }

    /// <summary>
    /// Gets or sets the long derivative value.
    /// </summary>
    [JsonPropertyName("long-derivative-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongDerivativeValue { get; set; }

    /// <summary>
    /// Gets or sets the long equity value.
    /// </summary>
    [JsonPropertyName("long-equity-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongEquityValue { get; set; }

    /// <summary>
    /// Gets or sets the long futures derivative value.
    /// </summary>
    [JsonPropertyName("long-futures-derivative-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongFuturesDerivativeValue { get; set; }

    /// <summary>
    /// Gets or sets the long futures value.
    /// </summary>
    [JsonPropertyName("long-futures-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongFuturesValue { get; set; }

    /// <summary>
    /// Gets or sets the long margineable value.
    /// </summary>
    [JsonPropertyName("long-margineable-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongMargineableValue { get; set; }

    /// <summary>
    /// Gets or sets the maintenance call value.
    /// </summary>
    [JsonPropertyName("maintenance-call-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? MaintenanceCallValue { get; set; }

    /// <summary>
    /// Gets or sets the maintenance requirement.
    /// </summary>
    [JsonPropertyName("maintenance-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? MaintenanceRequirement { get; set; }

    /// <summary>
    /// Gets or sets the margin equity.
    /// </summary>
    [JsonPropertyName("margin-equity")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? MarginEquity { get; set; }

    /// <summary>
    /// Gets or sets the margin settle balance.
    /// </summary>
    [JsonPropertyName("margin-settle-balance")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? MarginSettleBalance { get; set; }

    /// <summary>
    /// Gets or sets the net liquidating value.
    /// </summary>
    [JsonPropertyName("net-liquidating-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? NetLiquidatingValue { get; set; }

    /// <summary>
    /// Gets or sets the pending cash.
    /// </summary>
    [JsonPropertyName("pending-cash")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? PendingCash { get; set; }

    /// <summary>
    /// Gets or sets the pending cash effect.
    /// </summary>
    [JsonPropertyName("pending-cash-effect")]
    public string PendingCashEffect { get; set; }

    /// <summary>
    /// Gets or sets the reg t call value.
    /// </summary>
    [JsonPropertyName("reg-t-call-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? RegTCallValue { get; set; }

    /// <summary>
    /// Gets or sets the short cryptocurrency value.
    /// </summary>
    [JsonPropertyName("short-cryptocurrency-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortCryptocurrencyValue { get; set; }

    /// <summary>
    /// Gets or sets the short derivative value.
    /// </summary>
    [JsonPropertyName("short-derivative-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortDerivativeValue { get; set; }

    /// <summary>
    /// Gets or sets the short equity value.
    /// </summary>
    [JsonPropertyName("short-equity-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortEquityValue { get; set; }

    /// <summary>
    /// Gets or sets the short futures derivative value.
    /// </summary>
    [JsonPropertyName("short-futures-derivative-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortFuturesDerivativeValue { get; set; }

    /// <summary>
    /// Gets or sets the short futures value.
    /// </summary>
    [JsonPropertyName("short-futures-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortFuturesValue { get; set; }

    /// <summary>
    /// Gets or sets the short margineable value.
    /// </summary>
    [JsonPropertyName("short-margineable-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortMargineableValue { get; set; }

    /// <summary>
    /// Gets or sets the sma equity option buying power.
    /// </summary>
    [JsonPropertyName("sma-equity-option-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? SmaEquityOptionBuyingPower { get; set; }

    /// <summary>
    /// Gets or sets the special memorandum account apex adjustment.
    /// </summary>
    [JsonPropertyName("special-memorandum-account-apex-adjustment")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? SpecialMemorandumAccountApexAdjustment { get; set; }

    /// <summary>
    /// Gets or sets the special memorandum account value.
    /// </summary>
    [JsonPropertyName("special-memorandum-account-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? SpecialMemorandumAccountValue { get; set; }

    /// <summary>
    /// Gets or sets the total settle balance.
    /// </summary>
    [JsonPropertyName("total-settle-balance")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? TotalSettleBalance { get; set; }

    /// <summary>
    /// Gets or sets the unsettled cryptocurrency fiat amount.
    /// </summary>
    [JsonPropertyName("unsettled-cryptocurrency-fiat-amount")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? UnsettledCryptocurrencyFiatAmount { get; set; }

    /// <summary>
    /// Gets or sets the unsettled cryptocurrency fiat effect.
    /// </summary>
    [JsonPropertyName("unsettled-cryptocurrency-fiat-effect")]
    public string UnsettledCryptocurrencyFiatEffect { get; set; }

    /// <summary>
    /// Gets or sets the used derivative buying power.
    /// </summary>
    [JsonPropertyName("used-derivative-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? UsedDerivativeBuyingPower { get; set; }

    /// <summary>
    /// Gets or sets the snapshot date.
    /// </summary>
    [JsonPropertyName("snapshot-date")]
    public string SnapshotDate { get; set; }

    /// <summary>
    /// Gets or sets the reg t margin requirement.
    /// </summary>
    [JsonPropertyName("reg-t-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? RegTMarginRequirement { get; set; }

    /// <summary>
    /// Gets or sets the futures overnight margin requirement.
    /// </summary>
    [JsonPropertyName("futures-overnight-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? FuturesOvernightMarginRequirement { get; set; }

    /// <summary>
    /// Gets or sets the futures intraday margin requirement.
    /// </summary>
    [JsonPropertyName("futures-intraday-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? FuturesIntradayMarginRequirement { get; set; }

    /// <summary>
    /// Gets or sets the maintenance excess.
    /// </summary>
    [JsonPropertyName("maintenance-excess")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? MaintenanceExcess { get; set; }

    /// <summary>
    /// Gets or sets the pending margin interest.
    /// </summary>
    [JsonPropertyName("pending-margin-interest")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? PendingMarginInterest { get; set; }

    /// <summary>
    /// Gets or sets the effective cryptocurrency buying power.
    /// </summary>
    [JsonPropertyName("effective-cryptocurrency-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? EffectiveCryptocurrencyBuyingPower { get; set; }

    /// <summary>
    /// Gets or sets the updated at.
    /// </summary>
    [JsonPropertyName("updated-at")]
    public DateTime UpdatedAt { get; set; }
}