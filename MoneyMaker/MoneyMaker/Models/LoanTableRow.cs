namespace MoneyMaker.Models
{
    /// <summary>
    /// The basic class for every single loan table row within a loan table.
    /// </summary>
    public class LoanTableRow
    {
        public int month;
        public double beforeMonth, rate, interest, clearance, afterMonth;

        /// <summary>
        /// Changes every value into a string and returns a string array.
        /// </summary>
        /// <returns>Returns content as a string array.</returns>
        public string[] ToStringArray()
        {
            return new string[] {
                    month.ToString(),
                    beforeMonth.ToString(),
                    rate.ToString(),
                    interest.ToString(),
                    clearance.ToString(),
                    afterMonth.ToString()
                };
        }
    }
}
