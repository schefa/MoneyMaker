using System;

namespace MoneyMaker.Models
{
    /// <summary>
    /// The basic class for every leasing data within the program.
    /// </summary>
    public class LeasingData : FinancingItem      
    {
        public int LeasingID;
        public int UserID;
        public string leasingName;
        public DateTime created;
        public double startValue;           
        public double deposit;             
        public double interestRate;       
        public double leasingRate;         
        public enum LeasingRateInterval    
        {
            Monthly,                        
            Quarterly,                      
            Biannually,                     
            Annually,                       
        };
        public LeasingRateInterval leasingRateInterval;
        public double duration;             
        public enum DurationMode            
        {
            Years,                          
            Months                          
        };
        public DurationMode durationMode;
        public double recoveryValue;
        public double totalExpense;
        public double totalInterest;
    }
}
