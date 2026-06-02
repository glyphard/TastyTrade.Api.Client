using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response
{
    /// <summary>
    /// Represents the watch list response.
    /// </summary>
    public class WatchListResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public WatchList Data { get; set; }
    }

    /// <summary>
    /// Represents the watch lists response.
    /// </summary>
    public class WatchListsResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public WatchListsData Data { get; set; }
    }

    /// <summary>
    /// Represents the watch lists data.
    /// </summary>
    public class WatchListsData
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [JsonPropertyName("items")]
        public List<WatchList> Items { get; set; }
    }

    /// <summary>
    /// Represents the watch list.
    /// </summary>
    public class WatchList
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the watchlist entries.
        /// </summary>
        [JsonPropertyName("watchlist-entries")]
        public List<WatchListEntry> WatchlistEntries { get; set; }

        /// <summary>
        /// Gets or sets the cms id.
        /// </summary>
        [JsonPropertyName("cms-id")]
        public string CmsId { get; set; }

        /// <summary>
        /// Gets or sets the group name.
        /// </summary>
        [JsonPropertyName("group-name")]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the order index.
        /// </summary>
        [JsonPropertyName("order-index")]
        public int OrderIndex { get; set; }
    }

    /// <summary>
    /// Represents the watch list entry.
    /// </summary>
    public class WatchListEntry
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

    /// <summary>
    /// Represents the pairs watch list response.
    /// </summary>
    public class PairsWatchListResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public PairsWatchList Data { get; set; }
    }

    /// <summary>
    /// Represents the pairs watch lists response.
    /// </summary>
    public class PairsWatchListsResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public PairsWatchListsData Data { get; set; }
    }

    /// <summary>
    /// Represents the pairs watch lists data.
    /// </summary>
    public class PairsWatchListsData
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [JsonPropertyName("items")]
        public List<PairsWatchList> Items { get; set; }
    }

    /// <summary>
    /// Represents the pairs watch list.
    /// </summary>
    public class PairsWatchList
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the pairs equations.
        /// </summary>
        [JsonPropertyName("pairs-equations")]
        public JsonElement PairsEquations { get; set; }

        /// <summary>
        /// Gets or sets the order index.
        /// </summary>
        [JsonPropertyName("order-index")]
        public int OrderIndex { get; set; }
    }
}
