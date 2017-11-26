using System.Collections.Generic;

namespace MoneyMaker.Models
{
    /// <summary>
    /// The basic class for every redemption table within the program.
    /// </summary>
    public class RedemptionTable
    {
        public List<RedemptionTableRow> redemptionRowList;
        public int[] months;
        public double[] beforeMonths;
        public double[] interests;
        public double[] clearances;
        public double[] afterMonths;
        public double[] payments;
        public double rate;
    }
}
