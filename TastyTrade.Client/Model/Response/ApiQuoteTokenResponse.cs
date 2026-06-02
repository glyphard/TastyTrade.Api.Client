using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the api quote token response.
/// </summary>
public class ApiQuoteTokenResponse
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public ApiQuoteTokenData Data { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}

/// <summary>
/// Represents the api quote token data.
/// </summary>
public class ApiQuoteTokenData
{
    /// <summary>
    /// Gets or sets the token.
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; }

    /// <summary>
    /// Gets or sets the dxlink url.
    /// </summary>
    [JsonPropertyName("dxlink-url")]
    public string DxlinkUrl { get; set; }

    /// <summary>
    /// Gets or sets the level.
    /// </summary>
    [JsonPropertyName("level")]
    public string Level { get; set; }
}
