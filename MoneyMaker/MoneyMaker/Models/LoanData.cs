using System;

namespace MoneyMaker.Models
{
    /// <summary>
    /// The basic class for every loan data within the program.
    /// </summary>
    public class LoanData : FinancingItem   
    {
        public int LoanID;
        public int UserID;
        public string loanName;
        public DateTime created;
        public double loanAmount;          
        public double interestRate;      
        public double repaymentRate;      
        public enum RepaymentRateInterval  
        {
            Monthly,                    
            Quarterly,                    
            Biannually,                 
            Annually,                      
        };
        public RepaymentRateInterval repaymentRateInterval;                
        public double duration;           
        public enum DurationMode           
        {
            Years,                         
            Months                        
        };
        public DurationMode durationMode;                                   
        public enum CalculateOption        
        {
            LoanAmount,                   
            RepaymentRate,                  
            Duration                       
        };
        public CalculateOption calculateOption;                             
        public double totalExpense;      
    }
}
