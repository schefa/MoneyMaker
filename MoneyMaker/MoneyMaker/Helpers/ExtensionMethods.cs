using MoneyMaker.Libraries.Webservices.Entities;
using MoneyMaker.Models;

namespace MoneyMaker.Helpers
{
    /// <summary>
    /// Extension methods to convert the prices into readable values
    /// </summary>
    public static class ExtensionMethods
    {
        public static string toPriceFormat(this SingleQuote quote, decimal value)
        {
            return ((double)value).ToString("0.00") + " " + quote.Currency.Symbol;
        }

        public static string toPriceFormat(this SingleQuote quote, decimal? value)
        {
            if(value != null)
            {
                return ((double)value).ToString("0.00") + " " + quote.Currency.Symbol;
            }
            else
            {
                return "0.00" + quote.Currency.Symbol;
            }
        }

        public static string toPriceFormat(this SingleQuote quote, double value)
        {
            return value.ToString("0.00") + " " + quote.Currency.Symbol;
        }

        public static string toPriceFormat(this StockListitem quote, decimal value)
        {
            return ((double)value).ToString("0.00") + " " + quote.Currency.Symbol;
        }
        
        public static string toPriceFormat(this StockListitem quote, decimal? value)
        {
            if (value != null)
            {
                return ((double)value).ToString("0.00") + " " + quote.Currency.Symbol;
            }
            else
            {
                return "0.00" + quote.Currency.Symbol;
            }
        }

        public static string toPriceFormat(this StockListitem quote, double value)
        {
            return value.ToString("0.00") + " " + quote.Currency.Symbol;
        }
    }
}