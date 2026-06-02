using System.Collections.Generic;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;
using TastyTrade.Client.Model.Request;

namespace TastyTrade.Client.Model.Response
{
    /// <summary>
    /// Represents the placed order response.
    /// </summary>
    public class PlacedOrderResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public PlacedOrderResponseData Data { get; set; }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        [JsonPropertyName("error")]
        public Error Error { get; set; }
    }
    /// <summary>
    /// Represents the placed order response data.
    /// </summary>
    public class PlacedOrderResponseData
    {
        /// <summary>
        /// Gets or sets the buying power effect.
        /// </summary>
        [JsonPropertyName("buying-power-effect")]
        public BuyingPowerChangeEffect BuyingPowerEffect { get; set; }

        /// <summary>
        /// Gets or sets the fee calculation.
        /// </summary>
        [JsonPropertyName("fee-calculation")]
        public FeeCalculation FeeCalculation { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        [JsonPropertyName("order")]
        public PlacedOrderReceipt Order { get; set; }

        /// <summary>
        /// Gets or sets the warnings.
        /// </summary>
        [JsonPropertyName("warnings")]
        public List<InnerErrorOrWarning> Warnings { get; set; }
    }
    /// <summary>
    /// Represents the placed order receipt.
    /// </summary>
    public class PlacedOrderReceipt
    {
        /// <summary>
        /// Gets or sets the order id.
        /// </summary>
        [JsonPropertyName("id")]
        public long OrderId { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        [JsonPropertyName("account-number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the cancellable.
        /// </summary>
        [JsonPropertyName("cancellable")]
        public bool Cancellable { get; set; }

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
        /// Gets or sets the global request id.
        /// </summary>
        [JsonPropertyName("global-request-id")]
        public string GlobalRequestId { get; set; }

        /// <summary>
        /// Gets or sets the order type.
        /// </summary>
        [JsonPropertyName("order-type")]
        public string OrderType { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [JsonPropertyName("price")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
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
        /// Gets or sets the size.
        /// </summary>
        [JsonPropertyName("size")]
        public decimal Size { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

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
        public long UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the legs.
        /// </summary>
        [JsonPropertyName("legs")]
        public List<PlacedOrderLegResponse> Legs { get; set; }
    }

    /// <summary>
    /// Represents the placed order leg response.
    /// </summary>
    public class PlacedOrderLegResponse
    {
        /// <summary>
        /// Gets or sets the instrument type.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("instrument-type")]
        public InstrumentType InstrumentType { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("action")]
        public OrderLegAction Action { get; set; }

        /// <summary>
        /// Gets or sets the remaining quantity.
        /// </summary>
        [JsonPropertyName("remaining-quantity")]
        public decimal RemainingQuantity { get; set; }

        /// <summary>
        /// Gets or sets the fills.
        /// </summary>
        [JsonPropertyName("fills")]
        public List<PlacedOrderLegFill> Fills { get; set; }
    }
    /// <summary>
    /// Represents the placed order leg fill.
    /// </summary>
    public class PlacedOrderLegFill
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
        public decimal Quantity { get; set; }
    }
    /// <summary>
    /// Represents the buying power change effect.
    /// </summary>
    public class BuyingPowerChangeEffect
    {
        /// <summary>
        /// Gets or sets the change in margin requirement.
        /// </summary>
        [JsonPropertyName("change-in-margin-requirement")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ChangeInMarginRequirement { get; set; }

        /// <summary>
        /// Gets or sets the change in margin requirement effect.
        /// </summary>
        [JsonPropertyName("change-in-margin-requirement-effect")]
        public string ChangeInMarginRequirementEffect { get; set; }

        /// <summary>
        /// Gets or sets the change in buying power.
        /// </summary>
        [JsonPropertyName("change-in-buying-power")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ChangeInBuyingPower { get; set; }

        /// <summary>
        /// Gets or sets the current buying power effect.
        /// </summary>
        [JsonPropertyName("current-buying-power-effect")]
        public string CurrentBuyingPowerEffect { get; set; }

        /// <summary>
        /// Gets or sets the current buying power.
        /// </summary>
        [JsonPropertyName("current-buying-power")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? CurrentBuyingPower { get; set; }

        /// <summary>
        /// Gets or sets the new buying power.
        /// </summary>
        [JsonPropertyName("new-buying-power")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? NewBuyingPower { get; set; }

        /// <summary>
        /// Gets or sets the new buying power effect.
        /// </summary>
        [JsonPropertyName("new-buying-power-effect")]
        public string NewBuyingPowerEffect { get; set; }

        /// <summary>
        /// Gets or sets the isolated order margin requirement.
        /// </summary>
        [JsonPropertyName("isolated-order-margin-requirement")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? IsolatedOrderMarginRequirement { get; set; }

        /// <summary>
        /// Gets or sets the isolated order margin requirement effect.
        /// </summary>
        [JsonPropertyName("isolated-order-margin-requirement-effect")]
        public string IsolatedOrderMarginRequirementEffect { get; set; }

        /// <summary>
        /// Gets or sets the is spread.
        /// </summary>
        [JsonPropertyName("is-spread")]
        public bool IsSpread { get; set; }

        /// <summary>
        /// Gets or sets the impact.
        /// </summary>
        [JsonPropertyName("impact")]
        public string Impact { get; set; }

        /// <summary>
        /// Gets or sets the effect.
        /// </summary>
        [JsonPropertyName("effect")]
        public string Effect { get; set; }
    }

    /// <summary>
    /// Represents the fee calculation.
    /// </summary>
    public class FeeCalculation
    {
        /// <summary>
        /// Gets or sets the regulatory fees.
        /// </summary>
        [JsonPropertyName("regulatory-fees")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? RegulatoryFees { get; set; }

        /// <summary>
        /// Gets or sets the regulatory fees effect.
        /// </summary>
        [JsonPropertyName("regulatory-fees-effect")]
        public string RegulatoryFeesEffect { get; set; }

        /// <summary>
        /// Gets or sets the regulatory fees breakdown.
        /// </summary>
        [JsonPropertyName("regulatory-fees-breakdown")]
        public List<FeeBreakdown> RegulatoryFeesBreakdown { get; set; }

        /// <summary>
        /// Gets or sets the clearing fees.
        /// </summary>
        [JsonPropertyName("clearing-fees")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ClearingFees { get; set; }

        /// <summary>
        /// Gets or sets the clearing fees effect.
        /// </summary>
        [JsonPropertyName("clearing-fees-effect")]
        public string ClearingFeesEffect { get; set; }

        /// <summary>
        /// Gets or sets the clearing fees breakdown.
        /// </summary>
        [JsonPropertyName("clearing-fees-breakdown")]
        public List<FeeBreakdown> ClearingFeesBreakdown { get; set; }

        /// <summary>
        /// Gets or sets the commission.
        /// </summary>
        [JsonPropertyName("commission")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? Commission { get; set; }

        /// <summary>
        /// Gets or sets the commission effect.
        /// </summary>
        [JsonPropertyName("commission-effect")]
        public string CommissionEffect { get; set; }

        /// <summary>
        /// Gets or sets the commission breakdown.
        /// </summary>
        [JsonPropertyName("commission-breakdown")]
        public List<FeeBreakdown> CommissionBreakdown { get; set; }

        /// <summary>
        /// Gets or sets the proprietary index option fees.
        /// </summary>
        [JsonPropertyName("proprietary-index-option-fees")]
        [JsonConverter(typeof(DecimalOrStringNullableJsonConverter))]
        public decimal? ProprietaryIndexOptionFees { get; set; }

        /// <summary>
        /// Gets or sets the proprietary index option fees effect.
        /// </summary>
        [JsonPropertyName("proprietary-index-option-fees-effect")]
        public string ProprietaryIndexOptionFeesEffect { get; set; }

        /// <summary>
        /// Gets or sets the proprietary fees breakdown.
        /// </summary>
        [JsonPropertyName("proprietary-fees-breakdown")]
        public List<FeeBreakdown> ProprietaryFeesBreakdown { get; set; }

        /// <summary>
        /// Gets or sets the total fees.
        /// </summary>
        [JsonPropertyName("total-fees")]
        public string TotalFees { get; set; }

        /// <summary>
        /// Gets or sets the total fees effect.
        /// </summary>
        [JsonPropertyName("total-fees-effect")]
        public string TotalFeesEffect { get; set; }

        /// <summary>
        /// Gets or sets the rebates.
        /// </summary>
        [JsonPropertyName("rebates")]
        public string Rebates { get; set; }

        /// <summary>
        /// Gets or sets the rebates effect.
        /// </summary>
        [JsonPropertyName("rebates-effect")]
        public string RebatesEffect { get; set; }

        /// <summary>
        /// Gets or sets the rebates breakdown.
        /// </summary>
        [JsonPropertyName("rebates-breakdown")]
        public List<FeeBreakdown> RebatesBreakdown { get; set; }

        /// <summary>
        /// Gets or sets the per quantity.
        /// </summary>
        [JsonPropertyName("per-quantity")]
        public bool PerQuantity { get; set; }
    }

    /// <summary>
    /// Represents the fee breakdown.
    /// </summary>
    public class FeeBreakdown
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the effect.
        /// </summary>
        [JsonPropertyName("effect")]
        public string Effect { get; set; }
    }
}