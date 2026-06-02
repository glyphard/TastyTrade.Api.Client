using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the future contracts response.
/// </summary>
public class FutureContractsResponse
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public FuturesData Data { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}

/// <summary>
/// Represents the futures data.
/// </summary>
public class FuturesData
{
    /// <summary>
    /// Gets or sets the items.
    /// </summary>
    [JsonPropertyName("items")]
    public List<FutureContract> Items { get; set; }
}
