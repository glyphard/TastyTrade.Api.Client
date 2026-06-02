using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response
{
    /// <summary>
    /// Represents the market data response.
    /// </summary>
    public class MarketDataResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public MarketData Data { get; set; }

    }
    /// <summary>
    /// Represents the market data.
    /// </summary>
    public class MarketData {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [JsonPropertyName("items")]
        public List<MarketDataItem> Items { get; set; }

    }
    /// <summary>
    /// Represents the market data item.
    /// </summary>
    public class MarketDataItem
        {

            /// <summary>
            /// Gets or sets the last mkt.
            /// </summary>
            [JsonPropertyName("lastMkt")]
            [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? LastMkt { get; set; }

        /// <summary>
        /// Gets or sets the trading halted.
        /// </summary>
        [JsonPropertyName("tradingHalted")]
        public bool TradingHalted { get; set; }

        /// <summary>
        /// Gets or sets the instrument type.
        /// </summary>
        [JsonPropertyName("instrumentType")]
        public string? InstrumentType { get; set; }

        /// <summary>
        /// Gets or sets the low limit price.
        /// </summary>
        [JsonPropertyName("lowLimitPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? LowLimitPrice { get; set; }

        /// <summary>
        /// Gets or sets the trading halted reason.
        /// </summary>
        [JsonPropertyName("tradingHaltedReason")]
        public string? TradingHaltedReason { get; set; }

        /// <summary>
        /// Gets or sets the prev close.
        /// </summary>
        [JsonPropertyName("prevClose")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? PrevClose { get; set; }

        /// <summary>
        /// Gets or sets the dividend amount.
        /// </summary>
        [JsonPropertyName("dividendAmount")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? DividendAmount { get; set; }

        // epoch/ms or service-defined numeric timestamp
        /// <summary>
        /// Gets or sets the halt end time.
        /// </summary>
        [JsonPropertyName("haltEndTime")]
        [JsonConverter(typeof(LongOrStringJsonConverter))]
        public long HaltEndTime { get; set; }

        /// <summary>
        /// Gets or sets the instrument.
        /// </summary>
        [JsonPropertyName("instrument")]
        public Instrument? Instrument { get; set; }

        /// <summary>
        /// Gets or sets the mid.
        /// </summary>
        [JsonPropertyName("mid")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Mid { get; set; }

        /// <summary>
        /// Gets or sets the year high price.
        /// </summary>
        [JsonPropertyName("yearHighPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? YearHighPrice { get; set; }

        /// <summary>
        /// Gets or sets the open.
        /// </summary>
        [JsonPropertyName("open")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Open { get; set; }

        /// <summary>
        /// Gets or sets the day high price.
        /// </summary>
        [JsonPropertyName("dayHighPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? DayHighPrice { get; set; }

        /// <summary>
        /// Gets or sets the close price type.
        /// </summary>
        [JsonPropertyName("closePriceType")]
        public string? ClosePriceType { get; set; }

        /// <summary>
        /// Gets or sets the last ext.
        /// </summary>
        [JsonPropertyName("lastExt")]
        [JsonConverter(typeof(LongOrStringJsonConverter))]
        public long LastExt { get; set; }

        /// <summary>
        /// Gets or sets the dividend frequency.
        /// </summary>
        [JsonPropertyName("dividendFrequency")]
        [JsonConverter(typeof(IntOrStringJsonConverter))]
        public int DividendFrequency { get; set; }

        /// <summary>
        /// Gets or sets the mark.
        /// </summary>
        [JsonPropertyName("mark")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Mark { get; set; }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the halt start time.
        /// </summary>
        [JsonPropertyName("haltStartTime")]
        [JsonConverter(typeof(LongOrStringJsonConverter))]
        public long HaltStartTime { get; set; }

        /// <summary>
        /// Gets or sets the high limit price.
        /// </summary>
        [JsonPropertyName("highLimitPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? HighLimitPrice { get; set; }

        /// <summary>
        /// Gets or sets the beta.
        /// </summary>
        [JsonPropertyName("beta")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Beta { get; set; }

        /// <summary>
        /// Gets or sets the day low price.
        /// </summary>
        [JsonPropertyName("dayLowPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? DayLowPrice { get; set; }

        /// <summary>
        /// Gets or sets the year low price.
        /// </summary>
        [JsonPropertyName("yearLowPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? YearLowPrice { get; set; }

        // kept as string to match "YYYY-MM-DD" payload exactly
        /// <summary>
        /// Gets or sets the prev close date.
        /// </summary>
        [JsonPropertyName("prevCloseDate")]
        public string? PrevCloseDate { get; set; }

        /// <summary>
        /// Gets or sets the summary date.
        /// </summary>
        [JsonPropertyName("summaryDate")]
        public string? SummaryDate { get; set; }

        /// <summary>
        /// Gets or sets the last.
        /// </summary>
        [JsonPropertyName("last")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Last { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        /// <summary>
        /// Gets or sets the close.
        /// </summary>
        [JsonPropertyName("close")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Close { get; set; }

        /// <summary>
        /// Gets or sets the ask.
        /// </summary>
        [JsonPropertyName("ask")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Ask { get; set; }

        /// <summary>
        /// Gets or sets the ask size.
        /// </summary>
        [JsonPropertyName("askSize")]
        [JsonConverter(typeof(IntOrStringJsonConverter))]
        public int AskSize { get; set; }

        /// <summary>
        /// Gets or sets the volume.
        /// </summary>
        [JsonPropertyName("volume")]
        [JsonConverter(typeof(LongOrStringJsonConverter))]
        public long Volume { get; set; }

        /// <summary>
        /// Gets or sets the last trade time.
        /// </summary>
        [JsonPropertyName("lastTradeTime")]
        [JsonConverter(typeof(LongOrStringJsonConverter))]
        public long LastTradeTime { get; set; }

        /// <summary>
        /// Gets or sets the bid.
        /// </summary>
        [JsonPropertyName("bid")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Bid { get; set; }

        /// <summary>
        /// Gets or sets the prev close price type.
        /// </summary>
        [JsonPropertyName("prevClosePriceType")]
        public string? PrevClosePriceType { get; set; }

        /// <summary>
        /// Gets or sets the bid size.
        /// </summary>
        [JsonPropertyName("bidSize")]
        [JsonConverter(typeof(IntOrStringJsonConverter))]
        public int BidSize { get; set; }
    }

    /// <summary>
    /// Represents the instrument.
    /// </summary>
    public class Instrument
    {
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        /// <summary>
        /// Gets or sets the instrument type.
        /// </summary>
        [JsonPropertyName("instrumentType")]
        public string? InstrumentType { get; set; }

        /// <summary>
        /// Gets or sets the instrument key.
        /// </summary>
        [JsonPropertyName("instrumentKey")]
        public InstrumentKey? InstrumentKey { get; set; }

        /// <summary>
        /// Gets or sets the underlying instrument.
        /// </summary>
        [JsonPropertyName("underlyingInstrument")]
        public string? UnderlyingInstrument { get; set; }

        /// <summary>
        /// Gets or sets the root symbol.
        /// </summary>
        [JsonPropertyName("rootSymbol")]
        public string? RootSymbol { get; set; }

        /// <summary>
        /// Gets or sets the exchange.
        /// </summary>
        [JsonPropertyName("exchange")]
        public string? Exchange { get; set; }
    }

    /// <summary>
    /// Represents the instrument key.
    /// </summary>
    public class InstrumentKey
    {
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        /// <summary>
        /// Gets or sets the instrument type.
        /// </summary>
        [JsonPropertyName("instrumentType")]
        public string? InstrumentType { get; set; }
    }
}
