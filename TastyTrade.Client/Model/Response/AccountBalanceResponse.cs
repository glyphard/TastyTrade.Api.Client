using System;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response;

public class AccountBalanceResponse
{
    [JsonPropertyName("data")]
    public AccountBalanceData Data { get; set; }

    [JsonPropertyName("context")]
    public string Context { get; set; }
}

public class AccountBalanceData
{
    [JsonPropertyName("account-number")]
    public string AccountNumber { get; set; }

    [JsonPropertyName("available-trading-funds")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? AvailableTradingFunds { get; set; }

    [JsonPropertyName("bond-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? BondMarginRequirement { get; set; }

    [JsonPropertyName("cash-available-to-withdraw")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? CashAvailableToWithdraw { get; set; }

    [JsonPropertyName("cash-balance")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? CashBalance { get; set; }

    [JsonPropertyName("cash-settle-balance")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? CashSettleBalance { get; set; }

    [JsonPropertyName("closed-loop-available-balance")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ClosedLoopAvailableBalance { get; set; }

    [JsonPropertyName("cryptocurrency-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? CryptocurrencyMarginRequirement { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("day-equity-call-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? DayEquityCallValue { get; set; }

    [JsonPropertyName("day-trade-excess")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? DayTradeExcess { get; set; }

    [JsonPropertyName("day-trading-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? DayTradingBuyingPower { get; set; }

    [JsonPropertyName("day-trading-call-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? DayTradingCallValue { get; set; }

    [JsonPropertyName("derivative-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? DerivativeBuyingPower { get; set; }

    [JsonPropertyName("equity-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? EquityBuyingPower { get; set; }

    [JsonPropertyName("equity-offering-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? EquityOfferingMarginRequirement { get; set; }

    [JsonPropertyName("futures-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? FuturesMarginRequirement { get; set; }

    [JsonPropertyName("long-bond-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongBondValue { get; set; }

    [JsonPropertyName("long-cryptocurrency-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongCryptocurrencyValue { get; set; }

    [JsonPropertyName("long-derivative-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongDerivativeValue { get; set; }

    [JsonPropertyName("long-equity-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongEquityValue { get; set; }

    [JsonPropertyName("long-futures-derivative-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongFuturesDerivativeValue { get; set; }

    [JsonPropertyName("long-futures-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongFuturesValue { get; set; }

    [JsonPropertyName("long-margineable-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? LongMargineableValue { get; set; }

    [JsonPropertyName("maintenance-call-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? MaintenanceCallValue { get; set; }

    [JsonPropertyName("maintenance-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? MaintenanceRequirement { get; set; }

    [JsonPropertyName("margin-equity")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? MarginEquity { get; set; }

    [JsonPropertyName("margin-settle-balance")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? MarginSettleBalance { get; set; }

    [JsonPropertyName("net-liquidating-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? NetLiquidatingValue { get; set; }

    [JsonPropertyName("pending-cash")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? PendingCash { get; set; }

    [JsonPropertyName("pending-cash-effect")]
    public string PendingCashEffect { get; set; }

    [JsonPropertyName("reg-t-call-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? RegTCallValue { get; set; }

    [JsonPropertyName("short-cryptocurrency-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortCryptocurrencyValue { get; set; }

    [JsonPropertyName("short-derivative-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortDerivativeValue { get; set; }

    [JsonPropertyName("short-equity-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortEquityValue { get; set; }

    [JsonPropertyName("short-futures-derivative-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortFuturesDerivativeValue { get; set; }

    [JsonPropertyName("short-futures-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortFuturesValue { get; set; }

    [JsonPropertyName("short-margineable-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ShortMargineableValue { get; set; }

    [JsonPropertyName("sma-equity-option-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? SmaEquityOptionBuyingPower { get; set; }

    [JsonPropertyName("special-memorandum-account-apex-adjustment")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? SpecialMemorandumAccountApexAdjustment { get; set; }

    [JsonPropertyName("special-memorandum-account-value")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? SpecialMemorandumAccountValue { get; set; }

    [JsonPropertyName("total-settle-balance")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? TotalSettleBalance { get; set; }

    [JsonPropertyName("unsettled-cryptocurrency-fiat-amount")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? UnsettledCryptocurrencyFiatAmount { get; set; }

    [JsonPropertyName("unsettled-cryptocurrency-fiat-effect")]
    public string UnsettledCryptocurrencyFiatEffect { get; set; }

    [JsonPropertyName("used-derivative-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? UsedDerivativeBuyingPower { get; set; }

    [JsonPropertyName("snapshot-date")]
    public string SnapshotDate { get; set; }

    [JsonPropertyName("reg-t-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? RegTMarginRequirement { get; set; }

    [JsonPropertyName("futures-overnight-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? FuturesOvernightMarginRequirement { get; set; }

    [JsonPropertyName("futures-intraday-margin-requirement")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? FuturesIntradayMarginRequirement { get; set; }

    [JsonPropertyName("maintenance-excess")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? MaintenanceExcess { get; set; }

    [JsonPropertyName("pending-margin-interest")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? PendingMarginInterest { get; set; }

    [JsonPropertyName("effective-cryptocurrency-buying-power")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? EffectiveCryptocurrencyBuyingPower { get; set; }

    [JsonPropertyName("updated-at")]
    public DateTime UpdatedAt { get; set; }
}