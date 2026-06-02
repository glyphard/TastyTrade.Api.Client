using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the transactions response.
/// </summary>
public class TransactionsResponse
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public TransactionsResponseData Data { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}

/// <summary>
/// Represents the transactions response data.
/// </summary>
public class TransactionsResponseData
{
    /// <summary>
    /// Gets or sets the items.
    /// </summary>
    [JsonPropertyName("items")]
    public List<TransactionsResponseDataItem> Items { get; set; }
}

/// <summary>
/// Represents the transactions response data item.
/// </summary>
public class TransactionsResponseDataItem
{
    /// <summary>
    /// Gets or sets the other charge description.
    /// </summary>
    [JsonPropertyName("other-charge-description")]
    public string OtherChargeDescription { get; set; }

    /// <summary>
    /// Gets or sets the instrument type.
    /// </summary>
    [JsonPropertyName("instrument-type")]
    public string InstrumentType { get; set; }

    /// <summary>
    /// Gets or sets the net value.
    /// </summary>
    [JsonPropertyName("net-value")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? NetValue { get; set; }

    /// <summary>
    /// Gets or sets the agency price.
    /// </summary>
    [JsonPropertyName("agency-price")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? AgencyPrice { get; set; }

    /// <summary>
    /// Gets or sets the proprietary index option fees effect.
    /// </summary>
    [JsonPropertyName("proprietary-index-option-fees-effect")]
    public string ProprietaryIndexOptionFeesEffect { get; set; }

    /// <summary>
    /// Gets or sets the lots.
    /// </summary>
    [JsonPropertyName("lots")]
    public TransactionsResponseDataItemLot Lots { get; set; }

    /// <summary>
    /// Gets or sets the regulatory fees.
    /// </summary>
    [JsonPropertyName("regulatory-fees")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? RegulatoryFees { get; set; }

    /// <summary>
    /// Gets or sets the exchange.
    /// </summary>
    [JsonPropertyName("exchange")]
    public string Exchange { get; set; }

    /// <summary>
    /// Gets or sets the clearing fees.
    /// </summary>
    [JsonPropertyName("clearing-fees")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? ClearingFees { get; set; }

    /// <summary>
    /// Gets or sets the ext global order number.
    /// </summary>
    [JsonPropertyName("ext-global-order-number")]
    [JsonConverter(typeof(NullableLongConverter))]
    public long? ExtGlobalOrderNumber { get; set; }

    /// <summary>
    /// Gets or sets the ext exchange order number.
    /// </summary>
    [JsonPropertyName("ext-exchange-order-number")]
    public string ExtExchangeOrderNumber { get; set; }

    /// <summary>
    /// Gets or sets the underlying symbol.
    /// </summary>
    [JsonPropertyName("underlying-symbol")]
    public string UnderlyingSymbol { get; set; }

    /// <summary>
    /// Gets or sets the currency conversion fees.
    /// </summary>
    [JsonPropertyName("currency-conversion-fees")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? CurrencyConversionFees { get; set; }

    /// <summary>
    /// Gets or sets the transaction type.
    /// </summary>
    [JsonPropertyName("transaction-type")]
    public string TransactionType { get; set; }

    /// <summary>
    /// Gets or sets the price.
    /// </summary>
    [JsonPropertyName("price")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Price { get; set; }

    /// <summary>
    /// Gets or sets the cost basis reconciliation date.
    /// </summary>
    [JsonPropertyName("cost-basis-reconciliation-date")]
    public DateTime? CostBasisReconciliationDate { get; set; }

    /// <summary>
    /// Gets or sets the account number.
    /// </summary>
    [JsonPropertyName("account-number")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the principal price.
    /// </summary>
    [JsonPropertyName("principal-price")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? PrincipalPrice { get; set; }

    /// <summary>
    /// Gets or sets the ext exec id.
    /// </summary>
    [JsonPropertyName("ext-exec-id")]
    public string ExtExecId { get; set; }

    /// <summary>
    /// Gets or sets the quantity.
    /// </summary>
    [JsonPropertyName("quantity")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Gets or sets the commission.
    /// </summary>
    [JsonPropertyName("commission")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Commission { get; set; }

    /// <summary>
    /// Gets or sets the ext group fill id.
    /// </summary>
    [JsonPropertyName("ext-group-fill-id")]
    public string ExtGroupFillId { get; set; }

    /// <summary>
    /// Gets or sets the value effect.
    /// </summary>
    [JsonPropertyName("value-effect")]
    public string ValueEffect { get; set; }

    /// <summary>
    /// Gets or sets the other charge effect.
    /// </summary>
    [JsonPropertyName("other-charge-effect")]
    public string OtherChargeEffect { get; set; }

    /// <summary>
    /// Gets or sets the leg count.
    /// </summary>
    [JsonPropertyName("leg-count")]
    [JsonConverter(typeof(NullableIntConverter))]
    public int? LegCount { get; set; }

    /// <summary>
    /// Gets or sets the exchange affiliation identifier.
    /// </summary>
    [JsonPropertyName("exchange-affiliation-identifier")]
    public string ExchangeAffiliationIdentifier { get; set; }

    /// <summary>
    /// Gets or sets the destination venue.
    /// </summary>
    [JsonPropertyName("destination-venue")]
    public string DestinationVenue { get; set; }

    /// <summary>
    /// Gets or sets the currency.
    /// </summary>
    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or sets the other charge.
    /// </summary>
    [JsonPropertyName("other-charge")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? OtherCharge { get; set; }

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    [JsonPropertyName("value")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Value { get; set; }

    /// <summary>
    /// Gets or sets the executed at.
    /// </summary>
    [JsonPropertyName("executed-at")]
    public DateTime? ExecutedAt { get; set; }

    /// <summary>
    /// Gets or sets the is estimated fee.
    /// </summary>
    [JsonPropertyName("is-estimated-fee")]
    [JsonConverter(typeof(NullableBoolConverter))]
    public bool? IsEstimatedFee { get; set; }

    /// <summary>
    /// Gets or sets the commission effect.
    /// </summary>
    [JsonPropertyName("commission-effect")]
    public string CommissionEffect { get; set; }

    /// <summary>
    /// Gets or sets the ext group id.
    /// </summary>
    [JsonPropertyName("ext-group-id")]
    public string ExtGroupId { get; set; }

    /// <summary>
    /// Gets or sets the currency conversion fees effect.
    /// </summary>
    [JsonPropertyName("currency-conversion-fees-effect")]
    public string CurrencyConversionFeesEffect { get; set; }

    /// <summary>
    /// Gets or sets the transaction sub type.
    /// </summary>
    [JsonPropertyName("transaction-sub-type")]
    public string TransactionSubType { get; set; }

    /// <summary>
    /// Gets or sets the action.
    /// </summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary>
    /// Gets or sets the reverses id.
    /// </summary>
    [JsonPropertyName("reverses-id")]
    [JsonConverter(typeof(NullableLongConverter))]
    public long? ReversesId { get; set; }

    /// <summary>
    /// Gets or sets the exec id.
    /// </summary>
    [JsonPropertyName("exec-id")]
    public string ExecId { get; set; }

    /// <summary>
    /// Gets or sets the symbol.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    /// <summary>
    /// Gets or sets the clearing fees effect.
    /// </summary>
    [JsonPropertyName("clearing-fees-effect")]
    public string ClearingFeesEffect { get; set; }

    /// <summary>
    /// Gets or sets the order id.
    /// </summary>
    [JsonPropertyName("order-id")]
    [JsonConverter(typeof(NullableLongConverter))]
    public long? OrderId { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    [JsonConverter(typeof(NullableLongConverter))]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or sets the regulatory fees effect.
    /// </summary>
    [JsonPropertyName("regulatory-fees-effect")]
    public string RegulatoryFeesEffect { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the proprietary index option fees.
    /// </summary>
    [JsonPropertyName("proprietary-index-option-fees")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? ProprietaryIndexOptionFees { get; set; }

    /// <summary>
    /// Gets or sets the transaction date.
    /// </summary>
    [JsonPropertyName("transaction-date")]
    public DateTime? TransactionDate { get; set; }

    /// <summary>
    /// Gets or sets the net value effect.
    /// </summary>
    [JsonPropertyName("net-value-effect")]
    public string NetValueEffect { get; set; }
}

/// <summary>
/// Represents the transactions response data item lot.
/// </summary>
public class TransactionsResponseDataItemLot
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the executed at.
    /// </summary>
    [JsonPropertyName("executed-at")]
    public DateTime? ExecutedAt { get; set; }

    /// <summary>
    /// Gets or sets the price.
    /// </summary>
    [JsonPropertyName("price")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Price { get; set; }

    /// <summary>
    /// Gets or sets the quantity.
    /// </summary>
    [JsonPropertyName("quantity")]
    [JsonConverter(typeof(NullableDecimalConverter))]
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Gets or sets the quantity direction.
    /// </summary>
    [JsonPropertyName("quantity-direction")]
    public string QuantityDirection { get; set; }

    /// <summary>
    /// Gets or sets the transaction date.
    /// </summary>
    [JsonPropertyName("transaction-date")]
    public DateTime? TransactionDate { get; set; }

    /// <summary>
    /// Gets or sets the transaction id.
    /// </summary>
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
    /// <summary>
    /// Executes the read operation.
    /// </summary>
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

    /// <summary>
    /// Executes the write operation.
    /// </summary>
    public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options)
    {
        if (value.HasValue) writer.WriteNumberValue(value.Value);
        else writer.WriteNullValue();
    }
}

internal class NullableLongConverter : JsonConverter<long?>
{
    /// <summary>
    /// Executes the read operation.
    /// </summary>
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

    /// <summary>
    /// Executes the write operation.
    /// </summary>
    public override void Write(Utf8JsonWriter writer, long? value, JsonSerializerOptions options)
    {
        if (value.HasValue) writer.WriteNumberValue(value.Value);
        else writer.WriteNullValue();
    }
}

internal class NullableIntConverter : JsonConverter<int?>
{
    /// <summary>
    /// Executes the read operation.
    /// </summary>
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

    /// <summary>
    /// Executes the write operation.
    /// </summary>
    public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
    {
        if (value.HasValue) writer.WriteNumberValue(value.Value);
        else writer.WriteNullValue();
    }
}

internal class NullableBoolConverter : JsonConverter<bool?>
{
    /// <summary>
    /// Executes the read operation.
    /// </summary>
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

    /// <summary>
    /// Executes the write operation.
    /// </summary>
    public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
    {
        if (value.HasValue) writer.WriteBooleanValue(value.Value);
        else writer.WriteNullValue();
    }
}


