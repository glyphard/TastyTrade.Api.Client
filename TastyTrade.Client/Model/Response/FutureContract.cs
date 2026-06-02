using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the future contract.
/// </summary>
public class FutureContract
{
    /// <summary>
    /// Gets or sets the symbol.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    /// <summary>
    /// Gets or sets the product code.
    /// </summary>
    [JsonPropertyName("product-code")]
    public string ProductCode { get; set; }

    /// <summary>
    /// Gets or sets the contract size.
    /// </summary>
    [JsonPropertyName("contract-size")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? ContractSize { get; set; }

    /// <summary>
    /// Gets or sets the tick size.
    /// </summary>
    [JsonPropertyName("tick-size")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? TickSize { get; set; }

    /// <summary>
    /// Gets or sets the notional multiplier.
    /// </summary>
    [JsonPropertyName("notional-multiplier")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? NotionalMultiplier { get; set; }

    /// <summary>
    /// Gets or sets the main fraction.
    /// </summary>
    [JsonPropertyName("main-fraction")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? MainFraction { get; set; }

    /// <summary>
    /// Gets or sets the sub fraction.
    /// </summary>
    [JsonPropertyName("sub-fraction")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? SubFraction { get; set; }

    /// <summary>
    /// Gets or sets the display factor.
    /// </summary>
    [JsonPropertyName("display-factor")]
    [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
    public decimal? DisplayFactor { get; set; }

    /// <summary>
    /// Gets or sets the last trade date.
    /// </summary>
    [JsonPropertyName("last-trade-date")]
    public string LastTradeDate { get; set; }

    /// <summary>
    /// Gets or sets the expiration date.
    /// </summary>
    [JsonPropertyName("expiration-date")]
    public string ExpirationDate { get; set; }

    /// <summary>
    /// Gets or sets the closing only date.
    /// </summary>
    [JsonPropertyName("closing-only-date")]
    public string ClosingOnlyDate { get; set; }

    /// <summary>
    /// Gets or sets the active.
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// Gets or sets the active month.
    /// </summary>
    [JsonPropertyName("active-month")]
    public bool ActiveMonth { get; set; }

    /// <summary>
    /// Gets or sets the next active month.
    /// </summary>
    [JsonPropertyName("next-active-month")]
    public bool NextActiveMonth { get; set; }

    /// <summary>
    /// Gets or sets the is closing only.
    /// </summary>
    [JsonPropertyName("is-closing-only")]
    public bool IsClosingOnly { get; set; }

    /// <summary>
    /// Gets or sets the stops trading at.
    /// </summary>
    [JsonPropertyName("stops-trading-at")]
    public DateTime StopsTradingAt { get; set; }

    /// <summary>
    /// Gets or sets the expires at.
    /// </summary>
    [JsonPropertyName("expires-at")]
    public DateTime ExpiresAt { get; set; }

    /// <summary>
    /// Gets or sets the product group.
    /// </summary>
    [JsonPropertyName("product-group")]
    public string ProductGroup { get; set; }

    /// <summary>
    /// Gets or sets the exchange.
    /// </summary>
    [JsonPropertyName("exchange")]
    public string Exchange { get; set; }

    /// <summary>
    /// Gets or sets the roll target symbol.
    /// </summary>
    [JsonPropertyName("roll-target-symbol")]
    public string RollTargetSymbol { get; set; }

    /// <summary>
    /// Gets or sets the streamer exchange code.
    /// </summary>
    [JsonPropertyName("streamer-exchange-code")]
    public string StreamerExchangeCode { get; set; }

    /// <summary>
    /// Gets or sets the streamer symbol.
    /// </summary>
    [JsonPropertyName("streamer-symbol")]
    public string StreamerSymbol { get; set; }

    /// <summary>
    /// Gets or sets the back month first calendar symbol.
    /// </summary>
    [JsonPropertyName("back-month-first-calendar-symbol")]
    public bool BackMonthFirstCalendarSymbol { get; set; }

    /// <summary>
    /// Gets or sets the is tradeable.
    /// </summary>
    [JsonPropertyName("is-tradeable")]
    public bool IsTradeable { get; set; }

    /// <summary>
    /// Gets or sets the future etf equivalent.
    /// </summary>
    [JsonPropertyName("future-etf-equivalent")]
    public FutureEtfEquivalent FutureEtfEquivalent { get; set; }

    /// <summary>
    /// Gets or sets the future product.
    /// </summary>
    [JsonPropertyName("future-product")]
    public FutureProduct FutureProduct { get; set; }

    /// <summary>
    /// Gets or sets the tick sizes.
    /// </summary>
    [JsonPropertyName("tick-sizes")]
    public List<TickSize> TickSizes { get; set; }

    /// <summary>
    /// Gets or sets the option tick sizes.
    /// </summary>
    [JsonPropertyName("option-tick-sizes")]
    public List<TickSize> OptionTickSizes { get; set; }

    /// <summary>
    /// Gets or sets the spread tick sizes.
    /// </summary>
    [JsonPropertyName("spread-tick-sizes")]
    public List<SpreadTickSize> SpreadTickSizes { get; set; }

    /// <summary>
    /// Gets or sets the first notice date.
    /// </summary>
    [JsonPropertyName("first-notice-date")]
    public string FirstNoticeDate { get; set; }
}

/// <summary>
/// Represents the future etf equivalent.
/// </summary>
public class FutureEtfEquivalent
{
    /// <summary>
    /// Gets or sets the symbol.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    /// <summary>
    /// Gets or sets the share quantity.
    /// </summary>
    [JsonPropertyName("share-quantity")]
    public int ShareQuantity { get; set; }
}

/// <summary>
/// Represents the future product.
/// </summary>
public class FutureProduct
{
    /// <summary>
    /// Gets or sets the root symbol.
    /// </summary>
    [JsonPropertyName("root-symbol")]
    public string RootSymbol { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

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
    /// Gets or sets the clearport code.
    /// </summary>
    [JsonPropertyName("clearport-code")]
    public string ClearportCode { get; set; }

    /// <summary>
    /// Gets or sets the legacy code.
    /// </summary>
    [JsonPropertyName("legacy-code")]
    public string LegacyCode { get; set; }

    /// <summary>
    /// Gets or sets the exchange.
    /// </summary>
    [JsonPropertyName("exchange")]
    public string Exchange { get; set; }

    /// <summary>
    /// Gets or sets the legacy exchange code.
    /// </summary>
    [JsonPropertyName("legacy-exchange-code")]
    public string LegacyExchangeCode { get; set; }

    /// <summary>
    /// Gets or sets the product type.
    /// </summary>
    [JsonPropertyName("product-type")]
    public string ProductType { get; set; }

    /// <summary>
    /// Gets or sets the listed months.
    /// </summary>
    [JsonPropertyName("listed-months")]
    public List<string> ListedMonths { get; set; }

    /// <summary>
    /// Gets or sets the active months.
    /// </summary>
    [JsonPropertyName("active-months")]
    public List<string> ActiveMonths { get; set; }

    /// <summary>
    /// Gets or sets the notional multiplier.
    /// </summary>
    [JsonPropertyName("notional-multiplier")]
    public string NotionalMultiplier { get; set; }

    /// <summary>
    /// Gets or sets the tick size.
    /// </summary>
    [JsonPropertyName("tick-size")]
    public string TickSize { get; set; }

    /// <summary>
    /// Gets or sets the display factor.
    /// </summary>
    [JsonPropertyName("display-factor")]
    public string DisplayFactor { get; set; }

    /// <summary>
    /// Gets or sets the streamer exchange code.
    /// </summary>
    [JsonPropertyName("streamer-exchange-code")]
    public string StreamerExchangeCode { get; set; }

    /// <summary>
    /// Gets or sets the small notional.
    /// </summary>
    [JsonPropertyName("small-notional")]
    public bool SmallNotional { get; set; }

    /// <summary>
    /// Gets or sets the back month first calendar symbol.
    /// </summary>
    [JsonPropertyName("back-month-first-calendar-symbol")]
    public bool BackMonthFirstCalendarSymbol { get; set; }

    /// <summary>
    /// Gets or sets the first notice.
    /// </summary>
    [JsonPropertyName("first-notice")]
    public bool FirstNotice { get; set; }

    /// <summary>
    /// Gets or sets the cash settled.
    /// </summary>
    [JsonPropertyName("cash-settled")]
    public bool CashSettled { get; set; }

    /// <summary>
    /// Gets or sets the security group.
    /// </summary>
    [JsonPropertyName("security-group")]
    public string SecurityGroup { get; set; }

    /// <summary>
    /// Gets or sets the market sector.
    /// </summary>
    [JsonPropertyName("market-sector")]
    public string MarketSector { get; set; }

    /// <summary>
    /// Gets or sets the roll.
    /// </summary>
    [JsonPropertyName("roll")]
    public Roll Roll { get; set; }

    /// <summary>
    /// Gets or sets the contract limit.
    /// </summary>
    [JsonPropertyName("contract-limit")]
    public int? ContractLimit { get; set; }

    /// <summary>
    /// Gets or sets the base tick.
    /// </summary>
    [JsonPropertyName("base-tick")]
    public int? BaseTick { get; set; }

    /// <summary>
    /// Gets or sets the price format.
    /// </summary>
    [JsonPropertyName("price-format")]
    public string PriceFormat { get; set; }

    /// <summary>
    /// Gets or sets the sub tick.
    /// </summary>
    [JsonPropertyName("sub-tick")]
    public int? SubTick { get; set; }
}

/// <summary>
/// Represents the roll.
/// </summary>
public class Roll
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the active count.
    /// </summary>
    [JsonPropertyName("active-count")]
    public int ActiveCount { get; set; }

    /// <summary>
    /// Gets or sets the cash settled.
    /// </summary>
    [JsonPropertyName("cash-settled")]
    public bool CashSettled { get; set; }

    /// <summary>
    /// Gets or sets the business days offset.
    /// </summary>
    [JsonPropertyName("business-days-offset")]
    public int BusinessDaysOffset { get; set; }

    /// <summary>
    /// Gets or sets the first notice.
    /// </summary>
    [JsonPropertyName("first-notice")]
    public bool FirstNotice { get; set; }
}

/// <summary>
/// Represents the spread tick size.
/// </summary>
public class SpreadTickSize
{
    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }

    /// <summary>
    /// Gets or sets the symbol.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }
}
