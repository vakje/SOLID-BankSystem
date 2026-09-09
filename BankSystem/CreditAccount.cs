using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class CreditAccount : Accounts
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
        public override string ToString()
        {
            return $"\n fullname:{this._CustomerFullName}\n _AccountId: {this._AccountId} \n balance: {this._balance}\n CreditRate: {this._CreditRate}\n";
        }

        public CreditAccount(string initialCustomername, decimal intialbalance, int _AccountId, double c) : base(initialCustomername, intialbalance, _AccountId)
        {

            if (c < 0)
                throw new ArgumentOutOfRangeException(nameof(c), "\namount is negative in CrediAccount constructor \n ");
            
            _CreditRate = c;

        }

        public bool Withdraw3(decimal amount)
        {

            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "\namount is negative in Withdraw  function with object of a class CreditAccount \n");


            
            if ((double)amount > _CreditAmount || !_Approved)
            {
                Console.WriteLine("\nyou cannot withdraw that much money\n ");
                return false;
            }

            _balance -= amount;

            Console.WriteLine($"\nyou succesfully withdraw your money\n amount: {amount} \n now balance: {_balance} \n ");
            return true;
        }

        public void Deposit3(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "amount is negative in Deposit function in class CreditAccount ");

            _balance += amount;
            Console.WriteLine($"\nyou have succesfully depos_AccountIdet money in your account ::{amount}:: now balance:{_balance} \n");
        }

        public bool Approve(decimal creditAmount, decimal averagesalary)
        {
            if (creditAmount > averagesalary * (38 / 100) && _Balance <= 0)
            {
                Console.WriteLine("\nwe cannot approve your credit!! because you average salary are little low or you have no balance\n");
                _Approved = false;

                return false;

            }
            _CreditAmount = (double)creditAmount;

            Console.WriteLine($"\napproved a credit it's amount is {creditAmount}");
            _Approved = true;
            return true;

        }

    }
}
