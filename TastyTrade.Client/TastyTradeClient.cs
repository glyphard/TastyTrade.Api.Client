using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using TastyTrade.Client.Model;
using TastyTrade.Client.Model.Request;
using TastyTrade.Client.Model.Response;

namespace TastyTrade.Client;

public class TastyTradeClient
{
    private AuthenticationResponse _authenticationResponse;
    private string _userAgent;
    private string _baseUrl;

    private string _accessToken;
    private string _refreshToken;
    private string _clientId;
    private string _clientSecret;

    public AuthenticationResponse GetAuthenticationResponse() { return _authenticationResponse; }

    /// <summary>
    /// Authenticates using OAuth2 flow with client credentials and refresh token.
    /// Stores the access token for subsequent API calls.
    /// </summary>
    /// <param name="credentials">Authorization credentials containing OAuth2 parameters</param>
    /// <param name="clientId">OAuth2 client ID</param>
    /// <param name="clientSecret">OAuth2 client secret</param>
    /// <param name="refreshToken">OAuth2 refresh token</param>
    public async Task AuthenticateOAuth(TastyOAuthCredentials credentials)
    {
        if (string.IsNullOrWhiteSpace(credentials.ClientId)) throw new ArgumentException("clientId is required", nameof(credentials.ClientId));
        if (string.IsNullOrWhiteSpace(credentials.ClientSecret)) throw new ArgumentException("clientSecret is required", nameof(credentials.ClientSecret));
        if (string.IsNullOrWhiteSpace(credentials.RefreshToken)) throw new ArgumentException("refreshToken is required", nameof(credentials.RefreshToken));

        _userAgent = credentials.UserAgent;
        _baseUrl = credentials.ApiBaseUrl;
        _clientId = credentials.ClientId;
        _clientSecret = credentials.ClientSecret;
        _refreshToken = credentials.RefreshToken;

        // Obtain access token via OAuth2
        _accessToken = await GetAccessTokenAsync();
    }
    public async Task Authenticate(TastyOAuthCredentials credentials)
    {
        await AuthenticateOAuth(credentials);
    }
        /// <summary>
        /// Legacy session-based authentication (deprecated - use AuthenticateOAuth for new implementations)
        /// </summary>
        [Obsolete("Use AuthenticateOAuth for OAuth2-based authentication", true)]
    public async Task Authenticate(AuthorizationCredentials credentials)
    {
        _userAgent = credentials.UserAgent;
        _baseUrl = credentials.ApiBaseUrl;

        using var client = new HttpClient();
        client.DefaultRequestHeaders.UserAgent.ParseAdd(credentials.UserAgent);
        using var content = new StringContent(JsonSerializer.Serialize(credentials));
        content.Headers.ContentType = new MediaTypeHeaderValue(Constants.ContentType);
        var response = await client.PostAsync($"{_baseUrl}/sessions", content);
        var responseJson = await response.Content.ReadAsStringAsync();
        _authenticationResponse = JsonSerializer.Deserialize<AuthenticationResponse>(responseJson);
    }

    /// <summary>
    /// Obtains an OAuth2 access token using the refresh token grant type.
    /// </summary>
    private async Task<string> GetAccessTokenAsync()
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.UserAgent.ParseAdd(_userAgent ?? "TastyTradeClient/1.0");
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));

        var formData = new Dictionary<string, string>
        {
            { "grant_type", "refresh_token" },
            { "refresh_token", _refreshToken },
            { "client_id", _clientId },
            { "client_secret", _clientSecret }
        };

        using var content = new FormUrlEncodedContent(formData);
        var response = await client.PostAsync($"{_baseUrl}/oauth/token", content);
        var responseJson = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new InvalidOperationException($"OAuth token request failed: {response.StatusCode} - {responseJson}");
        }

        using var doc = JsonDocument.Parse(responseJson);
        if (doc.RootElement.TryGetProperty("access_token", out var token))
            return token.GetString() ?? throw new InvalidOperationException("access_token was null");

        if (doc.RootElement.TryGetProperty("data", out var data) &&
            data.TryGetProperty("access_token", out var nestedToken))
            return nestedToken.GetString() ?? throw new InvalidOperationException("data.access_token was null");

        throw new InvalidOperationException($"OAuth response did not include access_token: {responseJson}");
    }

    /// <summary>
    /// Refreshes the OAuth2 access token if needed. Can be called manually or automatically when a 401 is detected.
    /// </summary>
    public async Task RefreshAccessTokenAsync()
    {
        if (string.IsNullOrWhiteSpace(_clientId) || string.IsNullOrWhiteSpace(_clientSecret) || string.IsNullOrWhiteSpace(_refreshToken))
        {
            throw new InvalidOperationException("OAuth credentials not configured. Use AuthenticateOAuth first.");
        }

        _accessToken = await GetAccessTokenAsync();
    }

    public async Task<CustomerResponse> GetCustomer()
    {
        var response = await Get($"{_baseUrl}/customers/me");
        return JsonSerializer.Deserialize<CustomerResponse>(response);
    }
    public async Task<ApiQuoteTokenResponse> GetApiQuoteTokens()
    {
        var response = await Get($"{_baseUrl}/api-quote-tokens");
        return JsonSerializer.Deserialize<ApiQuoteTokenResponse>(response);
    }
    public async Task<AccountsResponse> GetAccounts()
    {
        var response = await Get($"{_baseUrl}/customers/me/accounts");
        return JsonSerializer.Deserialize<AccountsResponse>(response);
    }
    public async Task<AccountResponse> GetAccount(string accountNumber)
    {
        var response = await Get($"{_baseUrl}/customers/me/accounts/{accountNumber}");
        return JsonSerializer.Deserialize<AccountResponse>(response);
    }
    public async Task<TradingStatusResponse> GetAccountStatus(string accountNumber)
    {
        var response = await Get($"{_baseUrl}/accounts/{accountNumber}/trading-status");
        return JsonSerializer.Deserialize<TradingStatusResponse>(response);
    }
    public async Task<AccountBalanceResponse> GetAccountBalance(string accountNumber)
    {
        var response = await Get($"{_baseUrl}/accounts/{accountNumber}/balances");
        return JsonSerializer.Deserialize<AccountBalanceResponse>(response);
    }
    public async Task<AccountBalanceResponse> GetAccountBalance(string accountNumber, string currency)
    {
        var response = await Get($"{_baseUrl}/accounts/{accountNumber}/balances/{currency}");
        return JsonSerializer.Deserialize<AccountBalanceResponse>(response);
    }
    public async Task<AccountBalanceResponse> GetAccountBalanceSnapshot(string accountNumber)
    {
        var response = await Get($"{_baseUrl}/accounts/{accountNumber}/balance-snapshots");
        return JsonSerializer.Deserialize<AccountBalanceResponse>(response);
    }
    public async Task<FutureContractsResponse> GetAllFutures()
    {
        var response = await Get($"{_baseUrl}/instruments/futures");
        return JsonSerializer.Deserialize<FutureContractsResponse>(response);
    }
    public async Task<FutureOptionProductsResponse> GetAllFutureOptionProducts()
    {
        var response = await Get($"{_baseUrl}/instruments/future-option-products");
        return JsonSerializer.Deserialize<FutureOptionProductsResponse>(response);
    }
    public async Task<FutureOptionProductResponse> GetFutureOptionProduct(string exchange, string symbol)
    {
        var response = await Get($"{_baseUrl}/instruments/future-option-products/{exchange}/{symbol}");
        return JsonSerializer.Deserialize<FutureOptionProductResponse>(response);
    }
    public async Task<FutureContractResponse> GetFuturesContract(string symbol)
    {
        var response = await Get($"{_baseUrl}/instruments/futures/{symbol}");
        return JsonSerializer.Deserialize<FutureContractResponse>(response);
    }
    public async Task<SearchResponse> Search(string symbol)
    {
        //this method seemed to be unavalaible at the time I added it.
        var response = await Get($"{_baseUrl}/symbols/search/{symbol}");
        return JsonSerializer.Deserialize<SearchResponse>(response);
    }
    public async Task<OptionChainResponse> GetOptionChains(string symbol)
    {
        var response = await Get($"{_baseUrl}/option-chains/{symbol}");
        var chain = JsonSerializer.Deserialize<OptionChainResponse>(response);
        chain.Data.Items = [.. chain.Data.Items.Where(x => x.Active).OrderBy(x => x.StrikePrice)];
        return chain;
    }
    public async Task<OptionChainResponse> GetFutureOptionChains(string symbol)
    {
        var response = await Get($"{_baseUrl}/futures-option-chains/{symbol}");
        var chain = JsonSerializer.Deserialize<OptionChainResponse>(response);
        chain.Data.Items = [.. chain.Data.Items.Where(x => x.Active).OrderBy(x => x.StrikePrice)];
        return chain;
    }

    // Decorator method: keeps original simple call but delegates to the overload that supports date range + pagination.
    public async Task<TransactionsResponse> GetTransactions(string accountNumber)
    {
        var sinceWhen = DateTime.UtcNow.AddMonths(-12);
        var untilWhen = DateTime.UtcNow;
        return await GetTransactions(accountNumber, sinceWhen, untilWhen);
    }

    // Implementation: fetches all pages using pagination (top-level "pagination" object) and aggregates items.
    public async Task<TransactionsResponse> GetTransactions(string accountNumber, DateTime startDate, DateTime endDate)
    {
        if (string.IsNullOrWhiteSpace(accountNumber)) throw new ArgumentException("accountNumber is required", nameof(accountNumber));
        var aggregatedItems = new List<TransactionsResponseDataItem>();

        const int perPage = 500;
        int pageOffset = 0;
        int totalPages = 1; // default to 1; will be replaced by pagination data when present

        while (pageOffset < totalPages)
        {
            var url = $"{_baseUrl}/accounts/{accountNumber}/transactions?per-page={perPage}&start-date={startDate:yyyy-MM-dd}&end-date={endDate:yyyy-MM-dd}&page-offset={pageOffset}";
            var responseText = await Get(url);
            if (string.IsNullOrWhiteSpace(responseText))
            {
                break;
            }

            using var doc = JsonDocument.Parse(responseText);
            var root = doc.RootElement;

            // Extract data.items if present
            if (root.TryGetProperty("data", out var dataElement) && dataElement.TryGetProperty("items", out var itemsElement) && itemsElement.ValueKind == JsonValueKind.Array)
            {
                // Deserialize page items into the typed list and append
                var pageItems = JsonSerializer.Deserialize<List<TransactionsResponseDataItem>>(itemsElement.GetRawText());
                if (pageItems != null && pageItems.Count > 0)
                {
                    aggregatedItems.AddRange(pageItems);
                }
            }

            // Read pagination info if present to determine loop termination
            if (root.TryGetProperty("pagination", out var pagination))
            {
                // preferred: use total-pages if available
                if (pagination.TryGetProperty("total-pages", out var totalPagesProp) && totalPagesProp.ValueKind == JsonValueKind.Number)
                {
                    totalPages = totalPagesProp.GetInt32();
                }
                else
                {
                    // fallback: use total-items to compute pages if available
                    if (pagination.TryGetProperty("total-items", out var totalItemsProp) && totalItemsProp.ValueKind == JsonValueKind.Number)
                    {
                        var totalItems = totalItemsProp.GetInt32();
                        totalPages = Math.Max(1, (int)Math.Ceiling(totalItems / (double)perPage));
                    }
                }
            }
            else
            {
                // No pagination present -> single page only
                break;
            }

            pageOffset++;
        }

        return new TransactionsResponse
        {
            Data = new TransactionsResponseData
            {
                Items = aggregatedItems
            }
        };
    }



    public async Task<EquityResponse> GetEquity(string symbol)
    {
        var response = await Get($"{_baseUrl}/instruments/equities/{symbol}");
        return JsonSerializer.Deserialize<EquityResponse>(response);
    }

    // New: retrieve positions for an account
    public async Task<PositionsResponse> GetPositions(string accountNumber)
    {
        var response = await Get($"{_baseUrl}/accounts/{accountNumber}/positions");
        return JsonSerializer.Deserialize<PositionsResponse>(response);
    }
    
    public async Task<WatchListResponse> GetPublicWatchList(string watchlist_name)
    {
        var response = await Get($"{_baseUrl}/public-watchlists/{watchlist_name}");
        return JsonSerializer.Deserialize<WatchListResponse>(response);
    }

    public async Task<WatchListResponse> GetUserWatchList(string watchlist_name)
    {
        var response = await Get($"{_baseUrl}/watchlists/{watchlist_name}");
        if (string.IsNullOrWhiteSpace(response)) {
            return default(WatchListResponse);
        }
        return JsonSerializer.Deserialize<WatchListResponse>(response);
    }

    public async Task<MarketMetricsInfoResponse> GetMarketMetrics(string[] symbols)
    {
        var response = await Get($"{_baseUrl}/market-metrics?symbols={string.Join(',', symbols)}");
        if (string.IsNullOrWhiteSpace(response))
        {
            return default(MarketMetricsInfoResponse);
        }
        return JsonSerializer.Deserialize<MarketMetricsInfoResponse>(response);
    }
    public async Task<MarginRequirementsPublicConfigurationResponse> GetMarginRequirementsPublicConfiguration()
    {
        var response = await Get($"{_baseUrl}/margin-requirements-public-configuration");
        if (string.IsNullOrWhiteSpace(response))
        {
            return default(MarginRequirementsPublicConfigurationResponse);
        }
        return JsonSerializer.Deserialize<MarginRequirementsPublicConfigurationResponse>(response);
    }

    public async Task<MarketDataResponse> GetMarketData(string[] index, string[] equity, string[] equityOption, string[] future, string[] futureOption, string[] cryptocurrency)
    {
        var indexParam = index?.Length > 0 ? string.Join(',', index) : string.Empty;
        var equityParam = equity?.Length > 0 ? string.Join(',', equity) : string.Empty;
        var equityOptionParam = equityOption?.Length > 0 ? string.Join(',', equityOption) : string.Empty;

        var futureParam = future?.Length > 0 ? string.Join(',', future) : string.Empty;
        var futureOptionParam = futureOption?.Length > 0 ? string.Join(',', futureOption) : string.Empty;
        var cryptocurrencyParam = cryptocurrency?.Length > 0 ? string.Join(',', cryptocurrency) : string.Empty;

        var response = await Get($"{_baseUrl}/market-data/by-type?index={indexParam}&equity={equityParam}&equity-option={equityOptionParam}&future={futureParam}&future-option={futureOptionParam}&cryptocurrency={cryptocurrencyParam}");

        if (string.IsNullOrWhiteSpace(response))
        {
            return default(MarketDataResponse);
        }
        return JsonSerializer.Deserialize<MarketDataResponse>(response);
    }

    

    private async Task<string> Get(string url)
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.UserAgent.ParseAdd(_userAgent);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.Accept));
        
        // Use Bearer token authentication if OAuth2 is configured; otherwise fall back to session token
        if (!string.IsNullOrWhiteSpace(_accessToken))
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
        }
        else if (_authenticationResponse?.Data?.SessionToken != null)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_authenticationResponse.Data.SessionToken);
        }
        //this silently 401's after teh access token times out
        var response = await client.GetAsync(url);
        return await response.Content.ReadAsStringAsync();
    }

    private async Task<string> Post(string url, string jsonBody)
    {
        var uri = new Uri(url);
        using var client = new HttpClient();
        client.DefaultRequestHeaders.UserAgent.ParseAdd(_userAgent);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.Accept));
        
        // Use Bearer token authentication if OAuth2 is configured; otherwise fall back to session token
        if (!string.IsNullOrWhiteSpace(_accessToken))
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
        }
        else if (_authenticationResponse?.Data?.SessionToken != null)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_authenticationResponse.Data.SessionToken);
        }

        using var content = new StringContent( jsonBody );
        content.Headers.ContentType = new MediaTypeHeaderValue(Constants.ContentType);

        var response = await client.PostAsync(uri, content);
        if ((!response.IsSuccessStatusCode) && (response.StatusCode != HttpStatusCode.UnprocessableEntity))
        {
            var errorResponseTextIfAny = await response.Content.ReadAsStringAsync();
            throw new InvalidOperationException($"{uri.PathAndQuery} - {response.StatusCode.ToString()}-{response.ReasonPhrase}", new InvalidOperationException(errorResponseTextIfAny));
        }
        var responseText = await response.Content.ReadAsStringAsync();
        return responseText;
    }

    private async Task<ResponseType> Post<RequestType, ResponseType>(string url, RequestType requestBodyObject) 
        where RequestType : new()
        where ResponseType : new() 
    {

        var requestBodyJson = JsonSerializer.Serialize(requestBodyObject);
        var responseJson = await Post(url, requestBodyJson);

        var responseType = JsonSerializer.Deserialize<ResponseType>(responseJson);

        return responseType;
    }


    public async Task<PlacedOrderResponse> PostOrderSubmission(string accountNumber, PlaceOrderRequest orderSubmission) {
        var orderSubmissionResponse = await Post<PlaceOrderRequest, PlacedOrderResponse> ($"{_baseUrl}/accounts/{accountNumber}/orders", orderSubmission);
        return orderSubmissionResponse;
    }
}
