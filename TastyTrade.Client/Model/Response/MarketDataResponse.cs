using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response
{
    public class MarketDataResponse
    {
        [JsonPropertyName("data")]
        public MarketData Data { get; set; }

    }
    public class MarketData {
        [JsonPropertyName("items")]
        public List<MarketDataItem> Items { get; set; }

    }
    public class MarketDataItem
        {

            [JsonPropertyName("lastMkt")]
            [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? LastMkt { get; set; }

        [JsonPropertyName("tradingHalted")]
        public bool TradingHalted { get; set; }

        [JsonPropertyName("instrumentType")]
        public string? InstrumentType { get; set; }

        [JsonPropertyName("lowLimitPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? LowLimitPrice { get; set; }

        [JsonPropertyName("tradingHaltedReason")]
        public string? TradingHaltedReason { get; set; }

        [JsonPropertyName("prevClose")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? PrevClose { get; set; }

        [JsonPropertyName("dividendAmount")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? DividendAmount { get; set; }

        // epoch/ms or service-defined numeric timestamp
        [JsonPropertyName("haltEndTime")]
        [JsonConverter(typeof(LongOrStringJsonConverter))]
        public long HaltEndTime { get; set; }

        [JsonPropertyName("instrument")]
        public Instrument? Instrument { get; set; }

        [JsonPropertyName("mid")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Mid { get; set; }

        [JsonPropertyName("yearHighPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? YearHighPrice { get; set; }

        [JsonPropertyName("open")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Open { get; set; }

        [JsonPropertyName("dayHighPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? DayHighPrice { get; set; }

        [JsonPropertyName("closePriceType")]
        public string? ClosePriceType { get; set; }

        [JsonPropertyName("lastExt")]
        [JsonConverter(typeof(LongOrStringJsonConverter))]
        public long LastExt { get; set; }

        [JsonPropertyName("dividendFrequency")]
        [JsonConverter(typeof(IntOrStringJsonConverter))]
        public int DividendFrequency { get; set; }

        [JsonPropertyName("mark")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Mark { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("haltStartTime")]
        [JsonConverter(typeof(LongOrStringJsonConverter))]
        public long HaltStartTime { get; set; }

        [JsonPropertyName("highLimitPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? HighLimitPrice { get; set; }

        [JsonPropertyName("beta")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Beta { get; set; }

        [JsonPropertyName("dayLowPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? DayLowPrice { get; set; }

        [JsonPropertyName("yearLowPrice")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? YearLowPrice { get; set; }

        // kept as string to match "YYYY-MM-DD" payload exactly
        [JsonPropertyName("prevCloseDate")]
        public string? PrevCloseDate { get; set; }

        [JsonPropertyName("summaryDate")]
        public string? SummaryDate { get; set; }

        [JsonPropertyName("last")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Last { get; set; }

        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        [JsonPropertyName("close")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Close { get; set; }

        [JsonPropertyName("ask")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Ask { get; set; }

        [JsonPropertyName("askSize")]
        [JsonConverter(typeof(IntOrStringJsonConverter))]
        public int AskSize { get; set; }

        [JsonPropertyName("volume")]
        [JsonConverter(typeof(LongOrStringJsonConverter))]
        public long Volume { get; set; }

        [JsonPropertyName("lastTradeTime")]
        [JsonConverter(typeof(LongOrStringJsonConverter))]
        public long LastTradeTime { get; set; }

        [JsonPropertyName("bid")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Bid { get; set; }

        [JsonPropertyName("prevClosePriceType")]
        public string? PrevClosePriceType { get; set; }

        [JsonPropertyName("bidSize")]
        [JsonConverter(typeof(IntOrStringJsonConverter))]
        public int BidSize { get; set; }
    }

    public class Instrument
    {
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        [JsonPropertyName("instrumentType")]
        public string? InstrumentType { get; set; }

        [JsonPropertyName("instrumentKey")]
        public InstrumentKey? InstrumentKey { get; set; }

        [JsonPropertyName("underlyingInstrument")]
        public string? UnderlyingInstrument { get; set; }

        [JsonPropertyName("rootSymbol")]
        public string? RootSymbol { get; set; }

        [JsonPropertyName("exchange")]
        public string? Exchange { get; set; }
    }

    public class InstrumentKey
    {
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        [JsonPropertyName("instrumentType")]
        public string? InstrumentType { get; set; }
    }
}
