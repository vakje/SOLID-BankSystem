using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Accounts
    { 
        public int _AccountId  { get;}
        public string _CustomerFullName;
        protected decimal _balance;
        public decimal _Balance { get { return _balance; }  }
       
        public override string ToString()
        {
            return $"\n fullname:{this._CustomerFullName}\n _Account_AccountId: {this._AccountId} \n balance: {this._balance}";
        }
       
        public Accounts(string initialCustomername , decimal intialbalance,int _accId) 
        {
            _CustomerFullName = initialCustomername ;
            _balance = intialbalance;
            _AccountId = _accId;
            if (_Balance < 0)
                throw new ArgumentOutOfRangeException(nameof(_Balance),"\namount is negative in constructor in Accounts class\n");
        }
       
        public bool  withdraw(decimal amount)
        {

            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "\namount is negative in withdraw function in DepositAccount class\n");

            if (amount > _Balance)
            {
                Console.WriteLine("\nno such money on account\n");
                return false;
            }
            _balance -= amount;
            Console.WriteLine($"\nyou succesfully withdraw your money {amount}\n now Balance: {_balance}\n");
            return true;
        }
       
        public void deposit(decimal amount) 
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "\namount is negative in depositfromD function \n");

            _balance += amount;
            Console.WriteLine($"\nyou have succesfully depos_Account_AccountIdet money in your acount {amount} now balance is: {_balance}\n");
        }
        
    }
   
    
}
