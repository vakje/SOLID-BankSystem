using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class DepositAccount : Accounts, IRateValidator, IDepositable, IWithdrawable
    {

        public double _Depositrate { get; }

        public DepositAccount(string initialCustomername, decimal intialbalance, int _AccountId, double d) : base(initialCustomername, intialbalance, _AccountId)
        {
            _Depositrate = d;
            RateCheck(_Depositrate);
            AccountBalanceCheck(_Balance);
        }

        public bool withdraw(decimal amount)
        {
            MoneyAmountCheck(amount);


            AccountBalanceCheck(amount);

             _balance -= amount;
            Console.WriteLine($"\nyou succesfully withdraw your money {amount}\n now Balance: {_balance}\n");
            return true;
        }

        public void deposit(decimal amount)
        {
            MoneyAmountCheck(amount);

            _balance += amount;
            Console.WriteLine($"\nyou have succesfully depos_AccountIdet money in your acount {amount} now balance is: {_balance}\n");
        }

        public override string ToString()
        {
            return $"\n Id: {this._AccountId}\n fullname:{this._CustomerFullName} \n balance: {this._balance}\n Depositrate: {this._Depositrate}";
        }

        public bool RateCheck(double Xrate)
        {
            if (Xrate < 0)
                throw new ArgumentOutOfRangeException(nameof(Xrate), "\namount is negative in DepositAccount\n ");

            return true;
        }
       
    }
}
