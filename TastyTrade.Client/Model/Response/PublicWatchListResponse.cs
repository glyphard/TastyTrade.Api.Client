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
        public class WatchList {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        // Unknown/variable structure in "watchlist-entries" — keep flexible using JsonElement.
        [JsonPropertyName("watchlist-entries")]
        public List<WatchListEntry> WatchlistEntries { get; set; }

        [JsonPropertyName("cms-id")]
        public string CmsId { get; set; }

        [JsonPropertyName("group-name")]
        public string GroupName { get; set; }

        [JsonPropertyName("order-index")]
        public int OrderIndex { get; set; }
    }

    public class WatchListEntry {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        [JsonPropertyName("instrument-type")]
        public string InstrumentType { get; set; }
    }
}
