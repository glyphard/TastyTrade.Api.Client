using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Request
{
    /// <summary>
    /// Defines time in force values.
    /// </summary>
    public enum TimeInForce
    {
        /// <summary>
        /// Represents day.
        /// </summary>
        Day = 0,
        /// <summary>
        /// Represents g t d.
        /// </summary>
        GTD = 1,
        /// <summary>
        /// Represents g t c.
        /// </summary>
        GTC = 2
    }

    /// <summary>
    /// Defines order type values.
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        /// Represents limit.
        /// </summary>
        [JsonStringEnumMemberName("Limit")]
        Limit = 0,

        /// <summary>
        /// Represents market.
        /// </summary>
        [JsonStringEnumMemberName("Market")]
        Market = 1,

        /// <summary>
        /// Represents stop.
        /// </summary>
        [JsonStringEnumMemberName("Stop")]
        Stop = 2,

        /// <summary>
        /// Represents stop limit.
        /// </summary>
        [JsonStringEnumMemberName("Stop Limit")]
        StopLimit = 3,

        /// <summary>
        /// Represents notional market.
        /// </summary>
        [JsonStringEnumMemberName("Notional Market")]
        NotionalMarket = 4
    }

    /// <summary>
    /// Defines price effect values.
    /// </summary>
    public enum PriceEffect
    {
        /// <summary>
        /// Represents debit.
        /// </summary>
        Debit = 0,
        /// <summary>
        /// Represents credit.
        /// </summary>
        Credit = 1
    }


    /// <summary>
    /// Defines instrument type values.
    /// </summary>
    public enum InstrumentType
    {
        /// <summary>
        /// Represents equity.
        /// </summary>
        [JsonStringEnumMemberName("Equity")]
        Equity = 0,

        /// <summary>
        /// Represents equity option.
        /// </summary>
        [JsonStringEnumMemberName("Equity Option")]
        EquityOption = 1,

        /// <summary>
        /// Represents future.
        /// </summary>
        [JsonStringEnumMemberName("Future")]
        Future = 2,

        /// <summary>
        /// Represents future option.
        /// </summary>
        [JsonStringEnumMemberName("Future Option")]
        FutureOption = 3,

        /// <summary>
        /// Represents cryptocurrency.
        /// </summary>
        [JsonStringEnumMemberName("Cryptocurrency")]
        Cryptocurrency = 4
    }

    /// <summary>
    /// Defines order leg action values.
    /// </summary>
    public enum OrderLegAction
    {
        /// <summary>
        /// Represents buy to open.
        /// </summary>
        [JsonStringEnumMemberName("Buy to Open")]
        BuyToOpen = 0,

        /// <summary>
        /// Represents sell to open.
        /// </summary>
        [JsonStringEnumMemberName("Sell to Open")]
        SellToOpen = 1,

        /// <summary>
        /// Represents buy to close.
        /// </summary>
        [JsonStringEnumMemberName("Buy to Close")]
        BuyToClose = 2,

        /// <summary>
        /// Represents sell to close.
        /// </summary>
        [JsonStringEnumMemberName("Sell to Close")]
        SellToClose = 3,
    }

    /// <summary>
    /// Represents the place order request.
    /// </summary>
    public class PlaceOrderRequest
    {
        /// <summary>
        /// Gets or sets the time in force.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("time-in-force")]
        public TimeInForce TimeInForce { get; set; }

        /// <summary>
        /// Gets or sets the order type.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("order-type")]
        public OrderType OrderType { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the price effect.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("price-effect")]
        public PriceEffect PriceEffect { get; set; }

        /// <summary>
        /// Gets or sets the legs.
        /// </summary>
        [JsonPropertyName("legs")]
        public List<OrderSubmissionLeg> Legs { get; set; }
    }

    /// <summary>
    /// Represents the order submission leg.
    /// </summary>
    public class OrderSubmissionLeg
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
    }
}
