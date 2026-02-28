using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Request
{
    public class CreateWatchListRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("group-name")]
        public string GroupName { get; set; }

        [JsonPropertyName("order-index")]
        public int OrderIndex { get; set; } = 9999;

        [JsonPropertyName("watchlist-entries")]
        public List<WatchListEntryRequest> WatchlistEntries { get; set; }
    }

    public class UpdateWatchListRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("group-name")]
        public string GroupName { get; set; }

        [JsonPropertyName("order-index")]
        public int OrderIndex { get; set; } = 9999;

        [JsonPropertyName("watchlist-entries")]
        public List<WatchListEntryRequest> WatchlistEntries { get; set; }
    }

    public class WatchListEntryRequest
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("instrument-type")]
        public string InstrumentType { get; set; }
    }
}
