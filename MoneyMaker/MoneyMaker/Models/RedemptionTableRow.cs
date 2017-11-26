namespace MoneyMaker.Models
{
    /// <summary>
    /// The basic class for every single redemption table row within a redemption table.
    /// </summary>
    public class RedemptionTableRow
    {
        public int month;
        public double beforeMonth, payment, interest, clearance, afterMonth;

        /// <summary>
        /// Changes every value into a string and returns a string array.
        /// </summary>
        /// <returns>Returns content as a string array.</returns>
        public string[] ToStringArray()
        {
            return new string[] {
                    month.ToString(),
                    beforeMonth.ToString(),
                    payment.ToString(),
                    interest.ToString(),
                    clearance.ToString(),
                    afterMonth.ToString()
                };
        }
    }
}
