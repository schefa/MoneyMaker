using System.Collections.Generic;

namespace MoneyMaker.Models
{
    /// <summary>
    /// The basic class for every loan table within the program.
    /// </summary>
    public class LoanTable
    {
        public List<LoanTableRow> loanRowList;
        public int[] months;
        public double[] beforeMonths;
        public double[] interests;
        public double[] clearances;
        public double[] afterMonths;
        public double rate;
    }
}
