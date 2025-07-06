namespace TastyTrade.Client.Model.Helper
{
    public interface IOptionGreekProvider
    {

        public Greeks GetGreeks(OptionType optionType, decimal underlyingPrice, decimal optionMarketPrice, decimal strike, decimal timeToExpiryCalendarDays, decimal interestRates, decimal dividends);
    }
    public enum OptionType{ 
        Call = 0,
        Put  = 1
    }

    public class Greeks { 
    
        public decimal Delta { get; set; }
        public decimal Gamma { get; set; }

        public decimal Theta {  get; set; }
        public decimal ThetaPerDay { get; set; }
        public decimal Vega { get; set; }
        public decimal ImpliedVolatility { get; set; }
    
    }
}