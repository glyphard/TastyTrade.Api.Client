using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response
{
    /// <summary>
    /// Represents the earnings info response.
    /// </summary>
    public class EarningsInfoResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public EarningsInfoResponseData Data { get; set; }
    }

    /// <summary>
    /// Represents the earnings info response data.
    /// </summary>
    public class EarningsInfoResponseData
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [JsonPropertyName("items")]
        public List<EarningsInfoItem> Items { get; set; }
    }

    /// <summary>
    /// Represents the earnings info item.
    /// </summary>
    public class EarningsInfoItem
    {
        /// <summary>
        /// Gets or sets the occurred date.
        /// </summary>
        [JsonPropertyName("occurred-date")]
        public DateTime? OccurredDate { get; set; }

        /// <summary>
        /// Gets or sets the eps.
        /// </summary>
        [JsonPropertyName("eps")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Eps { get; set; }
    }

    /// <summary>
    /// Represents the earnings info array json converter.
    /// </summary>
    public class EarningsInfoArrayJsonConverter : JsonConverter<EarningsInfoResponse>
    {
        /// <summary>
        /// Executes the read operation.
        /// </summary>
        public override EarningsInfoResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                var items = JsonSerializer.Deserialize<List<EarningsInfoItem>>(ref reader, options);
                return new EarningsInfoResponse
                {
                    Data = new EarningsInfoResponseData { Items = items ?? new List<EarningsInfoItem>() }
                };
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                using var doc = JsonDocument.ParseValue(ref reader);
                if (doc.RootElement.TryGetProperty("data", out var dataElement))
                {
                    return new EarningsInfoResponse
                    {
                        Data = JsonSerializer.Deserialize<EarningsInfoResponseData>(dataElement.GetRawText(), options)
                    };
                }
            }
            return new EarningsInfoResponse { Data = new EarningsInfoResponseData { Items = new List<EarningsInfoItem>() } };
        }

        /// <summary>
        /// Executes the write operation.
        /// </summary>
        public override void Write(Utf8JsonWriter writer, EarningsInfoResponse value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Data?.Items ?? new List<EarningsInfoItem>(), options);
        }
    }
}
