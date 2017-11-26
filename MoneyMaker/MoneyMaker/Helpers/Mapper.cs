using MoneyMaker.Models;
using System;

namespace MoneyMaker.Helpers
{
    public static class Mapper
    {
        /// <summary>
        /// Extension method, that converts the entity models from the Loancalculator in models suitable for LINQ   
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static Models.Database.LoanData convertToLinq(this Models.LoanData entity)
        {
            return new Models.Database.LoanData
            {
                LoanID = entity.LoanID,
                UserID = entity.UserID,
                created = entity.created,
                calculateOption = (int) entity.calculateOption,
                duration = entity.duration,
                durationMode = (int) entity.durationMode,
                interestRate = entity.interestRate,
                loanAmount = entity.loanAmount,
                loanName = entity.loanName,
                repaymentRate = entity.repaymentRate,
                repaymentRateInterval = (int) entity.repaymentRateInterval,
                totalExpense = entity.totalExpense,
            };
        }
        /// <summary>
        /// Extension method, that converts the LINQ models of the loandata back to c# entities
        /// </summary>
        /// <param name="linqEntity"></param>
        /// <returns></returns>
        public static Models.LoanData convertToEntity(this Models.Database.LoanData linqEntity)
        {
            return new Models.LoanData()
            {
                LoanID = linqEntity.LoanID,
                UserID = linqEntity.UserID,
                created = Convert.ToDateTime(linqEntity.created),
                calculateOption =  (LoanData.CalculateOption)linqEntity.calculateOption,
                duration = (double)linqEntity.duration,
                durationMode = (LoanData.DurationMode)linqEntity.durationMode,
                interestRate = (double)linqEntity.interestRate,
                loanAmount = (double)linqEntity.loanAmount,
                loanName = linqEntity.loanName,
                repaymentRate = (double)linqEntity.repaymentRate,
                repaymentRateInterval = (LoanData.RepaymentRateInterval)linqEntity.repaymentRateInterval,
                totalExpense = (double)linqEntity.totalExpense,
            };
        }
        /// <summary>
        /// Extension method, that converts the entity models of the Leasingcalculator in models suitable for LINQ   
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static Models.Database.LeasingData convertToLinq(this Models.LeasingData entity)
        {
            return new Models.Database.LeasingData
            {
                LeasingID = entity.LeasingID,
                UserID = entity.UserID,
                created = entity.created,
                deposit = entity.deposit,
                duration = entity.duration,
                interestRate = entity.interestRate,
                startValue = entity.startValue,
                leasingRate = entity.leasingRate,
                leasingName = entity.leasingName,
                leasingRateInterval = (int) entity.leasingRateInterval,
                durationMode = (int) entity.durationMode,
                recoveryValue = entity.recoveryValue,
                totalExpense = entity.totalExpense,
                totalInterest = entity.totalInterest
            };
        }
        /// <summary>
        /// Extension method, that converts the LINQ models of the LeasingCalculator back to c# entities
        /// </summary>
        /// <param name="linqEntity"></param>
        /// <returns></returns>
        public static Models.LeasingData convertToEntity(this Models.Database.LeasingData linqEntity)
        {
            return new Models.LeasingData()
            {
                LeasingID = linqEntity.LeasingID,
                UserID = linqEntity.UserID,
                created = Convert.ToDateTime(linqEntity.created),              
                deposit = (double)linqEntity.deposit,
                duration = (double)linqEntity.duration,
                interestRate = (double)linqEntity.interestRate,               
                startValue = (double)linqEntity.startValue,
                leasingRate = (double)linqEntity.leasingRate,
                leasingName = linqEntity.leasingName,
                leasingRateInterval = (LeasingData.LeasingRateInterval)linqEntity.leasingRateInterval,
                durationMode = (LeasingData.DurationMode)linqEntity.durationMode,
                recoveryValue = (double)linqEntity.recoveryValue,               
                totalExpense = (double)linqEntity.totalExpense,
                totalInterest = (double)linqEntity.totalInterest,
            };
        }


        public static Models.Database.RedemptionData convertToLinq(this Models.RedemptionData entity)
        {
            return new Models.Database.RedemptionData
            {
                RedemptionID = entity.RedemptionID,
                UserID = entity.UserID,
                created = entity.created,
                loanAmount = entity.loanAmount,
                redemptionName = entity.redemptionName,
                interestRateInterval = (int) entity.interestRateInterval,
                interestRate = entity.interestRate,
                redemptionRate = entity.redemptionRate,
                redemptionRateInterval = (int) entity.redemptionRateInterval,
                redemptionDuration = entity.redemptionDuration,
                redemptionDurationMode = (int) entity.redemptionDurationMode,
                remainingDebt = entity.remainingDebt,
                calculateOption = (int) entity.calculateOption,
                totalExpense = entity.totalExpense,
                
            };
        }
        /// <summary>
        /// Extension method, that converts the LINQ models of the RedemptionCalculator back to c# entities
        /// </summary>
        /// <param name="linqEntity"></param>
        /// <returns></returns>
        public static Models.RedemptionData convertToEntity(this Models.Database.RedemptionData linqEntity)
        {
            return new Models.RedemptionData()
            {
                RedemptionID = linqEntity.RedemptionID,
                UserID = linqEntity.UserID,
                created = Convert.ToDateTime(linqEntity.created),
                loanAmount = (double) linqEntity.loanAmount,
                redemptionName = linqEntity.redemptionName,
                interestRateInterval = (RedemptionData.InterestRateInterval)linqEntity.interestRateInterval,
                interestRate = (double) linqEntity.interestRate,
                redemptionRate = (double)linqEntity.redemptionRate,
                redemptionRateInterval = (RedemptionData.RedemptionRateInterval)linqEntity.redemptionRateInterval,
                redemptionDuration = (double)linqEntity.redemptionDuration,
                redemptionDurationMode = (RedemptionData.RedemptionDurationMode)linqEntity.redemptionDurationMode,
                remainingDebt = (double)linqEntity.remainingDebt,
                calculateOption = (RedemptionData.CalculateOption)linqEntity.calculateOption,
                totalExpense = (double)linqEntity.totalExpense,
            };
        }
        
    }
}
