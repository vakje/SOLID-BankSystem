using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Accounts : IAccountValidator, IDepositable, IWithdrawable
    { 
        public int _AccountId  { get;}
        public string _CustomerFullName;
        protected decimal _balance;
        public decimal _Balance => _balance;

        public Accounts(string initialCustomername , decimal intialbalance,int _accId) 
        {
            _CustomerFullName = initialCustomername ;
            _balance = intialbalance;
            _AccountId = _accId;
            AccountBalanceCheck(_balance);
        }
       
        public virtual bool withdraw(decimal amount)
        {
            MoneyAmountCheck(amount);

            WithdrawableMoneyCheck(amount, _balance);

            _balance -= amount;
            Console.WriteLine($"\nyou succesfully withdraw your money {amount}\n now Balance: {_balance}\n");
            return true;
        }
       
        public virtual void deposit(decimal amount) 
        {
            MoneyAmountCheck(amount);

            _balance += amount;
            Console.WriteLine($"\nyou have succesfully made a deposit  in your acount {amount} now balance is: {_balance}\n");
        }
        public override string ToString()
        {
            return $"\n Id: {this._AccountId} \n fullname:{this._CustomerFullName} \n balance: {this._balance} \n";
        }

        public bool MoneyAmountCheck(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "\namount is negative in withdraw function in DepositAccount class\n");
            return true;
        }

        public bool AccountBalanceCheck(decimal balance)
        {
            if (balance < 0)
                throw new ArgumentOutOfRangeException(nameof(balance), "\namount is negative in constructor in Accounts class\n");

            return true;
        }

        public bool WithdrawableMoneyCheck(decimal amount, decimal balance)
        {
            if (amount > balance)
            {
                Console.WriteLine($"\nno such money on account\n cant withdraw {amount} you have balance:{balance}");
                return false;
            }
            return true;
        }
    }
   
    
}
