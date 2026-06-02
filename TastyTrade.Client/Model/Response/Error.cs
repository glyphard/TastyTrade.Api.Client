using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the error.
/// </summary>
public class Error
{
    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the message.
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or sets the errors.
    /// </summary>
    [JsonPropertyName("errors")]
    public List<InnerErrorOrWarning> Errors { get; set; }

}

/// <summary>
/// Represents the inner error or warning.
/// </summary>
public class InnerErrorOrWarning
{
    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the message.
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

}
