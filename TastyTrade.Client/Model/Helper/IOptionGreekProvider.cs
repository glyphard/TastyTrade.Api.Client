namespace TastyTrade.Client.Model.Helper
{
    /// <summary>
    /// Defines the i option greek provider contract.
    /// </summary>
    public interface IOptionGreekProvider
    {

        /// <summary>
        /// Gets greeks.
        /// </summary>
        public Greeks GetGreeks(OptionType optionType, decimal underlyingPrice, decimal optionMarketPrice, decimal strike, decimal timeToExpiryCalendarDays, decimal interestRates, decimal dividends);
    }
    /// <summary>
    /// Defines option type values.
    /// </summary>
    public enum OptionType{ 
        /// <summary>
        /// Represents call.
        /// </summary>
        Call = 0,
        /// <summary>
        /// Represents put.
        /// </summary>
        Put  = 1
    }

    /// <summary>
    /// Represents the greeks.
    /// </summary>
    public class Greeks { 
    
        /// <summary>
        /// Gets or sets the delta.
        /// </summary>
        public decimal Delta { get; set; }
        /// <summary>
        /// Gets or sets the gamma.
        /// </summary>
        public decimal Gamma { get; set; }

        /// <summary>
        /// Gets or sets the theta.
        /// </summary>
        public decimal Theta {  get; set; }
        /// <summary>
        /// Gets or sets the theta per day.
        /// </summary>
        public decimal ThetaPerDay { get; set; }
        /// <summary>
        /// Gets or sets the vega.
        /// </summary>
        public decimal Vega { get; set; }
        /// <summary>
        /// Gets or sets the implied volatility.
        /// </summary>
        public decimal? ImpliedVolatility { get; set; }
    
    }
}