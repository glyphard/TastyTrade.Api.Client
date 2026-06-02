using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the authentication response.
/// </summary>
public class AuthenticationResponse
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public AuthenticationResponseData Data { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }

    /// <summary>
    /// Gets or sets the error.
    /// </summary>
    [JsonPropertyName("error")]
    public Error Error { get; set; }
}

/// <summary>
/// Represents the authentication response data.
/// </summary>
public class AuthenticationResponseData
{
    /// <summary>
    /// Gets or sets the user.
    /// </summary>
    [JsonPropertyName("user")]
    public AuthenticationResponseUser User { get; set; }

    /// <summary>
    /// Gets or sets the session token.
    /// </summary>
    [JsonPropertyName("session-token")]
    public string SessionToken { get; set; }

    /// <summary>
    /// Gets or sets the remember token.
    /// </summary>
    [JsonPropertyName("remember-token")]
    public string RememberToken { get; set; }
}

/// <summary>
/// Represents the authentication response user.
/// </summary>
public class AuthenticationResponseUser
{
    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the username.
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }

    /// <summary>
    /// Gets or sets the external id.
    /// </summary>
    [JsonPropertyName("external-id")]
    public string ExternalId { get; set; }
}
