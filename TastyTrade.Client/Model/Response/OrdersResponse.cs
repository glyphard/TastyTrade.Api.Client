using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response
{
    public class OrdersResponse
    {
        [JsonPropertyName("data")]
        public OrdersResponseData Data { get; set; }

        [JsonPropertyName("context")]
        public string Context { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class OrdersResponseData
    {
        [JsonPropertyName("items")]
        public List<OrderItem> Items { get; set; }
    }

    public class OrderItem
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("account-number")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("cancel-user-id")]
        public string CancelUserId { get; set; }

        [JsonPropertyName("cancel-username")]
        public string CancelUsername { get; set; }

        [JsonPropertyName("cancellable")]
        public bool Cancellable { get; set; }

        [JsonPropertyName("cancelled-at")]
        public string CancelledAt { get; set; }

        [JsonPropertyName("complex-order-id")]
        public string ComplexOrderId { get; set; }

        [JsonPropertyName("complex-order-tag")]
        public string ComplexOrderTag { get; set; }

        [JsonPropertyName("confirmation-status")]
        public string ConfirmationStatus { get; set; }

        [JsonPropertyName("contingent-status")]
        public string ContingentStatus { get; set; }

        [JsonPropertyName("editable")]
        public bool Editable { get; set; }

        [JsonPropertyName("edited")]
        public bool Edited { get; set; }

        [JsonPropertyName("external-identifier")]
        public string ExternalIdentifier { get; set; }

        [JsonPropertyName("global-request-id")]
        public string GlobalRequestId { get; set; }

        [JsonPropertyName("gtc-date")]
        public string GtcDate { get; set; }

        [JsonPropertyName("in-flight-at")]
        public string InFlightAt { get; set; }

        [JsonPropertyName("live-at")]
        public string LiveAt { get; set; }

        [JsonPropertyName("order-type")]
        public string OrderType { get; set; }

        [JsonPropertyName("preflight-id")]
        public string PreflightId { get; set; }

        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        [JsonPropertyName("price-effect")]
        public string PriceEffect { get; set; }

        [JsonPropertyName("received-at")]
        public string ReceivedAt { get; set; }

        [JsonPropertyName("reject-reason")]
        public string RejectReason { get; set; }

        [JsonPropertyName("replaces-order-id")]
        public string ReplacesOrderId { get; set; }

        [JsonPropertyName("replacing-order-id")]
        public string ReplacingOrderId { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("stop-trigger")]
        public string StopTrigger { get; set; }

        [JsonPropertyName("terminal-at")]
        public string TerminalAt { get; set; }

        [JsonPropertyName("time-in-force")]
        public string TimeInForce { get; set; }

        [JsonPropertyName("underlying-instrument-type")]
        public string UnderlyingInstrumentType { get; set; }

        [JsonPropertyName("underlying-symbol")]
        public string UnderlyingSymbol { get; set; }

        [JsonPropertyName("updated-at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("user-id")]
        public string UserId { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("value")]
        public decimal? Value { get; set; }

        [JsonPropertyName("value-effect")]
        public string ValueEffect { get; set; }

        [JsonPropertyName("legs")]
        public List<OrderLeg> Legs { get; set; }

        [JsonPropertyName("order-rule")]
        public OrderRule OrderRule { get; set; }
    }

    public class OrderLeg
    {
        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("instrument-type")]
        public string InstrumentType { get; set; }

        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        [JsonPropertyName("remaining-quantity")]
        public string RemainingQuantity { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("fills")]
        public List<OrderFill> Fills { get; set; }
    }

    public class OrderFill
    {
        [JsonPropertyName("destination-venue")]
        public string DestinationVenue { get; set; }

        [JsonPropertyName("ext-exec-id")]
        public string ExtExecId { get; set; }

        [JsonPropertyName("ext-group-fill-id")]
        public string ExtGroupFillId { get; set; }

        [JsonPropertyName("fill-id")]
        public string FillId { get; set; }

        [JsonPropertyName("fill-price")]
        public decimal FillPrice { get; set; }

        [JsonPropertyName("filled-at")]
        public string FilledAt { get; set; }

        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }
    }

    public class OrderRule
    {
        [JsonPropertyName("cancel-at")]
        public string CancelAt { get; set; }

        [JsonPropertyName("cancelled-at")]
        public string CancelledAt { get; set; }

        [JsonPropertyName("route-after")]
        public string RouteAfter { get; set; }

        [JsonPropertyName("routed-at")]
        public string RoutedAt { get; set; }

        [JsonPropertyName("order-conditions")]
        public List<OrderCondition> OrderConditions { get; set; }
    }

    public class OrderCondition
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("comparator")]
        public string Comparator { get; set; }

        [JsonPropertyName("indicator")]
        public string Indicator { get; set; }

        [JsonPropertyName("instrument-type")]
        public string InstrumentType { get; set; }

        [JsonPropertyName("is-threshold-based-on-notional")]
        public bool IsThresholdBasedOnNotional { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("threshold")]
        public decimal Threshold { get; set; }

        [JsonPropertyName("triggered-at")]
        public string TriggeredAt { get; set; }

        [JsonPropertyName("triggered-value")]
        public decimal? TriggeredValue { get; set; }

        [JsonPropertyName("price-components")]
        public List<PriceComponent> PriceComponents { get; set; }
    }

    public class PriceComponent
    {
        [JsonPropertyName("instrument-type")]
        public string InstrumentType { get; set; }

        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        [JsonPropertyName("quantity-direction")]
        public string QuantityDirection { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
    }
}
