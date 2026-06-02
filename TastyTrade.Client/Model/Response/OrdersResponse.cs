using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response
{
    /// <summary>
    /// Represents the orders response.
    /// </summary>
    public class OrdersResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public OrdersResponseData Data { get; set; }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// Gets or sets the pagination.
        /// </summary>
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }

    /// <summary>
    /// Represents the orders response data.
    /// </summary>
    public class OrdersResponseData
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [JsonPropertyName("items")]
        public List<OrderItem> Items { get; set; }
    }

    /// <summary>
    /// Represents the order item.
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        [JsonPropertyName("account-number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the cancel user id.
        /// </summary>
        [JsonPropertyName("cancel-user-id")]
        public string CancelUserId { get; set; }

        /// <summary>
        /// Gets or sets the cancel username.
        /// </summary>
        [JsonPropertyName("cancel-username")]
        public string CancelUsername { get; set; }

        /// <summary>
        /// Gets or sets the cancellable.
        /// </summary>
        [JsonPropertyName("cancellable")]
        public bool Cancellable { get; set; }

        /// <summary>
        /// Gets or sets the cancelled at.
        /// </summary>
        [JsonPropertyName("cancelled-at")]
        public string CancelledAt { get; set; }

        /// <summary>
        /// Gets or sets the complex order id.
        /// </summary>
        [JsonPropertyName("complex-order-id")]
        public string ComplexOrderId { get; set; }

        /// <summary>
        /// Gets or sets the complex order tag.
        /// </summary>
        [JsonPropertyName("complex-order-tag")]
        public string ComplexOrderTag { get; set; }

        /// <summary>
        /// Gets or sets the confirmation status.
        /// </summary>
        [JsonPropertyName("confirmation-status")]
        public string ConfirmationStatus { get; set; }

        /// <summary>
        /// Gets or sets the contingent status.
        /// </summary>
        [JsonPropertyName("contingent-status")]
        public string ContingentStatus { get; set; }

        /// <summary>
        /// Gets or sets the editable.
        /// </summary>
        [JsonPropertyName("editable")]
        public bool Editable { get; set; }

        /// <summary>
        /// Gets or sets the edited.
        /// </summary>
        [JsonPropertyName("edited")]
        public bool Edited { get; set; }

        /// <summary>
        /// Gets or sets the external identifier.
        /// </summary>
        [JsonPropertyName("external-identifier")]
        public string ExternalIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the global request id.
        /// </summary>
        [JsonPropertyName("global-request-id")]
        public string GlobalRequestId { get; set; }

        /// <summary>
        /// Gets or sets the gtc date.
        /// </summary>
        [JsonPropertyName("gtc-date")]
        public string GtcDate { get; set; }

        /// <summary>
        /// Gets or sets the in flight at.
        /// </summary>
        [JsonPropertyName("in-flight-at")]
        public string InFlightAt { get; set; }

        /// <summary>
        /// Gets or sets the live at.
        /// </summary>
        [JsonPropertyName("live-at")]
        public string LiveAt { get; set; }

        /// <summary>
        /// Gets or sets the order type.
        /// </summary>
        [JsonPropertyName("order-type")]
        public string OrderType { get; set; }

        /// <summary>
        /// Gets or sets the preflight id.
        /// </summary>
        [JsonPropertyName("preflight-id")]
        public string PreflightId { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Gets or sets the price effect.
        /// </summary>
        [JsonPropertyName("price-effect")]
        public string PriceEffect { get; set; }

        /// <summary>
        /// Gets or sets the received at.
        /// </summary>
        [JsonPropertyName("received-at")]
        public string ReceivedAt { get; set; }

        /// <summary>
        /// Gets or sets the reject reason.
        /// </summary>
        [JsonPropertyName("reject-reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// Gets or sets the replaces order id.
        /// </summary>
        [JsonPropertyName("replaces-order-id")]
        public string ReplacesOrderId { get; set; }

        /// <summary>
        /// Gets or sets the replacing order id.
        /// </summary>
        [JsonPropertyName("replacing-order-id")]
        public string ReplacingOrderId { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        [JsonPropertyName("size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the stop trigger.
        /// </summary>
        [JsonPropertyName("stop-trigger")]
        public string StopTrigger { get; set; }

        /// <summary>
        /// Gets or sets the terminal at.
        /// </summary>
        [JsonPropertyName("terminal-at")]
        public string TerminalAt { get; set; }

        /// <summary>
        /// Gets or sets the time in force.
        /// </summary>
        [JsonPropertyName("time-in-force")]
        public string TimeInForce { get; set; }

        /// <summary>
        /// Gets or sets the underlying instrument type.
        /// </summary>
        [JsonPropertyName("underlying-instrument-type")]
        public string UnderlyingInstrumentType { get; set; }

        /// <summary>
        /// Gets or sets the underlying symbol.
        /// </summary>
        [JsonPropertyName("underlying-symbol")]
        public string UnderlyingSymbol { get; set; }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        [JsonPropertyName("updated-at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        [JsonPropertyName("user-id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonPropertyName("value")]
        public decimal? Value { get; set; }

        /// <summary>
        /// Gets or sets the value effect.
        /// </summary>
        [JsonPropertyName("value-effect")]
        public string ValueEffect { get; set; }

        /// <summary>
        /// Gets or sets the legs.
        /// </summary>
        [JsonPropertyName("legs")]
        public List<OrderLeg> Legs { get; set; }

        /// <summary>
        /// Gets or sets the order rule.
        /// </summary>
        [JsonPropertyName("order-rule")]
        public OrderRule OrderRule { get; set; }
    }

    /// <summary>
    /// Represents the order leg.
    /// </summary>
    public class OrderLeg
    {
        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the instrument type.
        /// </summary>
        [JsonPropertyName("instrument-type")]
        public string InstrumentType { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or sets the remaining quantity.
        /// </summary>
        [JsonPropertyName("remaining-quantity")]
        public string RemainingQuantity { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the fills.
        /// </summary>
        [JsonPropertyName("fills")]
        public List<OrderFill> Fills { get; set; }
    }

    /// <summary>
    /// Represents the order fill.
    /// </summary>
    public class OrderFill
    {
        /// <summary>
        /// Gets or sets the destination venue.
        /// </summary>
        [JsonPropertyName("destination-venue")]
        public string DestinationVenue { get; set; }

        /// <summary>
        /// Gets or sets the ext exec id.
        /// </summary>
        [JsonPropertyName("ext-exec-id")]
        public string ExtExecId { get; set; }

        /// <summary>
        /// Gets or sets the ext group fill id.
        /// </summary>
        [JsonPropertyName("ext-group-fill-id")]
        public string ExtGroupFillId { get; set; }

        /// <summary>
        /// Gets or sets the fill id.
        /// </summary>
        [JsonPropertyName("fill-id")]
        public string FillId { get; set; }

        /// <summary>
        /// Gets or sets the fill price.
        /// </summary>
        [JsonPropertyName("fill-price")]
        public decimal FillPrice { get; set; }

        /// <summary>
        /// Gets or sets the filled at.
        /// </summary>
        [JsonPropertyName("filled-at")]
        public string FilledAt { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }
    }

    /// <summary>
    /// Represents the order rule.
    /// </summary>
    public class OrderRule
    {
        /// <summary>
        /// Gets or sets the cancel at.
        /// </summary>
        [JsonPropertyName("cancel-at")]
        public string CancelAt { get; set; }

        /// <summary>
        /// Gets or sets the cancelled at.
        /// </summary>
        [JsonPropertyName("cancelled-at")]
        public string CancelledAt { get; set; }

        /// <summary>
        /// Gets or sets the route after.
        /// </summary>
        [JsonPropertyName("route-after")]
        public string RouteAfter { get; set; }

        /// <summary>
        /// Gets or sets the routed at.
        /// </summary>
        [JsonPropertyName("routed-at")]
        public string RoutedAt { get; set; }

        /// <summary>
        /// Gets or sets the order conditions.
        /// </summary>
        [JsonPropertyName("order-conditions")]
        public List<OrderCondition> OrderConditions { get; set; }
    }

    /// <summary>
    /// Represents the order condition.
    /// </summary>
    public class OrderCondition
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the comparator.
        /// </summary>
        [JsonPropertyName("comparator")]
        public string Comparator { get; set; }

        /// <summary>
        /// Gets or sets the indicator.
        /// </summary>
        [JsonPropertyName("indicator")]
        public string Indicator { get; set; }

        /// <summary>
        /// Gets or sets the instrument type.
        /// </summary>
        [JsonPropertyName("instrument-type")]
        public string InstrumentType { get; set; }

        /// <summary>
        /// Gets or sets the is threshold based on notional.
        /// </summary>
        [JsonPropertyName("is-threshold-based-on-notional")]
        public bool IsThresholdBasedOnNotional { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the threshold.
        /// </summary>
        [JsonPropertyName("threshold")]
        public decimal Threshold { get; set; }

        /// <summary>
        /// Gets or sets the triggered at.
        /// </summary>
        [JsonPropertyName("triggered-at")]
        public string TriggeredAt { get; set; }

        /// <summary>
        /// Gets or sets the triggered value.
        /// </summary>
        [JsonPropertyName("triggered-value")]
        public decimal? TriggeredValue { get; set; }

        /// <summary>
        /// Gets or sets the price components.
        /// </summary>
        [JsonPropertyName("price-components")]
        public List<PriceComponent> PriceComponents { get; set; }
    }

    /// <summary>
    /// Represents the price component.
    /// </summary>
    public class PriceComponent
    {
        /// <summary>
        /// Gets or sets the instrument type.
        /// </summary>
        [JsonPropertyName("instrument-type")]
        public string InstrumentType { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or sets the quantity direction.
        /// </summary>
        [JsonPropertyName("quantity-direction")]
        public string QuantityDirection { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
    }
}
