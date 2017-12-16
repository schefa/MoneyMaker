using MoneyMaker.Libraries.Webservices.Entities;
using System.Collections.Generic;

namespace MoneyMaker.Libraries.Webservices
{
    /// <summary>
    /// Interface to unify the data from the different finance services
    /// @author : Fjodor Schäfer
    /// </summary>
    interface IFinanceDataTransformer
    {
        SingleQuote createSingleQuoteFromString(string data);
        CurrencyRate createCurrencyRateFromString(string data);
        List<HistoricalQuote> createHistoricalQuotesFromString(string data);
        List<CurrencyRate> createCurrencyRatesFromString(string data);
    }
}
