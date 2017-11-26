using System;

namespace MoneyMaker.Models
{
    /// <summary>
    /// The basic class for every redemption data within the program.
    /// </summary>
    public class RedemptionData : FinancingItem          
    {
        public int RedemptionID;
        public int UserID;
        public string redemptionName;
        public DateTime created;

        public double loanAmount;         
        public double interestRate;        
        public enum InterestRateInterval   
        {
            Monthly,                     
            Quarterly,                    
            Biannually,                
            Annually,                   
        };
        public InterestRateInterval interestRateInterval;                 
        public double redemptionRate;     
        public enum RedemptionRateInterval 
        {
            Monthly,                    
            Quarterly,                    
            Biannually,                   
            Annually,                    
        };
        public RedemptionRateInterval redemptionRateInterval;                
        public double redemptionDuration;   
        public enum RedemptionDurationMode 
        {
            Years,                        
            Months                          
        };
        public RedemptionDurationMode redemptionDurationMode;                 
        public double remainingDebt;     
        public enum CalculateOption        
        {
            LoanAmount,                   
            RedemptionRate,               
            RedemptionDuration,            
            RemainingDebt                   
        };
        public CalculateOption calculateOption;                               
        public double totalExpense;         
    }
}
