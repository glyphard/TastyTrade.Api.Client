using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Request;

public class AuthorizationCredentials
{
    [JsonPropertyName("default-account-number")]
    public string DefaultAccountNumber { get; set; }

    [JsonPropertyName("accounts")]
    public List<UserAccountInfo> Accounts { get; set; }

    [JsonPropertyName("user-agent")]
    public string UserAgent { get; set; }

    [JsonPropertyName("api-base-url")]
    public string ApiBaseUrl { get; set; }

    [JsonPropertyName("streaming-api-base-url")]
    public string StreamingApiBaseUrl { get; set; }
}

public class UserAccountInfo
{
    [JsonPropertyName("account-number")]
    public string AccountNumber { get; set; }

    [JsonPropertyName("account-type")]
    public string AccountType { get; set; }

    [JsonPropertyName("account-name")]
    public string AccountName { get; set; }
}
