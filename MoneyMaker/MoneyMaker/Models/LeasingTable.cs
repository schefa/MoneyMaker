using System.Collections.Generic;

namespace MoneyMaker.Models
{
    /// <summary>
    /// The basic class for every leasing table within the program.
    /// </summary>
    public class LeasingTable
    {
        public List<LeasingTableRow> leasingRowList;
        public int[] months;
        public double rate;
        public double[] rateSums;
        public double[] capitalLosses;
        public double[] recoveryValues;
    }
}
