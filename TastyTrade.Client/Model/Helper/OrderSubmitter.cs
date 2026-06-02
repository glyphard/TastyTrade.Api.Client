using System.Threading.Tasks;
using TastyTrade.Client.Model.Request;
using TastyTrade.Client.Model.Response;

namespace TastyTrade.Client.Model.Helper
{
    /// <summary>
    /// Provides order submitter functionality.
    /// </summary>
    public static class OrderSubmitter
    {
        /// <summary>
        /// Executes the run operation.
        /// </summary>
        public static async Task<PlacedOrderResponse> Run(TastyOAuthCredentials credentials, string accountNumber, PlaceOrderRequest orderSubmission)
        {
            var tastyTradeClient = new TastyTradeClient();
            await tastyTradeClient.Authenticate(credentials);
            return await tastyTradeClient.PostOrderSubmission(accountNumber, orderSubmission);
        }
    }
}