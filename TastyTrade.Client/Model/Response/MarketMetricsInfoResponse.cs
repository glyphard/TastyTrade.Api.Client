using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response
{
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

    public class MarketMetricsArrayJsonConverter : JsonConverter<MarketMetricsInfoResponse>
    {
        public override MarketMetricsInfoResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                var items = JsonSerializer.Deserialize<List<MarketMetricsInfoItem>>(ref reader, options);
                return new MarketMetricsInfoResponse
                {
                    Data = new MarketMetricsInfoResponseData { Items = items ?? new List<MarketMetricsInfoItem>() }
                };
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                using var doc = JsonDocument.ParseValue(ref reader);
                if (doc.RootElement.TryGetProperty("data", out var dataElement))
                {
                    return new MarketMetricsInfoResponse
                    {
                        Data = JsonSerializer.Deserialize<MarketMetricsInfoResponseData>(dataElement.GetRawText(), options)
                    };
                }
            }
            return new MarketMetricsInfoResponse { Data = new MarketMetricsInfoResponseData { Items = new List<MarketMetricsInfoItem>() } };
        }

        public override void Write(Utf8JsonWriter writer, MarketMetricsInfoResponse value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Data?.Items ?? new List<MarketMetricsInfoItem>(), options);
        }
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
