using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response
{
    public class PositionsResponse
    {
        [JsonPropertyName("data")]
        public PositionsResponseData Data { get; set; }

        [JsonPropertyName("context")]
        public string Context { get; set; }
    }

    public class PositionsResponseData
    {
        [JsonPropertyName("items")]
        public List<PositionItem> Items { get; set; }
    }

    public class PositionItem
    {
        [JsonPropertyName("account-number")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("instrument-type")]
        public string InstrumentType { get; set; }

        [JsonPropertyName("underlying-symbol")]
        public string UnderlyingSymbol { get; set; }

        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        [JsonPropertyName("quantity-direction")]
        public string QuantityDirection { get; set; }

        [JsonPropertyName("close-price")]
        public string ClosePrice { get; set; }

        [JsonPropertyName("average-open-price")]
        public string AverageOpenPrice { get; set; }

        [JsonPropertyName("average-yearly-market-close-price")]
        public string AverageYearlyMarketClosePrice { get; set; }

        [JsonPropertyName("average-daily-market-close-price")]
        public string AverageDailyMarketClosePrice { get; set; }

        [JsonPropertyName("multiplier")]
        [JsonConverter(typeof(DecimalOrStringJsonConverter))]
        public decimal Multiplier { get; set; }

        [JsonPropertyName("cost-effect")]
        public string CostEffect { get; set; }

        [JsonPropertyName("is-suppressed")]
        public bool IsSuppressed { get; set; }

        [JsonPropertyName("is-frozen")]
        public bool IsFrozen { get; set; }

        [JsonPropertyName("restricted-quantity")]
        public decimal  RestrictedQuantity { get; set; }

        [JsonPropertyName("realized-day-gain")]
        public string RealizedDayGain { get; set; }

        [JsonPropertyName("realized-day-gain-effect")]
        public string RealizedDayGainEffect { get; set; }

        [JsonPropertyName("realized-day-gain-date")]
        public DateTime? RealizedDayGainDate { get; set; }

        [JsonPropertyName("realized-today")]
        public string RealizedToday { get; set; }

        [JsonPropertyName("realized-today-effect")]
        public string RealizedTodayEffect { get; set; }

        [JsonPropertyName("realized-today-date")]
        public DateTime? RealizedTodayDate { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("updated-at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
