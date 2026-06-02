using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response
{
    /// <summary>
    /// Represents the dividend info response.
    /// </summary>
    public class DividendInfoResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public DividendInfoResponseData Data { get; set; }
    }

    /// <summary>
    /// Represents the dividend info response data.
    /// </summary>
    public class DividendInfoResponseData
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [JsonPropertyName("items")]
        public List<DividendInfoItem> Items { get; set; }
    }

    /// <summary>
    /// Represents the dividend info item.
    /// </summary>
    public class DividendInfoItem
    {
        /// <summary>
        /// Gets or sets the occurred date.
        /// </summary>
        [JsonPropertyName("occurred-date")]
        public DateTime? OccurredDate { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        [JsonPropertyName("amount")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Amount { get; set; }
    }

    /// <summary>
    /// Represents the dividend info array json converter.
    /// </summary>
    public class DividendInfoArrayJsonConverter : JsonConverter<DividendInfoResponse>
    {
        /// <summary>
        /// Executes the read operation.
        /// </summary>
        public override DividendInfoResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                var items = JsonSerializer.Deserialize<List<DividendInfoItem>>(ref reader, options);
                return new DividendInfoResponse
                {
                    Data = new DividendInfoResponseData { Items = items ?? new List<DividendInfoItem>() }
                };
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                using var doc = JsonDocument.ParseValue(ref reader);
                if (doc.RootElement.TryGetProperty("data", out var dataElement))
                {
                    return new DividendInfoResponse
                    {
                        Data = JsonSerializer.Deserialize<DividendInfoResponseData>(dataElement.GetRawText(), options)
                    };
                }
            }
            return new DividendInfoResponse { Data = new DividendInfoResponseData { Items = new List<DividendInfoItem>() } };
        }

        /// <summary>
        /// Executes the write operation.
        /// </summary>
        public override void Write(Utf8JsonWriter writer, DividendInfoResponse value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Data?.Items ?? new List<DividendInfoItem>(), options);
        }
    }
}
