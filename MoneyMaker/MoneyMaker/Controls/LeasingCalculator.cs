using System;
using MoneyMaker.Models;

namespace MoneyMaker.Controls
{
    public static class LeasingCalculator
    {
        /// <summary>
        /// The function to calculate LeasingData.
        /// </summary>
        /// <param name="data">The data class of the leasing which should be calculated.</param>
        /// <returns>Returns the filled LeasingData.</returns>
        public static LeasingData Calculate(LeasingData data)
        {
            data.totalExpense = (data.leasingRate * data.duration * 12 * GetDurationFactor(data) / GetReversedLeasingtRateFactor(data)) + data.deposit;
            data.totalInterest = data.totalExpense - (data.startValue - data.recoveryValue);
            return data;
        }

        /// <summary>
        /// Returns the leasing rate factor of given leasing data.
        /// </summary>
        /// <param name="data">The data class of the leasing to get the leasing rate factor.</param>
        /// <returns>Returns the factor as an int.</returns>
        public static int GetLeasingtRateFactor(LeasingData data)
        {
            switch (data.leasingRateInterval)
            {
                case LeasingData.LeasingRateInterval.Monthly:
                    return 12;
                case LeasingData.LeasingRateInterval.Quarterly:
                    return 4;
                case LeasingData.LeasingRateInterval.Biannually:
                    return 2;
                case LeasingData.LeasingRateInterval.Annually:
                    return 1;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the reversed leasing rate factor of given leasing data.
        /// </summary>
        /// <param name="data">The data class of the leasing to get the reversed leasing rate factor.</param>
        /// <returns>Returns the factor as an int.</returns>
        public static int GetReversedLeasingtRateFactor(LeasingData data)
        {
            switch (data.leasingRateInterval)
            {
                case LeasingData.LeasingRateInterval.Monthly:
                    return 1;
                case LeasingData.LeasingRateInterval.Quarterly:
                    return 3;
                case LeasingData.LeasingRateInterval.Biannually:
                    return 6;
                case LeasingData.LeasingRateInterval.Annually:
                    return 12;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the duration factor of given leasing data.
        /// </summary>
        /// <param name="data">The data class of the leasing to get the duration factor.</param>
        /// <returns>Returns the factor as a double.</returns>
        public static double GetDurationFactor(LeasingData data)
        {
            double result;
            switch (data.durationMode)
            {
                case LeasingData.DurationMode.Months:
                    result = 1 / 12.0;
                    break;
                case LeasingData.DurationMode.Years:
                    result = 1;
                    break;
                default:
                    throw new NotImplementedException();
            }
            return result;
        }
    }
}