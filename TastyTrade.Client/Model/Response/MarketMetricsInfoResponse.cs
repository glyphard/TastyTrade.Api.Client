using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response
{
    /// <summary>
    /// Represents the market metrics info response.
    /// </summary>
    public class MarketMetricsInfoResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public MarketMetricsInfoResponseData Data { get; set; }
    }

    /// <summary>
    /// Represents the market metrics info response data.
    /// </summary>
    public class MarketMetricsInfoResponseData
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [JsonPropertyName("items")]
        public List<MarketMetricsInfoItem> Items { get; set; }
    }

    /// <summary>
    /// Represents the market metrics array json converter.
    /// </summary>
    public class MarketMetricsArrayJsonConverter : JsonConverter<MarketMetricsInfoResponse>
    {
        /// <summary>
        /// Executes the read operation.
        /// </summary>
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

        /// <summary>
        /// Executes the write operation.
        /// </summary>
        public override void Write(Utf8JsonWriter writer, MarketMetricsInfoResponse value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Data?.Items ?? new List<MarketMetricsInfoItem>(), options);
        }
    }

    /// <summary>
    /// Represents the market metrics info item.
    /// </summary>
    public class MarketMetricsInfoItem
    {
        /// <summary>
        /// Gets or sets the implied volatility percentile.
        /// </summary>
        [JsonPropertyName("implied-volatility-percentile")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ImpliedVolatilityPercentile { get; set; }

        /// <summary>
        /// Gets or sets the liquidity rank.
        /// </summary>
        [JsonPropertyName("liquidity-rank")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? LiquidityRank { get; set; }

        /// <summary>
        /// Gets or sets the option expiration implied volatilities.
        /// </summary>
        [JsonPropertyName("option-expiration-implied-volatilities")]
        public List<OptionExpirationImpliedVolatility> OptionExpirationImpliedVolatilities { get; set; }

        /// <summary>
        /// Gets or sets the implied volatility rank.
        /// </summary>
        [JsonPropertyName("implied-volatility-rank")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ImpliedVolatilityRank { get; set; }

        /// <summary>
        /// Gets or sets the implied volatility index.
        /// </summary>
        [JsonPropertyName("implied-volatility-index")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ImpliedVolatilityIndex { get; set; }

        /// <summary>
        /// Gets or sets the liquidity.
        /// </summary>
        [JsonPropertyName("liquidity")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Liquidity { get; set; }

        /// <summary>
        /// Gets or sets the implied volatility index5 day change.
        /// </summary>
        [JsonPropertyName("implied-volatility-index-5-day-change")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ImpliedVolatilityIndex5DayChange { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the liquidity rating.
        /// </summary>
        [JsonPropertyName("liquidity-rating")]
        [JsonConverter(typeof(DecimalOrStringJsonConverter))]
        public decimal LiquidityRating { get; set; }
    }

    /// <summary>
    /// Represents the option expiration implied volatility.
    /// </summary>
    public class OptionExpirationImpliedVolatility
    {
        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        [JsonPropertyName("expiration-date")]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the settlement type.
        /// </summary>
        [JsonPropertyName("settlement-type")]
        public string SettlementType { get; set; }

        /// <summary>
        /// Gets or sets the option chain type.
        /// </summary>
        [JsonPropertyName("option-chain-type")]
        public string OptionChainType { get; set; }

        /// <summary>
        /// Gets or sets the implied volatility.
        /// </summary>
        [JsonPropertyName("implied-volatility")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ImpliedVolatility { get; set; }
    }
}
