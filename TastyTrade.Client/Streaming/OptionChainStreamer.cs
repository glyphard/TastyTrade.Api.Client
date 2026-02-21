using System;
using System.Threading.Tasks;
using DxFeed.Graal.Net.Api;
using DxFeed.Graal.Net.Events.Market;
using TastyTrade.Client.Model.Helper;
using TastyTrade.Client.Model.Request;

namespace TastyTrade.Client.Streaming;

public static class OptionChainStreamer
{
    
    public static async Task Run(TastyOAuthCredentials credentials, string symbol, DateTime onOrAfter)
    {
        var optChain = await BeingStreamingOptionChain(credentials, symbol, onOrAfter, TimeSpan.Zero);
    }
    
    public static async Task<OptionChain> BeingStreamingOptionChain(TastyOAuthCredentials credentials, string symbol, DateTime onOrAfter, TimeSpan until)
    {
        return await BeingStreamingOptionChain(credentials, symbol, onOrAfter, until, new NoOpGreeksProvider());
    }
    public static async Task<OptionChain> BeingStreamingOptionChain(TastyOAuthCredentials credentials, string symbol, DateTime onOrAfter, TimeSpan until, IOptionGreekProvider greeksProvider)
    {
        var tastyTradeClient = new TastyTradeClient();
        await tastyTradeClient.Authenticate(credentials);

        var underlying = await tastyTradeClient.GetEquity(symbol);
        var optionChainsResponse = await tastyTradeClient.GetOptionChains(symbol);

        // Always return an OptionChain instance (never null). If we don't have option chain data,
        // we'll return an OptionChain with empty Expirations/AllExpirations and populated underlying if available.
        OptionChain _optionChain;
        if (underlying?.Data == null)
        {
            Console.WriteLine($"No underlying data returned for symbol '{symbol}'. Returning empty OptionChain.");
            _optionChain = new OptionChain(); // empty collections
        }
        else if (optionChainsResponse?.Data == null)
        {
            Console.WriteLine($"No option chain data returned for symbol '{symbol}'. Returning OptionChain with underlying and empty expirations.");
            _optionChain = new OptionChain
            {
                Underlying = new OptionChainUnderlying
                {
                    Symbol = underlying.Data.Symbol,
                    StreamerSymbol = underlying.Data.StreamerSymbol
                },
                PreviousUnderlying = new OptionChainUnderlying
                {
                    Symbol = underlying.Data.Symbol,
                    StreamerSymbol = underlying.Data.StreamerSymbol
                }
            };
        }
        else
        {
            _optionChain = new OptionChain(underlying, optionChainsResponse, greeksProvider);
        }

        // Only attempt to select an expiration if we have expirations available
        if (_optionChain.Expirations != null && _optionChain.Expirations.Count > 0)
        {
            _optionChain.SelectNextExpiration(onOrAfter, TimeSpan.Zero);
        }

        var apiQuoteTokens = await tastyTradeClient.GetApiQuoteTokens();
        if (apiQuoteTokens?.Data == null)
        {
            Console.WriteLine("Failed to acquire API quote tokens. Returning OptionChain (streaming not started).");
            return _optionChain;
        }

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

        if (!string.IsNullOrEmpty(_optionChain.Underlying?.StreamerSymbol))
        {
            quotes.AddSymbols(_optionChain.Underlying.StreamerSymbol);
        }

        var firstExpiration = (_optionChain.Expirations != null && _optionChain.Expirations.Count > 0) ? _optionChain.Expirations[0] : null;
        if (firstExpiration?.Items != null)
        {
            foreach (var expiration in firstExpiration.Items)
            {
                if (expiration?.Call?.StreamerSymbol != null)
                {
                    quotes.AddSymbols(expiration.Call.StreamerSymbol);
                }
                if (expiration?.Put?.StreamerSymbol != null)
                {
                    quotes.AddSymbols(expiration.Put.StreamerSymbol);
                }
            }
        }
        else
        {
            Console.WriteLine($"No option items found for first expiration of '{symbol}'. Subscribed only to underlying (if available).");
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
