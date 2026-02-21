using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TastyTrade.Client.Model.Request
{
    public class TastyOAuthCredentials
    {
        /// <summary>
        /// Stores OAuth2 credentials for TastyTrade API authentication
        /// </summary>
        //public class OAuthCredentials
        //{
            /// <summary>
            /// OAuth2 client ID
            /// </summary>
            [Required]
            public string ClientId { get; set; }

            /// <summary>
            /// OAuth2 client secret
            /// </summary>
            [Required]
            public string ClientSecret { get; set; }

            /// <summary>
            /// OAuth2 refresh token for obtaining new access tokens
            /// </summary>
            [Required]
            public string RefreshToken { get; set; }

            /// <summary>
            /// TastyTrade API base URL
            /// </summary>
            [Required]
            [JsonPropertyName("api-base-url")]
            public string ApiBaseUrl { get; set; }

            /// <summary>
            /// TastyTrade streaming API base URL
            /// </summary>
            [JsonPropertyName("streaming-api-base-url")]
            public string StreamingApiBaseUrl { get; set; }

            /// <summary>
            /// User agent string for API requests
            /// </summary>
            [Required]
            [JsonPropertyName("user-agent")]
            public string UserAgent { get; set; }

            /// <summary>
            /// When these credentials were created or last updated
            /// </summary>
            public DateTime LastUpdated { get; set; }
        //}
    }
}
