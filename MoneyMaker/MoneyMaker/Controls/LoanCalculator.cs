using System;
using MoneyMaker.Models;

namespace MoneyMaker.Controls
{
    public static class LoanCalculator
    {
        /// <summary>
        /// The function for every calculation with LoanData.
        /// Calls the correct method via switch on data.calculateOption.
        /// </summary>
        /// <param name="data">The data class of the loan which should be calculated.</param>
        /// <returns>Returns the filled LoanData.</returns>
        public static LoanData Calculate(LoanData data)
        {
            LoanData result;
            switch (data.calculateOption)
            {
                case LoanData.CalculateOption.Duration:
                    result = CalculateDuration(data);
                    break;
                case LoanData.CalculateOption.LoanAmount:
                    result = CalculateLoanAmount(data);
                    break;
                case LoanData.CalculateOption.RepaymentRate:
                    result = CalculateRepaymentRate(data);
                    break;
                default:
                    throw new NotImplementedException();
            }
            result = CalculateTotalExpense(result);
            return result;
        }

        /// <summary>
        /// Calculates the total expense of given loan data.
        /// </summary>
        /// <param name="data">The data class of the loan which should be calculated.</param>
        /// <returns>Returns the filled LoanData.</returns>
        private static LoanData CalculateTotalExpense(LoanData data)
        {
            data.totalExpense = data.repaymentRate * data.duration * 12 * GetDurationFactor(data) / GetReversedRateFactor(data);
            return data;
        }

        /// <summary>
        /// Calculates the duration of given loan data.
        /// </summary>
        /// <param name="data">The data class of the loan which should be calculated.</param>
        /// <returns>Returns the filled LoanData.</returns>
        private static LoanData CalculateDuration(LoanData data)
        {
            int factor = GetRateFactor(data);
            double result = Math.Round(Math.Log((data.interestRate / 100 - data.repaymentRate * factor / data.loanAmount) /
                             (-data.repaymentRate * factor / data.loanAmount)) / Math.Log(1 / (1 + data.interestRate / 100 /
                             12)), 3);
            if (data.durationMode == LoanData.DurationMode.Years)
                result /= 12;
            data.duration = result;
            return data;
        }

        /// <summary>
        /// Calculates the loan ammount of given loan data.
        /// </summary>
        /// <param name="data">The data class of the loan which should be calculated.</param>
        /// <returns>Returns the filled LoanData.</returns>
        private static LoanData CalculateLoanAmount(LoanData data)
        {
            data.loanAmount = Math.Round((data.repaymentRate - data.repaymentRate * Math.Pow((data.interestRate / 100 / 12) + 
                              1, data.duration * -GetDurationFactor(data) * GetRateFactor(data))) / (data.interestRate / 100 / 
                              12), 2);
            return data;
        }

        /// <summary>
        /// Calculates the repayment rate of given loan data.
        /// </summary>
        /// <param name="data">The data class of the loan which should be calculated.</param>
        /// <returns>Returns the filled LoanData.</returns>
        private static LoanData CalculateRepaymentRate(LoanData data)
        {
            data.repaymentRate = Math.Round(data.loanAmount * (data.interestRate / 100 / 12) / (1 - Math.Pow((1 +
                                 data.interestRate / 100 / 12), data.duration * -GetDurationFactor(data) * 
                                 GetRateFactor(data))), 2);
            return data;
        }

        /// <summary>
        /// Returns the repayment factor of given loan data.
        /// </summary>
        /// <param name="data">The data class of the loan to get the repayment factor.</param>
        /// <returns>Returns the factor as an int.</returns>
        public static int GetRateFactor(LoanData data)
        {
            switch (data.repaymentRateInterval)
            {
                case LoanData.RepaymentRateInterval.Monthly:
                    return 12;
                case LoanData.RepaymentRateInterval.Quarterly:
                    return 4;
                case LoanData.RepaymentRateInterval.Biannually:
                    return 2;
                case LoanData.RepaymentRateInterval.Annually:
                    return 1;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the reversed repayment factor of given loan data.
        /// </summary>
        /// <param name="data">The data class of the loan to get the reversed repayment factor.</param>
        /// <returns>Returns the factor as an int.</returns>
        public static int GetReversedRateFactor(LoanData data)
        {
            switch (data.repaymentRateInterval)
            {
                case LoanData.RepaymentRateInterval.Monthly:
                    return 1;
                case LoanData.RepaymentRateInterval.Quarterly:
                    return 3;
                case LoanData.RepaymentRateInterval.Biannually:
                    return 6;
                case LoanData.RepaymentRateInterval.Annually:
                    return 12;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the duration factor of given loan data.
        /// </summary>
        /// <param name="data">The data class of the loan to get the duration factor.</param>
        /// <returns>Returns the factor as a double.</returns>
        public static double GetDurationFactor(LoanData data)
        {
            double result;
            switch (data.durationMode)
            {
                case LoanData.DurationMode.Months:
                    result = 1/12.0;
                    break;
                case LoanData.DurationMode.Years:
                    result = 1;
                    break;
                default:
                    throw new NotImplementedException();
            }
            return result;
        }
    }
}
