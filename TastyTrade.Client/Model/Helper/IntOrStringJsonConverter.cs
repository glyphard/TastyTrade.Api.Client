using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Helper
{
    public sealed class IntOrStringJsonConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                if (reader.TryGetInt32(out var v))
                    return v;
                // fallback to double then convert
                return Convert.ToInt32(reader.GetDouble());
            }

            if (reader.TokenType == JsonTokenType.String)
            {
                var s = reader.GetString();
                if (string.IsNullOrWhiteSpace(s))
                    return 0;

                if (int.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var v))
                    return v;

                if (double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var dbl))
                    return Convert.ToInt32(dbl);

                return 0;
            }

            if (reader.TokenType == JsonTokenType.Null)
            {
                return 0;
            }

            throw new JsonException($"Unexpected token parsing Int32. Token: {reader.TokenType}");
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}
