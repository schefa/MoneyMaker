using MoneyMaker.Models;
using System;
using System.Collections.Generic;

namespace MoneyMaker.Controls
{
    public static class TableCalculator
    {
        /// <summary>
        /// This method calculates a LoanTable from given LoanData
        /// </summary>
        /// <param name="data">The LoanData to create the LoanTable</param>
        /// <returns>Returns the calculated LoanTable</returns>
        public static LoanTable ToLoanTable(LoanData data)
        {
            LoanTable table = new LoanTable();
            table.loanRowList = new List<LoanTableRow>();
            table.rate = data.repaymentRate;
            int maxMonths = (int)Math.Ceiling(data.duration * 12 * LoanCalculator.GetDurationFactor(data));
            table.months = new int[maxMonths];
            table.beforeMonths = new double[maxMonths];
            table.interests = new double[maxMonths];
            table.clearances = new double[maxMonths];
            table.afterMonths = new double[maxMonths];
            int interval = LoanCalculator.GetReversedRateFactor(data);
            for (int i = 0; i < table.months.Length; i++)
            {
                table.months[i] = i + 1;
                if (i != 0)
                    table.beforeMonths[i] = table.afterMonths[i - 1];
                else
                    table.beforeMonths[i] = data.loanAmount;
                if (((i + 1) % interval) == 0)
                {
                    table.interests[i] = Math.Round(table.beforeMonths[i] * data.interestRate / 100 / 
                                         LoanCalculator.GetRateFactor(data), 2);
                    table.clearances[i] = table.rate - table.interests[i];
                }
                else
                {
                    table.interests[i] = 0;
                    table.clearances[i] = 0;
                }
                table.afterMonths[i] = Math.Round(table.beforeMonths[i] - table.clearances[i], 2);
                table.loanRowList.Add(new LoanTableRow()
                {
                    month = table.months[i],
                    beforeMonth = table.beforeMonths[i],
                    rate = table.rate,
                    interest = table.interests[i],
                    clearance = table.clearances[i],
                    afterMonth = table.afterMonths[i],
                });
                if (table.afterMonths[i] <= 0) break;
            }
            return table;
        }

        /// <summary>
        /// This method calculates a RedemptionTable from given RedemptionData
        /// </summary>
        /// <param name="data">The RedemptionData to create the RedemptionTable</param>
        /// <returns>Returns the calculated RedemptionTable</returns>
        public static RedemptionTable ToRedemptionTable(RedemptionData data)
        {
            RedemptionTable table = new RedemptionTable();
            table.redemptionRowList = new List<RedemptionTableRow>();
            table.rate = data.redemptionRate;
            int maxMonths = (int)Math.Ceiling(data.redemptionDuration * 12 * RedemptionCalculator.GetDurationFactor(data));
            table.months = new int[maxMonths];
            table.beforeMonths = new double[maxMonths];
            table.interests = new double[maxMonths];
            table.clearances = new double[maxMonths];
            table.afterMonths = new double[maxMonths];
            table.payments = new double[maxMonths];
            int interestInterval = RedemptionCalculator.GetReversedInterestRateFactor(data);
            int redemptionInterval = RedemptionCalculator.GetReversedRedemptionRateFactor(data);
            for (int i = 0; i < table.months.Length; i++)
            {
                table.months[i] = i + 1;
                if (i != 0)
                    table.beforeMonths[i] = table.afterMonths[i - 1];
                else
                    table.beforeMonths[i] = data.loanAmount;
                if (((i + 1) % interestInterval) == 0)
                    table.interests[i] = Math.Round(table.beforeMonths[i] * data.interestRate / 100 / 
                                         RedemptionCalculator.GetInterestRateFactor(data), 2);
                else
                    table.interests[i] = 0;
                if (((i + 1) % redemptionInterval) == 0)
                    table.clearances[i] = table.rate;
                else
                    table.clearances[i] = 0;
                table.payments[i] = table.clearances[i] + table.interests[i];
                table.clearances[i] = table.payments[i] - table.interests[i];
                table.afterMonths[i] = Math.Round(table.beforeMonths[i] - table.clearances[i], 2);
                table.redemptionRowList.Add(new RedemptionTableRow()
                {
                    month = table.months[i],
                    beforeMonth = table.beforeMonths[i],
                    payment = table.payments[i],
                    interest = table.interests[i],
                    clearance = table.clearances[i],
                    afterMonth = table.afterMonths[i],
                });
                if (table.afterMonths[i] <= 0) break;
            }
            return table;
        }

        /// <summary>
        /// This method calculates a LeasingTable from given LeasingData
        /// </summary>
        /// <param name="data">The LeasingData to create the LeasingTable</param>
        /// <returns>Returns the calculated LeasingTable</returns>
        public static LeasingTable ToLeasingTable(LeasingData data)
        {
            LeasingTable table = new LeasingTable();
            table.leasingRowList = new List<LeasingTableRow>();
            int maxMonths = (int) (data.duration * 12 * LeasingCalculator.GetDurationFactor(data));
            table.months = new int[maxMonths];
            table.rateSums = new double[maxMonths];
            table.capitalLosses = new double[maxMonths];
            table.recoveryValues = new double[maxMonths];
            int leasingInterval = LeasingCalculator.GetReversedLeasingtRateFactor(data);
            table.rate = data.leasingRate;
            for (int i = 0; i < table.months.Length; i++)
            {
                table.months[i] = i + 1;
                if (i == 0) table.rateSums[i] = data.leasingRate;
                else table.rateSums[i] = table.rateSums[i - 1] + data.leasingRate;
                table.capitalLosses[i] = Math.Round((data.startValue - data.recoveryValue) / (data.duration * 12 * 
                                          LeasingCalculator.GetDurationFactor(data)), 2);
                if (i == 0) table.recoveryValues[i] = data.startValue - table.capitalLosses[i];
                else table.recoveryValues[i] = Math.Round(table.recoveryValues[i - 1] - table.capitalLosses[i],2);
                table.leasingRowList.Add(new LeasingTableRow()
                {
                    capitalLoss = table.capitalLosses[i],
                    month = table.months[i],
                    rate = table.rate,
                    rateSum = table.rateSums[i],
                    recoveryvalue = table.recoveryValues[i]
                });
            }
            return table;
        }
    }
}
