using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response
{
    public class Pagination
    {
        [JsonPropertyName("per-page")]
        public int PerPage { get; set; }

        [JsonPropertyName("page-offset")]
        public int PageOffset { get; set; }

        [JsonPropertyName("item-offset")]
        public int ItemOffset { get; set; }

        [JsonPropertyName("total-items")]
        public int TotalItems { get; set; }

        [JsonPropertyName("total-pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("current-item-count")]
        public int CurrentItemCount { get; set; }
    }
}
