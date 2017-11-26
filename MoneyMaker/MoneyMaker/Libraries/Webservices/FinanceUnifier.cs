using System;
using System.Collections.Generic;
using System.Linq;
using MoneyMaker.Models;
using MoneyMaker.Libraries.Webservices.Entities;

namespace MoneyMaker.Libraries.Webservices
{
    /// <summary>
    /// Methods to unify the different APIs
    /// @author : Fjodor Schäfer
    /// </summary>
    public static class FinanceUnifier
    {

        // http://finance.yahoo.com/exchanges?bypass=true
        // https://www.google.com/googlefinance/disclaimer/

        /// <summary>
        /// Hard-coded list of unchanging data ( exchanges ). Higher performance compared to database
        /// </summary>
        private static List<ExchangeCode> exchanges = new List<ExchangeCode>()
        {
            new ExchangeCode { Region = "US", Title = "American Stock Exchange", YahooExch = "", YahooSuffix = "", GoogleExch = "NYSEMKT", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "US", Title = "Chicago Board of Trade", YahooExch = "CBT", YahooSuffix = "CBT", GoogleExch = "INDEXCBOE", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "US", Title = "Chicago Mercantile Exchange", YahooExch = "CME", YahooSuffix = "CME", GoogleExch = "INDEXCME", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "US", Title = "Dow Jones Indexes", YahooExch = "DJI", YahooSuffix = "", GoogleExch = "INDEXDJX", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "US", Title = "NASDAQ Stock Exchange", YahooExch = "NAS", YahooSuffix = "", GoogleExch = "NASDAQ", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "US", Title = "New York Board of Trade", YahooExch = "", YahooSuffix = "NYB", GoogleExch = "", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "US", Title = "New York Mercantile Exchange", YahooExch = "CMX", YahooSuffix = "NYM", GoogleExch = "NYSEMKT", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "US", Title = "New York Stock Exchange", YahooExch = "NYQ", YahooSuffix = "", GoogleExch = "NYSE", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "US", Title = "OTC Bulletin Board Market", YahooExch = "OBB", YahooSuffix = "OB", GoogleExch = "OTCBB", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "US", Title = "S & P Indices", YahooExch = "", YahooSuffix = "", GoogleExch = "INDEXDJX", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "Argentina", Title = "Buenos Aires Stock Exchange", YahooExch = "BUE", YahooSuffix = "BA", GoogleExch = "BCBA", Currency = Currency.CurrencyCode.ARS },
            new ExchangeCode { Region = "Austria", Title = "Vienna Stock Exchange", YahooExch = "VIE", YahooSuffix = "VI", GoogleExch = "VIE", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "Australia", Title = "Australian Stock Exchange", YahooExch = "ASX", YahooSuffix = "AX", GoogleExch = "ASX", Currency = Currency.CurrencyCode.AUD },
            new ExchangeCode { Region = "Brazil", Title = "BOVESPA - Sao Paolo Stock Exchange", YahooExch = "SAO", YahooSuffix = "SA", GoogleExch = "", Currency = Currency.CurrencyCode.BRL },
            new ExchangeCode { Region = "Canada", Title = "Toronto Stock Exchange", YahooExch = "TOR", YahooSuffix = "TO", GoogleExch = "TSE", Currency = Currency.CurrencyCode.CAD },
            new ExchangeCode { Region = "Canada", Title = "TSX Venture Exchange", YahooExch = "", YahooSuffix = "V", GoogleExch = "CVE", Currency = Currency.CurrencyCode.CAD },
            new ExchangeCode { Region = "Chile", Title = "Santiago Stock Exchange", YahooExch = "SGO", YahooSuffix = "SN", GoogleExch = "", Currency = Currency.CurrencyCode.CLP },
            new ExchangeCode { Region = "China", Title = "Shanghai Stock Exchange", YahooExch = "SHH", YahooSuffix = "SS", GoogleExch = "SHA", Currency = Currency.CurrencyCode.CNY },
            new ExchangeCode { Region = "China", Title = "Shenzhen Stock Exchange", YahooExch = "SHZ", YahooSuffix = "SZ", GoogleExch = "SHE", Currency = Currency.CurrencyCode.CNY },
            new ExchangeCode { Region = "Denmark", Title = "Copenhagen Stock Exchange", YahooExch = "CPH", YahooSuffix = "CO", GoogleExch = "CPH", Currency = Currency.CurrencyCode.DKK },
            new ExchangeCode { Region = "France", Title = "Euronext", YahooExch = "ENX", YahooSuffix = "NX", GoogleExch = "EPA", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "France", Title = "Paris Stock Exchange", YahooExch = "PAR", YahooSuffix = "PA", GoogleExch = "EPA", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Germany", Title = "Berlin Stock Exchange", YahooExch = "BER", YahooSuffix = "BE", GoogleExch = "ETR", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Germany", Title = "Dusseldorf Stock Exchange", YahooExch = "DUS", YahooSuffix = "DU", GoogleExch = "ETR", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Germany", Title = "Frankfurt Stock Exchange", YahooExch = "FRA", YahooSuffix = "F", GoogleExch = "FRA", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Germany", Title = "Hamburg Stock Exchange", YahooExch = "HAM", YahooSuffix = "HM", GoogleExch = "ETR", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Germany", Title = "Munich Stock Exchange", YahooExch = "MUN", YahooSuffix = "MU", GoogleExch = "ETR", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Germany", Title = "Stuttgart Stock Exchange", YahooExch = "STU", YahooSuffix = "SG", GoogleExch = "ETR", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Germany", Title = "XETRA Stock Exchange", YahooExch = "GER", YahooSuffix = "DE", GoogleExch = "ETR", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Hong Kong", Title = "Hong Kong Stock Exchange", YahooExch = "HKG", YahooSuffix = "HK", GoogleExch = "HKG", Currency = Currency.CurrencyCode.HKD },
            new ExchangeCode { Region = "India", Title = "Bombay Stock Exchange", YahooExch = "BSE", YahooSuffix = "BO", GoogleExch = "BOM", Currency = Currency.CurrencyCode.INR },
            new ExchangeCode { Region = "India", Title = "National Stock Exchange of India", YahooExch = "NSI", YahooSuffix = "NS", GoogleExch = "NSE", Currency = Currency.CurrencyCode.INR },
            new ExchangeCode { Region = "Indonesia", Title = "Jakarta Stock Exchange", YahooExch = "JKT", YahooSuffix = "JK", GoogleExch = "IDX", Currency = Currency.CurrencyCode.IDR },
            new ExchangeCode { Region = "Israel", Title = "Tel Aviv Stock Exchange", YahooExch = "TLV", YahooSuffix = "TA", GoogleExch = "TLV", Currency = Currency.CurrencyCode.ILS },
            new ExchangeCode { Region = "Italy", Title = "Milan Stock Exchange", YahooExch = "MIL", YahooSuffix = "MI", GoogleExch = "BIT", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Japan", Title = "Nikkei Indices", YahooExch = "OSA", YahooSuffix = "", GoogleExch = "INDEXNIKKEI", Currency = Currency.CurrencyCode.USD },
            new ExchangeCode { Region = "Mexico", Title = "Mexico Stock Exchange", YahooExch = "MEX", YahooSuffix = "MX", GoogleExch = "BMV", Currency = Currency.CurrencyCode.MXN },
            new ExchangeCode { Region = "Netherlands", Title = "Amsterdam Stock Exchange", YahooExch = "AMS", YahooSuffix = "AS", GoogleExch = "AMS", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "New Zealand", Title = "New Zealand Stock Exchange", YahooExch = "NZE", YahooSuffix = "NZ", GoogleExch = "NZE", Currency = Currency.CurrencyCode.NZD },
            new ExchangeCode { Region = "Norway", Title = "Oslo Stock Exchange", YahooExch = "OSL", YahooSuffix = "OL", GoogleExch = "", Currency = Currency.CurrencyCode.NOK },
            new ExchangeCode { Region = "Russia", Title = "Moscow Exchange", YahooExch = "MCX", YahooSuffix = "ME", GoogleExch = "MCX", Currency = Currency.CurrencyCode.RUB },
            new ExchangeCode { Region = "Singapore", Title = "Singapore Stock Exchange", YahooExch = "SES", YahooSuffix = "SI", GoogleExch = "SGX", Currency = Currency.CurrencyCode.SGD },
            new ExchangeCode { Region = "South Korea", Title = "Korea Stock Exchange", YahooExch = "KSC", YahooSuffix = "KS", GoogleExch = "KRX", Currency = Currency.CurrencyCode.KRW },
            new ExchangeCode { Region = "South Korea", Title = "KOSDAQ", YahooExch = "KOE", YahooSuffix = "KQ", GoogleExch = "KOSDAQ", Currency = Currency.CurrencyCode.KRW },
            new ExchangeCode { Region = "Spain", Title = "Barcelona Stock Exchange", YahooExch = "BAR", YahooSuffix = "BC", GoogleExch = "BME", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Spain", Title = "Bilbao Stock Exchange", YahooExch = "BIL", YahooSuffix = "BI", GoogleExch = "BME", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Spain", Title = "Madrid Fixed Income Market", YahooExch = "", YahooSuffix = "MF", GoogleExch = "BME", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Spain", Title = "Madrid SE C.A.T.S.", YahooExch = "MCE", YahooSuffix = "MC", GoogleExch = "BME", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Spain", Title = "Madrid Stock Exchange", YahooExch = "MSE", YahooSuffix = "MA", GoogleExch = "BME", Currency = Currency.CurrencyCode.EUR },
            new ExchangeCode { Region = "Sweden", Title = "Stockholm Stock Exchange", YahooExch = "STO", YahooSuffix = "ST", GoogleExch = "STO", Currency = Currency.CurrencyCode.SEK },
            new ExchangeCode { Region = "Switzerland", Title = "Swiss Exchange", YahooExch = "EBS", YahooSuffix = "SW", GoogleExch = "SWX", Currency = Currency.CurrencyCode.CHF },
            new ExchangeCode { Region = "Taiwan", Title = "Taipei Exchange", YahooExch = "TWO", YahooSuffix = "TWO", GoogleExch = "TPE", Currency = Currency.CurrencyCode.TWD },
            new ExchangeCode { Region = "Taiwan", Title = "Taiwan Stock Exchange", YahooExch = "TAI", YahooSuffix = "TW", GoogleExch = "TPE", Currency = Currency.CurrencyCode.TWD },
            new ExchangeCode { Region = "United Kingdom", Title = "FTSE Indices", YahooExch = "FGI", YahooSuffix = "", GoogleExch = "INDEXFTSE", Currency = Currency.CurrencyCode.GBP },
            new ExchangeCode { Region = "United Kingdom", Title = "London Stock Exchange", YahooExch = "LSE", YahooSuffix = "L", GoogleExch = "LON", Currency = Currency.CurrencyCode.GBP },    
        };

        /// <summary>
        /// Hard-coded list of unchanging data ( currencies ). Higher performance compared to database
        /// </summary>
        private static List<Currency> currencies = new List<Currency>() {
            new Currency() { ShortCode = Currency.CurrencyCode.ARS, Name = "Argentina Peso", Symbol = "$" },
            new Currency() { ShortCode = Currency.CurrencyCode.AUD, Name = "Australia Dollar", Symbol = "$" },
            new Currency() { ShortCode = Currency.CurrencyCode.BRL, Name = "Brazil Real", Symbol = "R$" },
            new Currency() { ShortCode = Currency.CurrencyCode.CAD, Name = "Canada Dollar", Symbol = "$" },
            new Currency() { ShortCode = Currency.CurrencyCode.CHF, Name = "Switzerland Franc", Symbol = "CHF" },
            new Currency() { ShortCode = Currency.CurrencyCode.CLP, Name = "Chile Peso", Symbol = "$" },
            new Currency() { ShortCode = Currency.CurrencyCode.CNY, Name = "China Yuan Renminbi", Symbol = "¥" },
            new Currency() { ShortCode = Currency.CurrencyCode.DKK, Name = "Denmark Krone", Symbol = "kr" },
            new Currency() { ShortCode = Currency.CurrencyCode.EUR, Name = "Euro", Symbol = "€" },
            new Currency() { ShortCode = Currency.CurrencyCode.GBP, Name = "United Kingdom Pound", Symbol = "£" },
            new Currency() { ShortCode = Currency.CurrencyCode.HKD, Name = "Hong Kong Dollar", Symbol = "HK$" },
            new Currency() { ShortCode = Currency.CurrencyCode.IDR, Name = "Indonesia Rupiah", Symbol = "Rp" },
            new Currency() { ShortCode = Currency.CurrencyCode.ILS, Name = "Israel Shekel", Symbol = "ILS" },
            new Currency() { ShortCode = Currency.CurrencyCode.INR, Name = "India Rupee", Symbol = "R" },
            new Currency() { ShortCode = Currency.CurrencyCode.JPY, Name = "Japan Yen", Symbol = "¥" },
            new Currency() { ShortCode = Currency.CurrencyCode.KRW, Name = "Korea (South) Won", Symbol = "Won" },
            new Currency() { ShortCode = Currency.CurrencyCode.MXN, Name = "Mexico Peso", Symbol = "$" },
            new Currency() { ShortCode = Currency.CurrencyCode.NOK, Name = "Norway Krone", Symbol = "kr" },
            new Currency() { ShortCode = Currency.CurrencyCode.NZD, Name = "New Zealand Dollar", Symbol = "$" },
            new Currency() { ShortCode = Currency.CurrencyCode.RUB, Name = "Russia Ruble", Symbol = "p" },
            new Currency() { ShortCode = Currency.CurrencyCode.SEK, Name = "Sweden Krona", Symbol = "kr" },
            new Currency() { ShortCode = Currency.CurrencyCode.SGD, Name = "Singapore Dollar", Symbol = "$" },
            new Currency() { ShortCode = Currency.CurrencyCode.TRY, Name = "Turkey Lira", Symbol = "TRY" },
            new Currency() { ShortCode = Currency.CurrencyCode.TWD, Name = "Taiwan New Dollar", Symbol = "NT$" },
            new Currency() { ShortCode = Currency.CurrencyCode.USD, Name = "United States Dollar", Symbol = "$" }
        };

        public static List<Currency> Currencies
        {
            get { return currencies; }
        }

        #region Currency methods

        public static string getCurrencySymbolByEnum(Currency.CurrencyCode defaultCurrency)
        {
            Currency currency = currencies.FirstOrDefault(x => x.ShortCode == defaultCurrency);
            return (currency != null) ? currency.Symbol : null;
        }

        public static Currency getCurrencyBySymbol(string symbol)
        {
            var currency = currencies[currencies.Count-1];
            var exchange = makeExchangeOutOfSymbol(symbol, FinanceAPI.FinanceStrategies.Yahoo);
            ExchangeCode exch = exchanges.FirstOrDefault(x => x.YahooExch == exchange);

            if (exch != null)
            {
                currency = currencies.FirstOrDefault(x => x.ShortCode == exch.Currency);
            }

            return currency;
        }

        public static Currency getCurrencyByExchangeCode(string exchShortCut)
        {
            ExchangeCode exch = exchanges.FirstOrDefault(x => x.YahooExch == exchShortCut);
            
            var currency = new Currency();
            if (exch != null)
            {
                currency = currencies.FirstOrDefault(x => x.ShortCode == exch.Currency);
            }
            return currency;
        }

        public static Currency.CurrencyCode getCurrencyCodeByExchange(string exchShortCut)
        {
            ExchangeCode exch = exchanges.FirstOrDefault(x => x.YahooExch == exchShortCut);
            return (exch != null) ? exch.Currency : Currency.CurrencyCode.EUR;
        }

        #endregion

        #region Exchanges methods

        /// <summary>
        /// Searches the exchanges list for short code and returns full name
        /// </summary>
        public static string getExchangeFullTitle(string exchShortCut)
        {
            ExchangeCode exch = exchanges.FirstOrDefault(x => x.YahooExch == exchShortCut);
            return (exch != null && exch.Title.Length > 0) ? exch.Title : exchShortCut;
        }
        
        /// <summary>
        /// Transfrom the symbol used by Yahoo into the one of Google
        /// </summary> 
        public static string transformSymbolToGoogle(string symbol)
        {
            string result = null;
            if (symbol != null)
            {
                string[] tmp = symbol.Split('.');
                result = (!String.IsNullOrEmpty(tmp[0])) ? tmp[0] : null;
            }
            return result;
        }

        /// <summary>
        /// Google uses a different code for exchanges than the standard (Bloomberg, Yahoo, etc)
        /// </summary>
        /// <returns>Exchange code as string</returns>
        public static string transformExchangeToGoogle(string symbol, string exchange = null)
        {
            string result = null;
            if(!String.IsNullOrEmpty(exchange))
            {
                ExchangeCode exch = exchanges.FirstOrDefault(x => x.YahooExch == exchange);
                result = (exch != null) ? exch.GoogleExch : makeExchangeOutOfSymbol(symbol, FinanceAPI.FinanceStrategies.Google);
            }
            else
            {
                result = makeExchangeOutOfSymbol(symbol, FinanceAPI.FinanceStrategies.Google);
            }
            return result;
        }

        private static string makeExchangeOutOfSymbol(string symbol, FinanceAPI.FinanceStrategies strategy )
        {
            string result = null;
            if(symbol != null)
            {
                string[] tmp = symbol.Split('.');
                if(tmp.Length > 1)
                {
                    ExchangeCode exch = exchanges.FirstOrDefault(x => x.YahooSuffix == tmp[1]);
                    if (exch != null)
                    {
                        switch (strategy)
                        {
                            case FinanceAPI.FinanceStrategies.Google:
                                result = exch.GoogleExch;
                                break;
                            case FinanceAPI.FinanceStrategies.Yahoo:
                                result = exch.YahooExch;
                                break;
                        }
                    }
                }
            }
            return result;
        }

        #endregion

    }
}
