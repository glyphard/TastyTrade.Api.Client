# TastyTrade.Api.Client

A C# client library for the Tasty Trade API

For updates and issues refer to https://github.com/veritacodex/TastyTrade.Api.Client

## Authentication

### OAuth2 Authentication (Recommended)

The TastyTrade API supports OAuth2 authentication using refresh tokens. This is the recommended authentication method.

#### Setup

1. First, obtain your OAuth credentials from TastyTrade:
   - Client ID
   - Client Secret
   - Refresh Token

2. Create an instance of `TastyTradeClient` and authenticate:

```csharp
using TastyTrade.Client;

var client = new TastyTradeClient();

var credentials = new TastyOAuthCredentials
{
    ClientId = "your-client-id",
    ClientSecret = "your-client-secret",
    RefreshToken = "your-refresh-token",
    UserAgent = "YourApp/1.0",
    ApiBaseUrl = "https://api.tastyworks.com"  // or "https://api.cert.tastyworks.com" for certification
};

// Authenticate with default token refresh interval
await client.AuthenticateOAuth(credentials);

// Or specify a custom refresh interval
await client.AuthenticateOAuth(credentials, refreshTokenLifetimeMax: TimeSpan.FromMinutes(15));

// Alternative shorthand method
await client.Authenticate(credentials);
```

#### Token Management

The client automatically handles token management:

- **Automatic Refresh**: Tokens are proactively refreshed before expiration (default: 17 minutes)
- **Retry on 401**: If a request receives a 401 Unauthorized response, the token is refreshed and the request is automatically retried
- **Thread-Safe**: Token refresh operations are protected by a semaphore to prevent race conditions

You can also manually refresh the token if needed:

```csharp
await client.RefreshAccessTokenAsync();
```

## Usage Examples

### Get Customer Information

```csharp
var customer = await client.GetCustomer();
Console.WriteLine($"Customer: {customer.Data.FirstName} {customer.Data.LastName}");
```

### Get Accounts

```csharp
var accounts = await client.GetAccounts();
foreach (var account in accounts.Data.Items)
{
    Console.WriteLine($"Account: {account.AccountNumber}");
}
```

### Get Account Positions

```csharp
var positions = await client.GetPositions("YOUR_ACCOUNT_NUMBER");
foreach (var position in positions.Data.Items)
{
    Console.WriteLine($"Symbol: {position.Symbol}, Quantity: {position.Quantity}");
}
```

### Get Market Data

```csharp
var marketData = await client.GetMarketData(
    index: null,
    equity: new[] { "AAPL", "MSFT" },
    equityOption: null,
    future: null,
    futureOption: null,
    cryptocurrency: null
);
```

### Get Option Chains

```csharp
var optionChain = await client.GetOptionChains("AAPL");
foreach (var option in optionChain.Data.Items)
{
    Console.WriteLine($"Strike: {option.StrikePrice}, Expiration: {option.ExpirationDate}");
}
```

### Get Transactions with Pagination

```csharp
// Get last 12 months of transactions (automatically handles pagination)
var transactions = await client.GetTransactions("YOUR_ACCOUNT_NUMBER");

// Or specify a custom date range
var startDate = new DateTime(2024, 1, 1);
var endDate = DateTime.UtcNow;
var transactionsInRange = await client.GetTransactions("YOUR_ACCOUNT_NUMBER", startDate, endDate);
```

### Place an Order

```csharp
var orderRequest = new PlaceOrderRequest
{
    // Configure your order details here
    // See TastyTrade API documentation for order structure
};

var orderResponse = await client.PostOrderSubmission("YOUR_ACCOUNT_NUMBER", orderRequest);
```

## Best Practices

1. **Store credentials securely**: Never hardcode credentials in your source code. Use environment variables, Azure Key Vault, or other secure credential management solutions.

2. **Reuse client instances**: Create a single `TastyTradeClient` instance and reuse it for multiple API calls to benefit from automatic token management.

3. **Handle exceptions**: Wrap API calls in try-catch blocks to handle network errors and API exceptions gracefully.

4. **Rate limiting**: Be mindful of API rate limits and implement appropriate throttling in your application.

## Requirements

- .NET 8 or higher

## License

Refer to the repository for license information.