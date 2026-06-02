using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response
{
    /// <summary>
    /// Represents the pagination.
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// Gets or sets the per page.
        /// </summary>
        [JsonPropertyName("per-page")]
        public int PerPage { get; set; }

        /// <summary>
        /// Gets or sets the page offset.
        /// </summary>
        [JsonPropertyName("page-offset")]
        public int PageOffset { get; set; }

        /// <summary>
        /// Gets or sets the item offset.
        /// </summary>
        [JsonPropertyName("item-offset")]
        public int ItemOffset { get; set; }

        /// <summary>
        /// Gets or sets the total items.
        /// </summary>
        [JsonPropertyName("total-items")]
        public int TotalItems { get; set; }

        /// <summary>
        /// Gets or sets the total pages.
        /// </summary>
        [JsonPropertyName("total-pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or sets the current item count.
        /// </summary>
        [JsonPropertyName("current-item-count")]
        public int CurrentItemCount { get; set; }
    }
}
