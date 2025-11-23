using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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
        public string ImpliedVolatilityPercentile { get; set; }

        [JsonPropertyName("liquidity-rank")]
        public string LiquidityRank { get; set; }

        [JsonPropertyName("option-expiration-implied-volatilities")]
        public List<OptionExpirationImpliedVolatility> OptionExpirationImpliedVolatilities { get; set; }

        [JsonPropertyName("implied-volatility-rank")]
        public string ImpliedVolatilityRank { get; set; }

        [JsonPropertyName("implied-volatility-index")]
        public string ImpliedVolatilityIndex { get; set; }

        [JsonPropertyName("liquidity")]
        public string Liquidity { get; set; }

        [JsonPropertyName("implied-volatility-index-5-day-change")]
        public string ImpliedVolatilityIndex5DayChange { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("liquidity-rating")]
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
        public string ImpliedVolatility { get; set; }
    }
}
