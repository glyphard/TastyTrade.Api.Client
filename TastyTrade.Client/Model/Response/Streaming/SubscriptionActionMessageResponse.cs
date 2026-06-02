using System.Text.Json.Serialization;
using TastyTrade.Client.Model.Request.Streaming;

namespace TastyTrade.Client.Model.Response.Streaming
{
    /// <summary>
    /// Defines subscription action status values.
    /// </summary>
    public enum SubscriptionActionStatus {
        /// <summary>
        /// Represents o k.
        /// </summary>
        [JsonStringEnumMemberName("ok")]
        OK = 0,
        /// <summary>
        /// Represents error.
        /// </summary>
        [JsonStringEnumMemberName("error")]
        Error = 1
    }
    /// <summary>
    /// Represents the subscription action message response.
    /// </summary>
    public class SubscriptionActionMessageResponse<T> where T : class
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("status")] // one of the available actions below
        public SubscriptionActionStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("action")] // one of the available actions below
        public SubscriptionActionType Action { get; set; }

        /// <summary>
        /// Gets or sets the web socket session id.
        /// </summary>
        [JsonPropertyName("web-socket-session-id")]
        public string WebSocketSessionId { get; set; }

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
