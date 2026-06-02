using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Helper
{
    /// <summary>
    /// Represents the decimal or string nullable json converter.
    /// </summary>
    public sealed class DecimalOrStringNullableJsonConverter : JsonConverter<decimal?>
    {
        /// <summary>
        /// Executes the read operation.
        /// </summary>
        public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                if (reader.TryGetDecimal(out var d))
                    return d;
                // fallback
                return Convert.ToDecimal(reader.GetDouble());
            }

            if (reader.TokenType == JsonTokenType.String)
            {
                var s = reader.GetString();
                if (string.IsNullOrWhiteSpace(s))
                    return null;

                if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var d))
                    return d;

                // last resort: try double parse then convert
                if (double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var dbl))
                    return Convert.ToDecimal(dbl);

                return null;
            }

            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            throw new JsonException($"Unexpected token parsing nullable decimal. Token: {reader.TokenType}");
        }

        /// <summary>
        /// Executes the write operation.
        /// </summary>
        public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
            else
                writer.WriteNullValue();
        }
    }
}