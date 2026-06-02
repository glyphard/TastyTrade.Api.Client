using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the future option product response.
/// </summary>
public class FutureOptionProductResponse
{
    /// <summary>
    /// Gets or sets the product.
    /// </summary>
    [JsonPropertyName("data")]
    public FutureOptionProduct Product { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}