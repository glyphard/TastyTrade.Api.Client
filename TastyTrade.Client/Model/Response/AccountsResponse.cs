using System;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the accounts response.
/// </summary>
public class AccountsResponse
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public AccountsData Data { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}

/// <summary>
/// Represents the accounts data.
/// </summary>
public class AccountsData
{
    /// <summary>
    /// Gets or sets the items.
    /// </summary>
    [JsonPropertyName("items")]
    public AccountsDataItem[] Items { get; set; }
}

/// <summary>
/// Represents the accounts data item.
/// </summary>
public class AccountsDataItem
{
    /// <summary>
    /// Gets or sets the account.
    /// </summary>
    [JsonPropertyName("account")]
    public AccountsDataItemAccount Account { get; set; }

    /// <summary>
    /// Gets or sets the authority level.
    /// </summary>
    [JsonPropertyName("authority-level")]
    public string AuthorityLevel { get; set; }
}

/// <summary>
/// Represents the accounts data item account.
/// </summary>
public class AccountsDataItemAccount
{
    /// <summary>
    /// Gets or sets the account number.
    /// </summary>
    [JsonPropertyName("account-number")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the external id.
    /// </summary>
    [JsonPropertyName("external-id")]
    public string ExternalId { get; set; }

    /// <summary>
    /// Gets or sets the opened at.
    /// </summary>
    [JsonPropertyName("opened-at")]
    public DateTimeOffset OpenedAt { get; set; }

    /// <summary>
    /// Gets or sets the nickname.
    /// </summary>
    [JsonPropertyName("nickname")]
    public string Nickname { get; set; }

    /// <summary>
    /// Gets or sets the account type name.
    /// </summary>
    [JsonPropertyName("account-type-name")]
    public string AccountTypeName { get; set; }

    /// <summary>
    /// Gets or sets the day trader status.
    /// </summary>
    [JsonPropertyName("day-trader-status")]
    public bool DayTraderStatus { get; set; }

    /// <summary>
    /// Gets or sets the is closed.
    /// </summary>
    [JsonPropertyName("is-closed")]
    public bool IsClosed { get; set; }

    /// <summary>
    /// Gets or sets the is firm error.
    /// </summary>
    [JsonPropertyName("is-firm-error")]
    public bool IsFirmError { get; set; }

    /// <summary>
    /// Gets or sets the is firm proprietary.
    /// </summary>
    [JsonPropertyName("is-firm-proprietary")]
    public bool IsFirmProprietary { get; set; }

    /// <summary>
    /// Gets or sets the is futures approved.
    /// </summary>
    [JsonPropertyName("is-futures-approved")]
    public bool IsFuturesApproved { get; set; }

    /// <summary>
    /// Gets or sets the is test drive.
    /// </summary>
    [JsonPropertyName("is-test-drive")]
    public bool IsTestDrive { get; set; }

    /// <summary>
    /// Gets or sets the margin or cash.
    /// </summary>
    [JsonPropertyName("margin-or-cash")]
    public string MarginOrCash { get; set; }

    /// <summary>
    /// Gets or sets the is foreign.
    /// </summary>
    [JsonPropertyName("is-foreign")]
    public bool IsForeign { get; set; }

    /// <summary>
    /// Gets or sets the funding date.
    /// </summary>
    [JsonPropertyName("funding-date")]
    public DateTimeOffset FundingDate { get; set; }

    /// <summary>
    /// Gets or sets the investment objective.
    /// </summary>
    [JsonPropertyName("investment-objective")]
    public string InvestmentObjective { get; set; }

    /// <summary>
    /// Gets or sets the futures account purpose.
    /// </summary>
    [JsonPropertyName("futures-account-purpose")]
    public string FuturesAccountPurpose { get; set; }

    /// <summary>
    /// Gets or sets the suitable options level.
    /// </summary>
    [JsonPropertyName("suitable-options-level")]
    public string SuitableOptionsLevel { get; set; }

    /// <summary>
    /// Gets or sets the created at.
    /// </summary>
    [JsonPropertyName("created-at")]
    public DateTimeOffset CreatedAt { get; set; }
}