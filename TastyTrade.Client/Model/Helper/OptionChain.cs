using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using DxFeed.Graal.Net.Events.Market;
using TastyTrade.Client.Model.Response;

namespace TastyTrade.Client.Model.Helper;

public class OptionChain
{
    public string UpdatedOn { get; internal set; }
    public List<OptionChainExpiration> Expirations { get; internal set; }
    public List<OptionChainExpiration> AllExpirations { get; set; }
    public OptionChainUnderlying Underlying { get; internal set; }
    public OptionChainUnderlying PreviousUnderlying { get; internal set; }
    private IOptionGreekProvider _greekProvider;

    public OptionChain(EquityResponse underlying, OptionChainResponse response, IOptionGreekProvider greeksProvider)
    {
        _greekProvider = greeksProvider;
        Expirations = [];
        AllExpirations = [];
        Underlying = new OptionChainUnderlying
        {
            Symbol = underlying.Data.Symbol,
            StreamerSymbol = underlying.Data.StreamerSymbol
        };
        PreviousUnderlying = new OptionChainUnderlying
        {
            Symbol = underlying.Data.Symbol,
            StreamerSymbol = underlying.Data.StreamerSymbol
        };
        SetExpirations(response);
    }

    public OptionChain(FutureContractResponse underlying, OptionChainResponse response)
    {
        Expirations = [];
        Underlying = new OptionChainUnderlying
        {
            Symbol = underlying.Contract.Symbol,
            StreamerSymbol = underlying.Contract.StreamerSymbol
        };
        PreviousUnderlying = new OptionChainUnderlying
        {
            Symbol = underlying.Contract.Symbol,
            StreamerSymbol = underlying.Contract.StreamerSymbol
        };
        SetExpirations(response);
    }

    private void SetExpirations(OptionChainResponse response)
    {
        var expirations = response.Data.Items.Where(x => x.Active).GroupBy(x => x.ExpirationDate).OrderBy(x => x.Key);
        foreach (var item in expirations)
        {
            var expiration = new OptionChainExpiration()
            {
                ExpirationDate = item.Key,
                Items = []
            };
            var strikes = item.GroupBy(x => x.StrikePrice).OrderBy(x => x.Key);
            foreach (var strike in strikes)
            {
                expiration.Items.Add(new OptionChainExpirationItem
                {
                    Strike = Convert.ToDecimal( strike.Key ),
                    Call = new OptionChainItemSide
                    {
                        StreamerSymbol = strike.First(x => x.OptionType == "C").StreamerSymbol
                    },
                    Put = new OptionChainItemSide
                    {
                        StreamerSymbol = strike.First(x => x.OptionType == "P").StreamerSymbol
                    }
                });
            }
            Expirations.Add(expiration);
            AllExpirations.Add(expiration);
        }
    }

    public void SelectNextExpiration(DateTime onOrAfter) {
        SelectNextExpiration(onOrAfter, TimeSpan.Zero);
    }
    public void SelectNextExpiration(DateTime onOrAfter, TimeSpan until)
    {
        var nextExpirationDate = GetNextExpirationDate(onOrAfter);
        Expirations = AllExpirations.Where(x => (x.ExpirationDateToDateTime()) >= nextExpirationDate && (x.ExpirationDateToDateTime()) <= nextExpirationDate).ToList();
    }

    private DateTime GetNextExpirationDate(DateTime onOrAfter)
    {
        return Expirations.OrderBy(e=>e.ExpirationDateToDateTime()).FirstOrDefault(x =>
            ((x.ExpirationDateToDateTime()) - onOrAfter).Days > 0)
            .ExpirationDateToDateTime();
    }

    public void UpdateQuote(Quote quote)
    {
        UpdatedOn = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        if (Underlying.Symbol == quote.EventSymbol)
        {
            PreviousUnderlying.Bid = Underlying.Bid;
            PreviousUnderlying.Ask = Underlying.Ask;

            Underlying.Bid = quote.BidPrice;
            Underlying.Ask = quote.AskPrice;
        }
        else
        {
            foreach (var expiration in Expirations)
            {
                var ttm = expiration.ExpirationDateToDateTime() - DateTime.UtcNow; //TODO: not quite right, but very close
                foreach (var item in expiration.Items)
                {
                    var midUnderlyingPrice = Convert.ToDecimal( Underlying.Bid + ((Underlying.Ask - Underlying.Bid) / 2.0d) );
                    var midOptionPrice = Convert.ToDecimal( quote.BidPrice + ((quote.AskPrice - quote.BidPrice) / 2.0d) );

                    if (item.Call.StreamerSymbol == quote.EventSymbol)
                    {
                        if (Convert.ToDecimal(quote.BidPrice) != item.Call.Bid && Underlying.Bid != PreviousUnderlying.Bid)
                            item.Call.Delta = (Convert.ToDecimal(quote.BidPrice) - item.Call.Bid) / (Convert.ToDecimal(Underlying.Bid) - Convert.ToDecimal(PreviousUnderlying.Bid));
                        item.Call.Bid = Convert.ToDecimal(quote.BidPrice);
                        item.Call.Ask = Convert.ToDecimal(quote.AskPrice);

                        var callGreeks = _greekProvider.GetGreeks(OptionType.Call, midUnderlyingPrice, midOptionPrice, item.Strike, ttm.Days, 0.0m, 0.0m);
                        item.Call.Delta = callGreeks.Delta;
                        item.Call.Theta = callGreeks.Theta;
                        item.Call.Vega = callGreeks.Vega;
                        item.Call.ImpliedVolatility = callGreeks.ImpliedVolatility;

                    }
                    else if (item.Put.StreamerSymbol == quote.EventSymbol)
                    {
                        if (Convert.ToDecimal(quote.BidPrice) != item.Put.Bid && Underlying.Bid != PreviousUnderlying.Bid)
                            item.Put.Delta = Convert.ToDecimal( (Convert.ToDecimal(quote.BidPrice) - item.Put.Bid) / (Convert.ToDecimal(Underlying.Bid) - Convert.ToDecimal(PreviousUnderlying.Bid)) );
                        item.Put.Bid = Convert.ToDecimal( quote.BidPrice );
                        item.Put.Ask = Convert.ToDecimal( quote.AskPrice );

                        var putGreeks = _greekProvider.GetGreeks(OptionType.Put, midUnderlyingPrice, midOptionPrice, item.Strike, ttm.Days, 0.0m, 0.0m);
                        item.Put.Delta = putGreeks.Delta;
                        item.Put.Theta = putGreeks.Theta;
                        item.Put.Vega = putGreeks.Vega;
                        item.Put.ImpliedVolatility = putGreeks.ImpliedVolatility;

                    }
                    item.IsAtTheMoney = item.Strike == Convert.ToDecimal( Math.Floor(Underlying.Bid)) ||  item.Strike == Convert.ToDecimal( Math.Floor(Underlying.Ask) );
                }
            }
        }
    }
}

public class OptionChainUnderlying
{
    public string StreamerSymbol { get; internal set; }
    public string Symbol { get; internal set; }
    public double Bid { get; set; }
    public double Ask { get; set; }
}

public class OptionChainExpiration
{
    public string ExpirationDate { get; set; }
    public List<OptionChainExpirationItem> Items { get; set; }
    public DateTime ExpirationDateToDateTime()
    {
        var expirationDtm = DateTime.ParseExact(this.ExpirationDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        return expirationDtm;
    }
}

public class OptionChainExpirationItem
{
    public decimal Strike { get; set; }
    public OptionChainItemSide Call { get; set; }
    public OptionChainItemSide Put { get; set; }
    public bool IsAtTheMoney { get; set; }
}

public class OptionChainItemSide
{
    public string StreamerSymbol { get; set; }
    public decimal Bid { get; internal set; }
    public decimal Ask { get; internal set; }
    public decimal Delta { get; internal set; }
    public decimal Theta { get; internal set; }
    public decimal Vega { get; internal set; }
    public decimal ImpliedVolatility { get; internal set; }
}
