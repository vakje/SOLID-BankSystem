using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    /// <summary>
    /// class can withdraw any money since it is creditaccounts
    /// </summary>
    public class CreditAccount : Accounts, IRateValidator, ICreditValidator, IDepositable, IWithdrawable
    {
        public double _CreditRate { get; }
        private double _CreditAmount;
        private bool _Approved;

        public double Creditamount
        {
            get { return _CreditAmount; }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value),"\nCreditAmount cannot be negative\n");
               
                _CreditAmount = value;

            }
        }

        public CreditAccount(string initialCustomername, decimal intialbalance, int _AccountId, double c) : base(initialCustomername, intialbalance, _AccountId)
        {
            if (RateCheck(c) == true)
            {
                 _CreditRate = c;
            }
        }

        public bool withdraw(decimal amount)
        {

            MoneyAmountCheck(amount);

            _balance -= amount;

            Console.WriteLine($"\nyou succesfully withdraw your money\n amount: {amount} \n now balance: {_balance} \n ");
            return true;
        }

        public void deposit(decimal amount)
        {
            MoneyAmountCheck(amount);

            _balance += amount;
            Console.WriteLine($"\nyou have succesfully deposit in your account ::{amount}:: now balance:{_balance} \n");
        }

        public bool Approve(decimal creditAmount, decimal averagesalary)
        {
            if (CreditApproval(creditAmount, averagesalary, _Balance) == false)
            {
                _Approved = false;
                return _Approved;
            }
            _CreditAmount = (double)creditAmount;

            Console.WriteLine($"\napproved a credit it's amount is {creditAmount} avg salary {averagesalary} balance: {_balance}");
            _Approved = true;
            return true;

        }
        public override string ToString()
        {
            return $"\n Id: {this._AccountId} \n fullname:{this._CustomerFullName} \n balance: {this._balance}\n CreditRate: {this._CreditRate}\n";
        }

        public bool RateCheck(double Xrate)
        {
            if (Xrate < 0)
                throw new ArgumentOutOfRangeException(nameof(Xrate), "\namount is negative in CrediAccount\n ");

            return true;
        }

        public bool CreditApproval(decimal creditAmount, decimal averagesalary, decimal balance)
        {
            double percent_value = Math.Round(38.0f / 100.0f);
            if (creditAmount > averagesalary * (decimal)percent_value || balance <= 0)
            {
                Console.WriteLine("\nwe cannot approve your credit!! because you average salary are little low or you have no balance\n");
                _Approved = false;

                return false;

            }
            return true;
        }
    }
}
