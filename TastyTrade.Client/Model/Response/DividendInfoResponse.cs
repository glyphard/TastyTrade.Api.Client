using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response
{
    public class DividendInfoResponse
    {
        [JsonPropertyName("data")]
        public DividendInfoResponseData Data { get; set; }
    }

    public class DividendInfoResponseData
    {
        [JsonPropertyName("items")]
        public List<DividendInfoItem> Items { get; set; }
    }

    public class DividendInfoItem
    {
        [JsonPropertyName("occurred-date")]
        public DateTime? OccurredDate { get; set; }

        [JsonPropertyName("amount")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Amount { get; set; }
    }

    public class DividendInfoArrayJsonConverter : JsonConverter<DividendInfoResponse>
    {
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

        public override void Write(Utf8JsonWriter writer, DividendInfoResponse value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Data?.Items ?? new List<DividendInfoItem>(), options);
        }
    }
}
