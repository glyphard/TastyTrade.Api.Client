using System;
using System.Text.Json.Serialization;

namespace TastyTrade.Client.Model.Response;

/// <summary>
/// Represents the customer response.
/// </summary>
public class CustomerResponse
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public CustomerResponseData Data { get; set; }

    /// <summary>
    /// Gets or sets the context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}

/// <summary>
/// Represents the customer response data.
/// </summary>
public class CustomerResponseData
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the first name.
    /// </summary>
    [JsonPropertyName("first-name")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name.
    /// </summary>
    [JsonPropertyName("last-name")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    [JsonPropertyName("address")]
    public CustomerResponseAddress Address { get; set; }

    /// <summary>
    /// Gets or sets the mailing address.
    /// </summary>
    [JsonPropertyName("mailing-address")]
    public CustomerResponseAddress MailingAddress { get; set; }

    /// <summary>
    /// Gets or sets the usa citizenship type.
    /// </summary>
    [JsonPropertyName("usa-citizenship-type")]
    public string UsaCitizenshipType { get; set; }

    /// <summary>
    /// Gets or sets the is foreign.
    /// </summary>
    [JsonPropertyName("is-foreign")]
    public bool IsForeign { get; set; }

    /// <summary>
    /// Gets or sets the mobile phone number.
    /// </summary>
    [JsonPropertyName("mobile-phone-number")]
    public string MobilePhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the tax number type.
    /// </summary>
    [JsonPropertyName("tax-number-type")]
    public string TaxNumberType { get; set; }

    /// <summary>
    /// Gets or sets the birth date.
    /// </summary>
    [JsonPropertyName("birth-date")]
    public DateTimeOffset BirthDate { get; set; }

    /// <summary>
    /// Gets or sets the subject to tax withholding.
    /// </summary>
    [JsonPropertyName("subject-to-tax-withholding")]
    public bool SubjectToTaxWithholding { get; set; }

    /// <summary>
    /// Gets or sets the agreed to margining.
    /// </summary>
    [JsonPropertyName("agreed-to-margining")]
    public bool AgreedToMargining { get; set; }

    /// <summary>
    /// Gets or sets the has industry affiliation.
    /// </summary>
    [JsonPropertyName("has-industry-affiliation")]
    public bool HasIndustryAffiliation { get; set; }

    /// <summary>
    /// Gets or sets the has political affiliation.
    /// </summary>
    [JsonPropertyName("has-political-affiliation")]
    public bool HasPoliticalAffiliation { get; set; }

    /// <summary>
    /// Gets or sets the has listed affiliation.
    /// </summary>
    [JsonPropertyName("has-listed-affiliation")]
    public bool HasListedAffiliation { get; set; }

    /// <summary>
    /// Gets or sets the is professional.
    /// </summary>
    [JsonPropertyName("is-professional")]
    public bool IsProfessional { get; set; }

    /// <summary>
    /// Gets or sets the has delayed quotes.
    /// </summary>
    [JsonPropertyName("has-delayed-quotes")]
    public bool HasDelayedQuotes { get; set; }

    /// <summary>
    /// Gets or sets the has pending or approved application.
    /// </summary>
    [JsonPropertyName("has-pending-or-approved-application")]
    public bool HasPendingOrApprovedApplication { get; set; }

    /// <summary>
    /// Gets or sets the permitted account types.
    /// </summary>
    [JsonPropertyName("permitted-account-types")]
    public CustomerResponsePermittedAccountType[] PermittedAccountTypes { get; set; }

    /// <summary>
    /// Gets or sets the created at.
    /// </summary>
    [JsonPropertyName("created-at")]
    public DateTimeOffset CreatedAt { get; set; }
}

/// <summary>
/// Represents the customer response address.
/// </summary>
public class CustomerResponseAddress
{
    /// <summary>
    /// Gets or sets the street one.
    /// </summary>
    [JsonPropertyName("street-one")]
    public string StreetOne { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the state region.
    /// </summary>
    [JsonPropertyName("state-region")]
    public string StateRegion { get; set; }

    /// <summary>
    /// Gets or sets the postal code.
    /// </summary>
    [JsonPropertyName("postal-code")]
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the is foreign.
    /// </summary>
    [JsonPropertyName("is-foreign")]
    public bool IsForeign { get; set; }

    /// <summary>
    /// Gets or sets the is domestic.
    /// </summary>
    [JsonPropertyName("is-domestic")]
    public bool IsDomestic { get; set; }
}

/// <summary>
/// Represents the customer response permitted account type.
/// </summary>
public class CustomerResponsePermittedAccountType
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the is tax advantaged.
    /// </summary>
    [JsonPropertyName("is_tax_advantaged")]
    public bool IsTaxAdvantaged { get; set; }

    /// <summary>
    /// Gets or sets the has multiple owners.
    /// </summary>
    [JsonPropertyName("has_multiple_owners")]
    public bool HasMultipleOwners { get; set; }

    /// <summary>
    /// Gets or sets the is publicly available.
    /// </summary>
    [JsonPropertyName("is_publicly_available")]
    public bool IsPubliclyAvailable { get; set; }

    /// <summary>
    /// Gets or sets the margin types.
    /// </summary>
    [JsonPropertyName("margin_types")]
    public CustomerResponseMarginType[] MarginTypes { get; set; }
}

/// <summary>
/// Represents the customer response margin type.
/// </summary>
public class CustomerResponseMarginType
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the is margin.
    /// </summary>
    [JsonPropertyName("is_margin")]
    public bool IsMargin { get; set; }
}