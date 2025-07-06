using System;
using System.Threading.Tasks;
using DxFeed.Graal.Net.Api;
using DxFeed.Graal.Net.Events.Market;
using TastyTrade.Client.Model.Helper;
using TastyTrade.Client.Model.Request;

namespace TastyTrade.Client.Streaming;

public static class OptionChainStreamer
{
    
    public static async Task Run(AuthorizationCredentials credentials, string symbol, DateTime onOrAfter)
    {
        var optChain = await BeingStreamingOptionChain(credentials, symbol, onOrAfter, TimeSpan.Zero);
    }
    
    public static async Task<OptionChain> BeingStreamingOptionChain(AuthorizationCredentials credentials, string symbol, DateTime onOrAfter, TimeSpan until, IOptionGreekProvider greeksProvider)
    {
        return await BeingStreamingOptionChain(credentials, symbol, onOrAfter, until, new NoOpGreeksProvider());
    }
    public static async Task<OptionChain> BeingStreamingOptionChain(AuthorizationCredentials credentials, string symbol, DateTime onOrAfter, TimeSpan until, IOptionGreekProvider greeksProvider)
    {
        var tastyTradeClient = new TastyTradeClient();
        await tastyTradeClient.Authenticate(credentials);

        var underlying = await tastyTradeClient.GetEquity(symbol);
        var optionChainsResponse = await tastyTradeClient.GetOptionChains(symbol);
        OptionChain _optionChain = new OptionChain(underlying, optionChainsResponse, greeksProvider);
        
        _optionChain.SelectNextExpiration(onOrAfter, TimeSpan.Zero);

        var apiQuoteTokens = await tastyTradeClient.GetApiQuoteTokens();
        var address = $"dxlink:{apiQuoteTokens.Data.DxlinkUrl}[login=dxlink:{apiQuoteTokens.Data.Token}]";
        var feed = DXEndpoint.GetInstance().Connect(address).GetFeed();
        var quotes = feed.CreateSubscription(typeof(Quote));

        quotes.AddEventListener(events =>
        {
            foreach (var ev in events)
            {
                if (ev is Quote quote)
                {
                    _optionChain.UpdateQuote(quote);
                }
                else {
                    Console.WriteLine($"{ev.GetType().FullName} is not a {nameof(Quote)}");
                }
            }
        });
        quotes.AddSymbols(_optionChain.Underlying.StreamerSymbol);

        foreach (var expiration in _optionChain.Expirations[0].Items)
        {
            quotes.AddSymbols(expiration.Call.StreamerSymbol);
            quotes.AddSymbols(expiration.Put.StreamerSymbol);
        }
        return _optionChain;
    }
}

public class NoOpGreeksProvider : IOptionGreekProvider
{
    public Greeks GetGreeks(OptionType optionType, decimal underlyingPrice, decimal optionMarketPrice, decimal strike, decimal timeToExpiryCalendarDays, decimal interestRates, decimal dividends)
    {
        return new Greeks() { Delta = decimal.Zero, Theta = decimal.Zero, Vega = decimal.Zero, ImpliedVolatility = decimal.Zero };
    }
}
