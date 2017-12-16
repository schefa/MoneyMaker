using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyMaker.Models
{
    public class Currency
    {

        private CurrencyCode shortCode;
        public CurrencyCode ShortCode
        {
            get { return shortCode; }
            set { shortCode = value; }
        }

        private string symbol;
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public static List<CurrencyCode> getCurrenciesList()
        {
            return Enum.GetValues(typeof(CurrencyCode)).Cast<CurrencyCode>().ToList();
        }

        public enum CurrencyCode
        {
            ARS,
            AUD,
            BRL,
            CAD,
            CHF,
            CLP,
            CNY,
            DKK,
            EUR,
            GBP,
            HKD,
            IDR,
            INR,
            ILS,
            JPY,
            KRW,
            MXN,
            NOK,
            NZD,
            RUB,
            SEK,
            SGD,
            TRY,
            TWD,
            USD,
        }
    }
}
