using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Request
{
    /// <summary>
    /// Represents the create watch list request.
    /// </summary>
    public class CreateWatchListRequest
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the group name.
        /// </summary>
        [JsonPropertyName("group-name")]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the order index.
        /// </summary>
        [JsonPropertyName("order-index")]
        public int OrderIndex { get; set; } = 9999;

        /// <summary>
        /// Gets or sets the watchlist entries.
        /// </summary>
        [JsonPropertyName("watchlist-entries")]
        public List<WatchListEntryRequest> WatchlistEntries { get; set; }
    }

    /// <summary>
    /// Represents the update watch list request.
    /// </summary>
    public class UpdateWatchListRequest
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the group name.
        /// </summary>
        [JsonPropertyName("group-name")]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the order index.
        /// </summary>
        [JsonPropertyName("order-index")]
        public int OrderIndex { get; set; } = 9999;

        /// <summary>
        /// Gets or sets the watchlist entries.
        /// </summary>
        [JsonPropertyName("watchlist-entries")]
        public List<WatchListEntryRequest> WatchlistEntries { get; set; }
    }

    /// <summary>
    /// Represents the watch list entry request.
    /// </summary>
    public class WatchListEntryRequest
    {
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
    }
}
