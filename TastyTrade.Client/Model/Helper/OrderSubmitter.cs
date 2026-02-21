using System.Threading.Tasks;
using TastyTrade.Client.Model.Request;
using TastyTrade.Client.Model.Response;

namespace TastyTrade.Client.Model.Helper
{
    public static class OrderSubmitter
    {
        public static async Task<PlacedOrderResponse> Run(TastyOAuthCredentials credentials, string accountNumber, PlaceOrderRequest orderSubmission)
        {
            var tastyTradeClient = new TastyTradeClient();
            await tastyTradeClient.Authenticate(credentials);
            return await tastyTradeClient.PostOrderSubmission(accountNumber, orderSubmission);
        }
    }
}