using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Request;

/// <summary>
/// Represents the authorization credentials.
/// </summary>
public class AuthorizationCredentials
{
    /// <summary>
    /// Gets or sets the default account number.
    /// </summary>
    [JsonPropertyName("default-account-number")]
    public string DefaultAccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the accounts.
    /// </summary>
    [JsonPropertyName("accounts")]
    public List<UserAccountInfo> Accounts { get; set; }

    /// <summary>
    /// Gets or sets the user agent.
    /// </summary>
    [JsonPropertyName("user-agent")]
    public string UserAgent { get; set; }

    /// <summary>
    /// Gets or sets the api base url.
    /// </summary>
    [JsonPropertyName("api-base-url")]
    public string ApiBaseUrl { get; set; }

    /// <summary>
    /// Gets or sets the streaming api base url.
    /// </summary>
    [JsonPropertyName("streaming-api-base-url")]
    public string StreamingApiBaseUrl { get; set; }
}

/// <summary>
/// Represents the user account info.
/// </summary>
public class UserAccountInfo
{
    /// <summary>
    /// Gets or sets the account number.
    /// </summary>
    [JsonPropertyName("account-number")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the account type.
    /// </summary>
    [JsonPropertyName("account-type")]
    public string AccountType { get; set; }

    /// <summary>
    /// Gets or sets the account name.
    /// </summary>
    [JsonPropertyName("account-name")]
    public string AccountName { get; set; }
}
