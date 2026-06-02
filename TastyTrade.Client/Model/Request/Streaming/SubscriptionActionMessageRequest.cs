using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Request.Streaming
{
    /// <summary>
    /// Defines subscription action type values.
    /// </summary>
    public enum SubscriptionActionType
    {

        /// <summary>
        /// Represents connect.
        /// </summary>
        [JsonStringEnumMemberName("connect")]
        Connect = 0,
        /// <summary>
        /// Represents heartbeat.
        /// </summary>
        [JsonStringEnumMemberName("heartbeat")]
        Heartbeat = 1,
        /// <summary>
        /// Represents public watchlists subscribe.
        /// </summary>
        [JsonStringEnumMemberName("public-watchlists-subscribe")]
        PublicWatchlistsSubscribe = 2,
        /// <summary>
        /// Represents quote alerts subscribe.
        /// </summary>
        [JsonStringEnumMemberName("quote-alerts-subscribe")]
        QuoteAlertsSubscribe = 3,
        /// <summary>
        /// Represents user message subscribe.
        /// </summary>
        [JsonStringEnumMemberName("user-message-subscribe")]
        UserMessageSubscribe = 4
    }

    /// <summary>
    /// Represents the subscription action message request.
    /// </summary>
    public class SubscriptionActionMessageRequest<T>
    {
        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("action")] // one of the available actions below
        public SubscriptionActionType Action { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonPropertyName("value")] // Optional. Depends on the message action being sent (see available actions below)
        public T[] Value { get; set; }

        /// <summary>
        /// Gets or sets the auth token.
        /// </summary>
        [JsonPropertyName("auth-token")] // `session-token` value from session creation response
        public string AuthToken { get; set; }

        /// <summary>
        /// Gets or sets the request id.
        /// </summary>
        [JsonPropertyName("request-id")]
        public long RequestId { get; set; }
    }
}
