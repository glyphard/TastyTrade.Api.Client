using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response
{
    public class EarningsInfoResponse
    {
        [JsonPropertyName("data")]
        public EarningsInfoResponseData Data { get; set; }
    }

    public class EarningsInfoResponseData
    {
        [JsonPropertyName("items")]
        public List<EarningsInfoItem> Items { get; set; }
    }

    public class EarningsInfoItem
    {
        [JsonPropertyName("occurred-date")]
        public DateTime? OccurredDate { get; set; }

        [JsonPropertyName("eps")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Eps { get; set; }
    }

    public class EarningsInfoArrayJsonConverter : JsonConverter<EarningsInfoResponse>
    {
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

        public override void Write(Utf8JsonWriter writer, EarningsInfoResponse value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Data?.Items ?? new List<EarningsInfoItem>(), options);
        }
    }
}
