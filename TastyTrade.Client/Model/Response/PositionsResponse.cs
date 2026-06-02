using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Helper;

namespace TastyTrade.Client.Model.Response
{
    /// <summary>
    /// Represents the positions response.
    /// </summary>
    public class PositionsResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public PositionsResponseData Data { get; set; }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }
    }

    /// <summary>
    /// Represents the positions response data.
    /// </summary>
    public class PositionsResponseData
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [JsonPropertyName("items")]
        public List<PositionItem> Items { get; set; }
    }

    /// <summary>
    /// Represents the position item.
    /// </summary>
    public class PositionItem
    {
        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        [JsonPropertyName("account-number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the instrument type.
        /// </summary>
        [JsonPropertyName("instrument-type")]
        public string InstrumentType { get; set; }

        /// <summary>
        /// Gets or sets the underlying symbol.
        /// </summary>
        [JsonPropertyName("underlying-symbol")]
        public string UnderlyingSymbol { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets the quantity direction.
        /// </summary>
        [JsonPropertyName("quantity-direction")]
        public string QuantityDirection { get; set; }

        /// <summary>
        /// Gets or sets the close price.
        /// </summary>
        [JsonPropertyName("close-price")]
        public string ClosePrice { get; set; }

        /// <summary>
        /// Gets or sets the average open price.
        /// </summary>
        [JsonPropertyName("average-open-price")]
        public string AverageOpenPrice { get; set; }

        /// <summary>
        /// Gets or sets the average yearly market close price.
        /// </summary>
        [JsonPropertyName("average-yearly-market-close-price")]
        public string AverageYearlyMarketClosePrice { get; set; }

        /// <summary>
        /// Gets or sets the average daily market close price.
        /// </summary>
        [JsonPropertyName("average-daily-market-close-price")]
        public string AverageDailyMarketClosePrice { get; set; }

        /// <summary>
        /// Gets or sets the multiplier.
        /// </summary>
        [JsonPropertyName("multiplier")]
        [JsonConverter(typeof(DecimalOrStringJsonConverter))]
        public decimal Multiplier { get; set; }

        /// <summary>
        /// Gets or sets the cost effect.
        /// </summary>
        [JsonPropertyName("cost-effect")]
        public string CostEffect { get; set; }

        /// <summary>
        /// Gets or sets the is suppressed.
        /// </summary>
        [JsonPropertyName("is-suppressed")]
        public bool IsSuppressed { get; set; }

        /// <summary>
        /// Gets or sets the is frozen.
        /// </summary>
        [JsonPropertyName("is-frozen")]
        public bool IsFrozen { get; set; }

        /// <summary>
        /// Gets or sets the restricted quantity.
        /// </summary>
        [JsonPropertyName("restricted-quantity")]
        public decimal  RestrictedQuantity { get; set; }

        /// <summary>
        /// Gets or sets the realized day gain.
        /// </summary>
        [JsonPropertyName("realized-day-gain")]
        public string RealizedDayGain { get; set; }

        /// <summary>
        /// Gets or sets the realized day gain effect.
        /// </summary>
        [JsonPropertyName("realized-day-gain-effect")]
        public string RealizedDayGainEffect { get; set; }

        /// <summary>
        /// Gets or sets the realized day gain date.
        /// </summary>
        [JsonPropertyName("realized-day-gain-date")]
        public DateTime? RealizedDayGainDate { get; set; }

        /// <summary>
        /// Gets or sets the realized today.
        /// </summary>
        [JsonPropertyName("realized-today")]
        public string RealizedToday { get; set; }

        /// <summary>
        /// Gets or sets the realized today effect.
        /// </summary>
        [JsonPropertyName("realized-today-effect")]
        public string RealizedTodayEffect { get; set; }

        /// <summary>
        /// Gets or sets the realized today date.
        /// </summary>
        [JsonPropertyName("realized-today-date")]
        public DateTime? RealizedTodayDate { get; set; }

        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        [JsonPropertyName("created-at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        [JsonPropertyName("updated-at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
