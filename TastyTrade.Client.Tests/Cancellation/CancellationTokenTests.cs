using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using TastyTrade.Client;
using TastyTrade.Client.Model.Request;

namespace TastyTrade.Client.Tests.Cancellation
{
    /// <summary>
    /// Verifies that every public facade method on <see cref="TastyTradeClient"/> that performs
    /// network I/O honours its <see cref="CancellationToken"/> and surfaces an
    /// <see cref="OperationCanceledException"/> (which <see cref="TaskCanceledException"/> derives from)
    /// when the token is already cancelled.
    ///
    /// A pre-cancelled token guarantees cancellation is observed before any socket work, so these
    /// tests do not require a live TastyTrade endpoint. An absolute (but unroutable) base URL is set
    /// via reflection so the request passes URI validation and reaches the cancellation check.
    /// </summary>
    public class CancellationTokenTests
    {
        // Discard port (9) on localhost — absolute and well-formed, but the cancelled token
        // short-circuits before any connection is attempted.
        private const string BaseUrl = "http://localhost:9";

        private static TastyTradeClient NewClient()
        {
            var client = new TastyTradeClient();
            SetPrivateField(client, "_baseUrl", BaseUrl);
            SetPrivateField(client, "_userAgent", "TastyTradeClientTests/1.0");
            return client;
        }

        private static void SetPrivateField(object target, string fieldName, object value)
        {
            var field = typeof(TastyTradeClient).GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
            Assert.That(field, Is.Not.Null, $"expected private field '{fieldName}' on TastyTradeClient");
            field.SetValue(target, value);
        }

        private static CancellationToken CancelledToken()
        {
            var cts = new CancellationTokenSource();
            cts.Cancel();
            return cts.Token;
        }

        // Use Throws.InstanceOf so that both OperationCanceledException (thrown by
        // ThrowIfCancellationRequested / SemaphoreSlim.WaitAsync) and its derived
        // TaskCanceledException (thrown by HttpClient) satisfy the assertion.
        private static void AssertCancels(AsyncTestDelegate action)
            => Assert.That(action, Throws.InstanceOf<OperationCanceledException>());

        // ---- Authentication -------------------------------------------------

        [Test]
        public void AuthenticateOAuth_HonoursCancellation()
        {
            var client = NewClient();
            var credentials = new TastyOAuthCredentials
            {
                ClientId = "id",
                ClientSecret = "secret",
                RefreshToken = "refresh",
                ApiBaseUrl = BaseUrl,
                UserAgent = "TastyTradeClientTests/1.0"
            };
            AssertCancels(() => client.AuthenticateOAuth(credentials, cancellationToken: CancelledToken()));
        }

        [Test]
        public void Authenticate_OAuth_HonoursCancellation()
        {
            var client = NewClient();
            var credentials = new TastyOAuthCredentials
            {
                ClientId = "id",
                ClientSecret = "secret",
                RefreshToken = "refresh",
                ApiBaseUrl = BaseUrl,
                UserAgent = "TastyTradeClientTests/1.0"
            };
            AssertCancels(() => client.Authenticate(credentials, cancellationToken: CancelledToken()));
        }

        [Test]
        public void RefreshAccessTokenAsync_HonoursCancellation()
        {
            var client = NewClient();
            // RefreshAccessTokenAsync requires OAuth credentials to be configured before it will attempt a refresh.
            SetPrivateField(client, "_clientId", "id");
            SetPrivateField(client, "_clientSecret", "secret");
            SetPrivateField(client, "_refreshToken", "refresh");
            AssertCancels(() => client.RefreshAccessTokenAsync(CancelledToken()));
        }

        // ---- Customer / accounts -------------------------------------------

        [Test]
        public void GetCustomer_HonoursCancellation()
            => AssertCancels(() => NewClient().GetCustomer(CancelledToken()));

        [Test]
        public void GetApiQuoteTokens_HonoursCancellation()
            => AssertCancels(() => NewClient().GetApiQuoteTokens(CancelledToken()));

        [Test]
        public void GetAccounts_HonoursCancellation()
            => AssertCancels(() => NewClient().GetAccounts(CancelledToken()));

        [Test]
        public void GetAccount_HonoursCancellation()
            => AssertCancels(() => NewClient().GetAccount("ACC", CancelledToken()));

        [Test]
        public void GetAccountStatus_HonoursCancellation()
            => AssertCancels(() => NewClient().GetAccountStatus("ACC", CancelledToken()));

        [Test]
        public void GetAccountBalance_HonoursCancellation()
            => AssertCancels(() => NewClient().GetAccountBalance("ACC", CancelledToken()));

        [Test]
        public void GetAccountBalance_WithCurrency_HonoursCancellation()
            => AssertCancels(() => NewClient().GetAccountBalance("ACC", "USD", CancelledToken()));

        [Test]
        public void GetAccountBalanceSnapshot_HonoursCancellation()
            => AssertCancels(() => NewClient().GetAccountBalanceSnapshot("ACC", CancelledToken()));

        // ---- Instruments ----------------------------------------------------

        [Test]
        public void GetAllFutures_HonoursCancellation()
            => AssertCancels(() => NewClient().GetAllFutures(CancelledToken()));

        [Test]
        public void GetAllFutureOptionProducts_HonoursCancellation()
            => AssertCancels(() => NewClient().GetAllFutureOptionProducts(CancelledToken()));

        [Test]
        public void GetFutureOptionProduct_HonoursCancellation()
            => AssertCancels(() => NewClient().GetFutureOptionProduct("CME", "ES", CancelledToken()));

        [Test]
        public void GetFuturesContract_HonoursCancellation()
            => AssertCancels(() => NewClient().GetFuturesContract("ESZ4", CancelledToken()));

        [Test]
        public void Search_HonoursCancellation()
            => AssertCancels(() => NewClient().Search("AAPL", CancelledToken()));

        [Test]
        public void GetOptionChains_HonoursCancellation()
            => AssertCancels(() => NewClient().GetOptionChains("AAPL", CancelledToken()));

        [Test]
        public void GetFutureOptionChains_HonoursCancellation()
            => AssertCancels(() => NewClient().GetFutureOptionChains("ES", CancelledToken()));

        [Test]
        public void GetEquity_HonoursCancellation()
            => AssertCancels(() => NewClient().GetEquity("AAPL", CancelledToken()));

        // ---- Transactions (paginated) --------------------------------------

        [Test]
        public void GetTransactions_HonoursCancellation()
            => AssertCancels(() => NewClient().GetTransactions("ACC", CancelledToken()));

        [Test]
        public void GetTransactions_WithDateRange_HonoursCancellation()
            => AssertCancels(() =>
                NewClient().GetTransactions("ACC", new DateTime(2024, 1, 1), new DateTime(2024, 12, 31), CancelledToken()));

        // ---- Positions ------------------------------------------------------

        [Test]
        public void GetPositions_HonoursCancellation()
            => AssertCancels(() => NewClient().GetPositions("ACC", CancelledToken()));

        // ---- Watchlists -----------------------------------------------------

        [Test]
        public void GetAllPublicWatchLists_HonoursCancellation()
            => AssertCancels(() => NewClient().GetAllPublicWatchLists(false, CancelledToken()));

        [Test]
        public void GetPublicWatchList_HonoursCancellation()
            => AssertCancels(() => NewClient().GetPublicWatchList("name", CancelledToken()));

        [Test]
        public void GetAllUserWatchLists_HonoursCancellation()
            => AssertCancels(() => NewClient().GetAllUserWatchLists(CancelledToken()));

        [Test]
        public void GetUserWatchList_HonoursCancellation()
            => AssertCancels(() => NewClient().GetUserWatchList("name", CancelledToken()));

        [Test]
        public void CreateUserWatchList_HonoursCancellation()
            => AssertCancels(() => NewClient().CreateUserWatchList(new CreateWatchListRequest(), CancelledToken()));

        [Test]
        public void UpdateUserWatchList_HonoursCancellation()
            => AssertCancels(() => NewClient().UpdateUserWatchList("name", new UpdateWatchListRequest(), CancelledToken()));

        [Test]
        public void DeleteUserWatchList_HonoursCancellation()
            => AssertCancels(() => NewClient().DeleteUserWatchList("name", CancelledToken()));

        [Test]
        public void GetAllPairsWatchLists_HonoursCancellation()
            => AssertCancels(() => NewClient().GetAllPairsWatchLists(CancelledToken()));

        [Test]
        public void GetPairsWatchList_HonoursCancellation()
            => AssertCancels(() => NewClient().GetPairsWatchList("name", CancelledToken()));

        // ---- Market metrics / data -----------------------------------------

        [Test]
        public void GetMarketMetrics_HonoursCancellation()
            => AssertCancels(() => NewClient().GetMarketMetrics(new[] { "AAPL" }, CancelledToken()));

        [Test]
        public void GetHistoricDividends_HonoursCancellation()
            => AssertCancels(() => NewClient().GetHistoricDividends("AAPL", CancelledToken()));

        [Test]
        public void GetHistoricEarnings_HonoursCancellation()
            => AssertCancels(() =>
                NewClient().GetHistoricEarnings("AAPL", new DateTime(2024, 1, 1), null, CancelledToken()));

        [Test]
        public void GetMarginRequirementsPublicConfiguration_HonoursCancellation()
            => AssertCancels(() => NewClient().GetMarginRequirementsPublicConfiguration(CancelledToken()));

        [Test]
        public void GetMarketData_HonoursCancellation()
            => AssertCancels(() =>
                NewClient().GetMarketData(null, new[] { "AAPL" }, null, null, null, null, CancelledToken()));

        // ---- Orders ---------------------------------------------------------

        [Test]
        public void PostOrderSubmission_HonoursCancellation()
            => AssertCancels(() => NewClient().PostOrderSubmission("ACC", new PlaceOrderRequest(), CancelledToken()));

        [Test]
        public void GetOrders_HonoursCancellation()
            => AssertCancels(() => NewClient().GetOrders("ACC", cancellationToken: CancelledToken()));

        [Test]
        public void GetLiveOrders_HonoursCancellation()
            => AssertCancels(() => NewClient().GetLiveOrders("ACC", cancellationToken: CancelledToken()));

        [Test]
        public void GetOrder_HonoursCancellation()
            => AssertCancels(() => NewClient().GetOrder("ACC", 123L, CancelledToken()));

        [Test]
        public void CancelOrder_HonoursCancellation()
            => AssertCancels(() => NewClient().CancelOrder("ACC", 123L, CancelledToken()));

        [Test]
        public void ReplaceOrder_HonoursCancellation()
            => AssertCancels(() => NewClient().ReplaceOrder("ACC", 123L, new PlaceOrderRequest(), CancelledToken()));

        [Test]
        public void DryRunOrder_HonoursCancellation()
            => AssertCancels(() => NewClient().DryRunOrder("ACC", new PlaceOrderRequest(), CancelledToken()));
    }
}
