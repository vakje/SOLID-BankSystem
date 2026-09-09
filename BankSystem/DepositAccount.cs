using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class DepositAccount : Accounts
    {

        public double _Depositrate { get; }
        public override string ToString()
        {
            return $"\n fullname:{this._CustomerFullName}\n _AccountId: {this._AccountId} \n balance: {this._balance}\n Depositrate: {this._Depositrate}";
        }

        public DepositAccount(string initialCustomername, decimal intialbalance, int _AccountId, double d) : base(initialCustomername, intialbalance, _AccountId)
        {
            if (_Depositrate < 0)
                throw new ArgumentOutOfRangeException(nameof(_Depositrate), "\ndepositrate is negative in constuctor of depositAccount \n ");
            
            if (_Balance < 0)
                throw new ArgumentOutOfRangeException(nameof(_Balance), "\nbalance  is negative in constuctor of depositAccount \n ");
            
            _Depositrate = d;
        }

        public bool WIthdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount),"\namount is negative in WIthdraw function in DepositAccount class\n");
           
            if (amount > _Balance)
            {
                Console.WriteLine("\nno such money on account\n");
                return false;
            }
            _balance -= amount;
            Console.WriteLine($"\nyou succesfully withdraw your money {amount}\n now Balance: {_balance}\n");
            return true;
        }

        public void DEposit(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount),"\namount is negative in DEposit function \n");
            
            _balance += amount;
            Console.WriteLine($"\nyou have succesfully depos_AccountIdet money in your acount {amount} now balance is: {_balance}\n");
        }

    }
}
