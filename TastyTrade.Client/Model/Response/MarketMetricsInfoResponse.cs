using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response
{
    // Top-level wrapper (keeps consistent shape with other Response classes in the project).
    // Some endpoints return a plain array; if the endpoint returns a raw array you can deserialize
    // to List<MarketMetricsInfoItem> directly. This wrapper mirrors other response patterns.
    public class MarketMetricsInfoResponse
    {
        [JsonPropertyName("data")]
        public MarketMetricsInfoResponseData Data { get; set; }
    }

    public class MarketMetricsInfoResponseData
    {
        [JsonPropertyName("items")]
        public List<MarketMetricsInfoItem> Items { get; set; }
    }

    public class MarketMetricsInfoItem
    {
        [JsonPropertyName("implied-volatility-percentile")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ImpliedVolatilityPercentile { get; set; }

        [JsonPropertyName("liquidity-rank")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? LiquidityRank { get; set; }

        [JsonPropertyName("option-expiration-implied-volatilities")]
        public List<OptionExpirationImpliedVolatility> OptionExpirationImpliedVolatilities { get; set; }

        [JsonPropertyName("implied-volatility-rank")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ImpliedVolatilityRank { get; set; }

        [JsonPropertyName("implied-volatility-index")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ImpliedVolatilityIndex { get; set; }

        [JsonPropertyName("liquidity")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Liquidity { get; set; }

        [JsonPropertyName("implied-volatility-index-5-day-change")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ImpliedVolatilityIndex5DayChange { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("liquidity-rating")]
        [JsonConverter(typeof(DecimalOrStringJsonConverter))]
        public decimal LiquidityRating { get; set; }
    }

    public class OptionExpirationImpliedVolatility
    {
        [JsonPropertyName("expiration-date")]
        public DateTime? ExpirationDate { get; set; }

        [JsonPropertyName("settlement-type")]
        public string SettlementType { get; set; }

        [JsonPropertyName("option-chain-type")]
        public string OptionChainType { get; set; }

        [JsonPropertyName("implied-volatility")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ImpliedVolatility { get; set; }
    }
}
