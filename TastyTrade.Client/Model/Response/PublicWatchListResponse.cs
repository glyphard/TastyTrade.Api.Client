using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response
{
    public class WatchListResponse
    {
        [JsonPropertyName("data")]
        public WatchList Data { get; set; }
    }

    public class WatchListsResponse
    {
        [JsonPropertyName("data")]
        public WatchListsData Data { get; set; }
    }

    public class WatchListsData
    {
        [JsonPropertyName("items")]
        public List<WatchList> Items { get; set; }
    }

    public class WatchList
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("watchlist-entries")]
        public List<WatchListEntry> WatchlistEntries { get; set; }

        [JsonPropertyName("cms-id")]
        public string CmsId { get; set; }

        [JsonPropertyName("group-name")]
        public string GroupName { get; set; }

        [JsonPropertyName("order-index")]
        public int OrderIndex { get; set; }
    }

    public class WatchListEntry
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("instrument-type")]
        public string InstrumentType { get; set; }
    }

    public class PairsWatchListResponse
    {
        [JsonPropertyName("data")]
        public PairsWatchList Data { get; set; }
    }

    public class PairsWatchListsResponse
    {
        [JsonPropertyName("data")]
        public PairsWatchListsData Data { get; set; }
    }

    public class PairsWatchListsData
    {
        [JsonPropertyName("items")]
        public List<PairsWatchList> Items { get; set; }
    }

    public class PairsWatchList
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("pairs-equations")]
        public JsonElement PairsEquations { get; set; }

        [JsonPropertyName("order-index")]
        public int OrderIndex { get; set; }
    }
}
