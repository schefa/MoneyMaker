using System;
using MoneyMaker.Models;

namespace MoneyMaker.Controls
{
    public static class RedemptionCalculator
    {
        /// <summary>
        /// The function for every calculation with RedemptionData.
        /// Calls the correct method via switch on data.calculateOption.
        /// </summary>
        /// <param name="data">The data class of the redemption which should be calculated.</param>
        /// <returns>Returns the filled RedemptionData.</returns>
        public static RedemptionData Calculate(RedemptionData data)
        {
            RedemptionData result;
            switch (data.calculateOption)
            {
                case RedemptionData.CalculateOption.LoanAmount:
                    result = CalculateLoanAmount(data);
                    break;
                case RedemptionData.CalculateOption.RedemptionRate:
                    result = CalculateRedemptionRate(data);
                    break;
                case RedemptionData.CalculateOption.RedemptionDuration:
                    result = CalculateRedemptionDuration(data);
                    break;
                case RedemptionData.CalculateOption.RemainingDebt:
                    result = CalculateRemainingDebt(data);
                    break;
                default:
                    throw new NotImplementedException();
            }
            result = CalculateTotalExpense(result);
            return result;
        }

        /// <summary>
        /// Calculates the total expenses of given redemption data.
        /// </summary>
        /// <param name="data">The data class of the redemption which should be calculated.</param>
        /// <returns>Returns the filled RedemptionData.</returns>
        private static RedemptionData CalculateTotalExpense(RedemptionData data)
        {
            double interestAmount = 0;
            double interestToDo, redemptionToDo;
            double loanAmount = data.loanAmount;
            for (int i = 1; loanAmount > data.remainingDebt; i++)
            {
                interestToDo = i / GetReversedInterestRateFactor(data);
                if ((interestToDo % 1.0) == 0)
                    interestAmount += (data.interestRate / 100) * loanAmount / GetInterestRateFactor(data);
                redemptionToDo = i / GetReversedRedemptionRateFactor(data);
                if ((redemptionToDo % 1.0) == 0)
                    loanAmount -= data.redemptionRate;
            }
            data.totalExpense = data.loanAmount + interestAmount;
            return data;
        }

        /// <summary>
        /// Calculates the loan ammount of given redemption data.
        /// </summary>
        /// <param name="data">The data class of the redemption which should be calculated.</param>
        /// <returns>Returns the filled RedemptionData.</returns>
        private static RedemptionData CalculateLoanAmount(RedemptionData data)
        {
            data.loanAmount = data.redemptionRate * GetRedemptionRateFactor(data) * data.redemptionDuration * 
                              GetDurationFactor(data) + data.remainingDebt;
            return data;
        }

        /// <summary>
        /// Calculates the redemption rate of given redemption data.
        /// </summary>
        /// <param name="data">The data class of the redemption which should be calculated.</param>
        /// <returns>Returns the filled RedemptionData.</returns>
        private static RedemptionData CalculateRedemptionRate(RedemptionData data)
        {
            data.redemptionRate = (data.loanAmount - data.remainingDebt) / data.redemptionDuration * GetDurationFactor(data) / 
                                   GetRedemptionRateFactor(data);
            return data;
        }

        /// <summary>
        /// Calculates the duration of given redemption data.
        /// </summary>
        /// <param name="data">The data class of the redemption which should be calculated.</param>
        /// <returns>Returns the filled RedemptionData.</returns>
        private static RedemptionData CalculateRedemptionDuration(RedemptionData data)
        {
            data.redemptionDuration = (data.loanAmount - data.remainingDebt) / data.redemptionRate * GetRedemptionRateFactor(data);
            if (data.redemptionDurationMode == RedemptionData.RedemptionDurationMode.Months) data.redemptionDuration *= 12;
            return data;
        }

        /// <summary>
        /// Calculates the remaining debt of given redemption data.
        /// </summary>
        /// <param name="data">The data class of the redemption which should be calculated.</param>
        /// <returns>Returns the filled RedemptionData.</returns>
        private static RedemptionData CalculateRemainingDebt(RedemptionData data)
        {
            data.remainingDebt = data.loanAmount - (data.redemptionRate * GetRedemptionRateFactor(data) * 
                                 data.redemptionDuration * GetDurationFactor(data));
            return data;
        }

        /// <summary>
        /// Returns the interest rate factor of given redemption data.
        /// </summary>
        /// <param name="data">The data class of the redemption to get the interest rate factor.</param>
        /// <returns>Returns the factor as an int.</returns>
        public static int GetInterestRateFactor(RedemptionData data)
        {
            switch (data.interestRateInterval)
            {
                case RedemptionData.InterestRateInterval.Monthly:
                    return 12;
                case RedemptionData.InterestRateInterval.Quarterly:
                    return 4;
                case RedemptionData.InterestRateInterval.Biannually:
                    return 2;
                case RedemptionData.InterestRateInterval.Annually:
                    return 1;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the reversed interest rate factor of given redemption data.
        /// </summary>
        /// <param name="data">The data class of the redemption to get the reversed interest rate factor.</param>
        /// <returns>Returns the factor as an int.</returns>
        public static int GetReversedInterestRateFactor(RedemptionData data)
        {
            switch (data.interestRateInterval)
            {
                case RedemptionData.InterestRateInterval.Monthly:
                    return 1;
                case RedemptionData.InterestRateInterval.Quarterly:
                    return 3;
                case RedemptionData.InterestRateInterval.Biannually:
                    return 6;
                case RedemptionData.InterestRateInterval.Annually:
                    return 12;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the redemption rate factor of given redemption data.
        /// </summary>
        /// <param name="data">The data class of the redemption to get the redemption rate factor.</param>
        /// <returns>Returns the factor as an int.</returns>
        public static int GetRedemptionRateFactor(RedemptionData data)
        {
            switch (data.redemptionRateInterval)
            {
                case RedemptionData.RedemptionRateInterval.Monthly:
                    return 12;
                case RedemptionData.RedemptionRateInterval.Quarterly:
                    return 4;
                case RedemptionData.RedemptionRateInterval.Biannually:
                    return 2;
                case RedemptionData.RedemptionRateInterval.Annually:
                    return 1;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the reversed redemption rate factor of given redemption data.
        /// </summary>
        /// <param name="data">The data class of the redemption to get the reversed redemption rate factor.</param>
        /// <returns>Returns the factor as an int.</returns>
        public static int GetReversedRedemptionRateFactor(RedemptionData data)
        {
            switch (data.redemptionRateInterval)
            {
                case RedemptionData.RedemptionRateInterval.Monthly:
                    return 1;
                case RedemptionData.RedemptionRateInterval.Quarterly:
                    return 3;
                case RedemptionData.RedemptionRateInterval.Biannually:
                    return 6;
                case RedemptionData.RedemptionRateInterval.Annually:
                    return 12;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the duration factor of given redemption data.
        /// </summary>
        /// <param name="data">The data class of the redemption to get the duration factor.</param>
        /// <returns>Returns the factor as a double.</returns>
        public static double GetDurationFactor(RedemptionData data)
        {
            double result;
            switch (data.redemptionDurationMode)
            {
                case RedemptionData.RedemptionDurationMode.Months:
                    result = 1 / 12.0;
                    break;
                case RedemptionData.RedemptionDurationMode.Years:
                    result = 1;
                    break;
                default:
                    throw new NotImplementedException();
            }
            return result;
        }
    }
}
