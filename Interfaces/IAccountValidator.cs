using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal interface IAccountValidator
    { 
        /*
         * validators for - > Amount control if this is valid number should not be signed integer
         *                    Balance shouldnot be less or equal to zero
         *                    Balance control Amount Shouldnot be bigger than balance itself valid for normal bank accounts.
         *                    
        */ 
        bool MoneyAmountCheck(decimal amount);
        bool AccountBalanceCheck(decimal balance);
        bool WithdrawableMoneyCheck(decimal amount,decimal balance);
    }
    internal interface IRateValidator
    {
        // validating for specificly Deposit/credit accounts  deposit/credit  rates should not be less than zero
        bool RateCheck(double Xrate);
    }
    internal interface ICreditValidator 
    {
        // Credit approval check
        bool CreditApproval(decimal creditAmount, decimal averagesalary, decimal balance);

    }
}
