using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

public class TransactionsResponse
{
    [JsonPropertyName("data")]
    public TransactionsResponseData Data { get; set; }

    [JsonPropertyName("context")]
    public string Context { get; set; }
}

public class TransactionsResponseData
{
    [JsonPropertyName("items")]
    public List<TransactionsResponseDataItem> Items { get; set; }
}

public class TransactionsResponseDataItem
{
    [JsonPropertyName("other-charge-description")]
    public string OtherChargeDescription { get; set; }

    [JsonPropertyName("instrument-type")]
    public string InstrumentType { get; set; }

    [JsonPropertyName("net-value")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? NetValue { get; set; }

    [JsonPropertyName("agency-price")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? AgencyPrice { get; set; }

    [JsonPropertyName("proprietary-index-option-fees-effect")]
    public string ProprietaryIndexOptionFeesEffect { get; set; }

    [JsonPropertyName("lots")]
    public TransactionsResponseDataItemLot Lots { get; set; }

    [JsonPropertyName("regulatory-fees")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? RegulatoryFees { get; set; }

    [JsonPropertyName("exchange")]
    public string Exchange { get; set; }

    [JsonPropertyName("clearing-fees")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? ClearingFees { get; set; }

    [JsonPropertyName("ext-global-order-number")]
    [JsonConverter(typeof(NullableLongConverter))]
    public long? ExtGlobalOrderNumber { get; set; }

    [JsonPropertyName("ext-exchange-order-number")]
    public string ExtExchangeOrderNumber { get; set; }

    [JsonPropertyName("underlying-symbol")]
    public string UnderlyingSymbol { get; set; }

    [JsonPropertyName("currency-conversion-fees")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? CurrencyConversionFees { get; set; }

    [JsonPropertyName("transaction-type")]
    public string TransactionType { get; set; }

    [JsonPropertyName("price")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Price { get; set; }

    [JsonPropertyName("cost-basis-reconciliation-date")]
    public DateTime? CostBasisReconciliationDate { get; set; }

    [JsonPropertyName("account-number")]
    public string AccountNumber { get; set; }

    [JsonPropertyName("principal-price")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? PrincipalPrice { get; set; }

    [JsonPropertyName("ext-exec-id")]
    public string ExtExecId { get; set; }

    [JsonPropertyName("quantity")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Quantity { get; set; }

    [JsonPropertyName("commission")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Commission { get; set; }

    [JsonPropertyName("ext-group-fill-id")]
    public string ExtGroupFillId { get; set; }

    [JsonPropertyName("value-effect")]
    public string ValueEffect { get; set; }

    [JsonPropertyName("other-charge-effect")]
    public string OtherChargeEffect { get; set; }

    [JsonPropertyName("leg-count")]
    [JsonConverter(typeof(NullableIntConverter))]
    public int? LegCount { get; set; }

    [JsonPropertyName("exchange-affiliation-identifier")]
    public string ExchangeAffiliationIdentifier { get; set; }

    [JsonPropertyName("destination-venue")]
    public string DestinationVenue { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("other-charge")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? OtherCharge { get; set; }

    [JsonPropertyName("value")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Value { get; set; }

    [JsonPropertyName("executed-at")]
    public DateTime? ExecutedAt { get; set; }

    [JsonPropertyName("is-estimated-fee")]
    [JsonConverter(typeof(NullableBoolConverter))]
    public bool? IsEstimatedFee { get; set; }

    [JsonPropertyName("commission-effect")]
    public string CommissionEffect { get; set; }

    [JsonPropertyName("ext-group-id")]
    public string ExtGroupId { get; set; }

    [JsonPropertyName("currency-conversion-fees-effect")]
    public string CurrencyConversionFeesEffect { get; set; }

    [JsonPropertyName("transaction-sub-type")]
    public string TransactionSubType { get; set; }

    [JsonPropertyName("action")]
    public string Action { get; set; }

    [JsonPropertyName("reverses-id")]
    [JsonConverter(typeof(NullableLongConverter))]
    public long? ReversesId { get; set; }

    [JsonPropertyName("exec-id")]
    public string ExecId { get; set; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("clearing-fees-effect")]
    public string ClearingFeesEffect { get; set; }

    [JsonPropertyName("order-id")]
    [JsonConverter(typeof(NullableLongConverter))]
    public long? OrderId { get; set; }

    [JsonPropertyName("id")]
    [JsonConverter(typeof(NullableLongConverter))]
    public long? Id { get; set; }

    [JsonPropertyName("regulatory-fees-effect")]
    public string RegulatoryFeesEffect { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("proprietary-index-option-fees")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? ProprietaryIndexOptionFees { get; set; }

    [JsonPropertyName("transaction-date")]
    public DateTime? TransactionDate { get; set; }

    [JsonPropertyName("net-value-effect")]
    public string NetValueEffect { get; set; }
}

public class TransactionsResponseDataItemLot
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("executed-at")]
    public DateTime? ExecutedAt { get; set; }

    [JsonPropertyName("price")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Price { get; set; }

    [JsonPropertyName("quantity")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Quantity { get; set; }

    [JsonPropertyName("quantity-direction")]
    public string QuantityDirection { get; set; }

    [JsonPropertyName("transaction-date")]
    public DateTime? TransactionDate { get; set; }

    [JsonPropertyName("transaction-id")]
    [JsonConverter(typeof(NullableLongConverter))]
    public long? TransactionId { get; set; }
}

/// <summary>
/// Converters below accept either a JSON number or a JSON string containing a number.
/// They are deliberately resilient (nullable) and parse using InvariantCulture.
/// </summary>
internal class NullableDecimalConverter : JsonConverter<decimal?>
{
    public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return null;

        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetDecimal();
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            var s = reader.GetString();
            if (string.IsNullOrWhiteSpace(s)) return null;
            if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var d)) return d;
            // try trimming common quotes / commas
            var cleaned = s.Replace(",", "").Trim();
            if (decimal.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out d)) return d;
        }

        throw new JsonException($"Unable to convert token of type {reader.TokenType} to decimal?");
    }

    public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options)
    {
        if (value.HasValue) writer.WriteNumberValue(value.Value);
        else writer.WriteNullValue();
    }
}

internal class NullableLongConverter : JsonConverter<long?>
{
    public override long? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return null;

        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetInt64();
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            var s = reader.GetString();
            if (string.IsNullOrWhiteSpace(s)) return null;
            if (long.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var l)) return l;
            var cleaned = s.Replace(",", "").Trim();
            if (long.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out l)) return l;
        }

        throw new JsonException($"Unable to convert token of type {reader.TokenType} to long?");
    }

    public override void Write(Utf8JsonWriter writer, long? value, JsonSerializerOptions options)
    {
        if (value.HasValue) writer.WriteNumberValue(value.Value);
        else writer.WriteNullValue();
    }
}

internal class NullableIntConverter : JsonConverter<int?>
{
    public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return null;

        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetInt32();
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            var s = reader.GetString();
            if (string.IsNullOrWhiteSpace(s)) return null;
            if (int.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var i)) return i;
            var cleaned = s.Replace(",", "").Trim();
            if (int.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out i)) return i;
        }

        throw new JsonException($"Unable to convert token of type {reader.TokenType} to int?");
    }

    public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
    {
        if (value.HasValue) writer.WriteNumberValue(value.Value);
        else writer.WriteNullValue();
    }
}

internal class NullableBoolConverter : JsonConverter<bool?>
{
    public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return null;

        if (reader.TokenType == JsonTokenType.True) return true;
        if (reader.TokenType == JsonTokenType.False) return false;

        if (reader.TokenType == JsonTokenType.String)
        {
            var s = reader.GetString();
            if (string.IsNullOrWhiteSpace(s)) return null;
            if (bool.TryParse(s, out var b)) return b;
            var t = s.Trim();
            if (t == "1" || string.Equals(t, "yes", StringComparison.OrdinalIgnoreCase)) return true;
            if (t == "0" || string.Equals(t, "no", StringComparison.OrdinalIgnoreCase)) return false;
        }

        throw new JsonException($"Unable to convert token of type {reader.TokenType} to bool?");
    }

    public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
    {
        if (value.HasValue) writer.WriteBooleanValue(value.Value);
        else writer.WriteNullValue();
    }
}


