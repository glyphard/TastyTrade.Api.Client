using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Helper
{
    public sealed class LongOrStringJsonConverter : JsonConverter<long>
    {
        public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                if (reader.TryGetInt64(out var v))
                    return v;
                // fallback to double then convert
                return Convert.ToInt64(reader.GetDouble());
            }

            if (reader.TokenType == JsonTokenType.String)
            {
                var s = reader.GetString();
                if (string.IsNullOrWhiteSpace(s))
                    return 0L;

                if (long.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var v))
                    return v;

                if (double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var dbl))
                    return Convert.ToInt64(dbl);

                return 0L;
            }

            if (reader.TokenType == JsonTokenType.Null)
            {
                return 0L;
            }

            throw new JsonException($"Unexpected token parsing Int64. Token: {reader.TokenType}");
        }

        public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}
