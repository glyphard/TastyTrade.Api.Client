using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the future contract response.
/// </summary>
public class FutureContractResponse
{
    /// <summary>
    /// Gets or sets the contract.
    /// </summary>
    [JsonPropertyName("data")]
    public FutureContract Contract { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}