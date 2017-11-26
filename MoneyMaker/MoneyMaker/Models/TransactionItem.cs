using MoneyMaker.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MoneyMaker.Models
{
    public class TransactionItem : Transactions
    {

        public enum TransactionTypeEnum
        {
            Charge,
            Purchase,
            Sales,
            TakeOff,
            XTax,
            YTaxCredit,
        }

        public string transactionTypeToFullString()
        {
            string result = "";
            switch (TransactionType)
            {
                case 't': result = "Abhebung"; break;
                case 'p': result = "Kauf"; break;
                case 'c': result = "Einzahlung"; break;
                case 's': result = "Verkauf"; break;
                case 'x': result = "Kapitalsteuer"; break;
                case 'y': result = "Steuergutschrift"; break;
            }
            return result;
        }

        public string[] toArray()
        {
            decimal? income = 0;
            decimal? outcome = 0;
            switch (TransactionType)
            {
                case 't': case 'p': case 'x': outcome = Amount; break;
                case 'c': case 's': case 'y': income = Amount; break;
            }

            return new string[]
            {
                Created.ToString(),
                Description,
                ((double)income).ToString("0.00"),
                ((double)outcome).ToString("0.00"),
                transactionTypeToFullString(),
            };
        }
    }
}
