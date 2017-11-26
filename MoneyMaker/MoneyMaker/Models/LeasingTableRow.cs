namespace MoneyMaker.Models
{
    /// <summary>
    /// The basic class for every single leasing table row within a leasing table.
    /// </summary>
    public class LeasingTableRow
    {
        public int month;
        public double rate, rateSum, capitalLoss, recoveryvalue;

        /// <summary>
        /// Changes every value into a string and returns a string array.
        /// </summary>
        /// <returns>Returns content as a string array.</returns>
        public string[] ToStringArray()
        {
            return new string[] {
                    month.ToString(),
                    rate.ToString(),
                    rateSum.ToString(),
                    capitalLoss.ToString(),
                    recoveryvalue.ToString()
                };
        }
    }
}
