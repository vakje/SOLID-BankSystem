using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public  class Accounts
    {

        //vqmnit data memberebs account clasistvis 
        public int ID  { get;}
        public string CustomerFullName;
        protected decimal _balance;
        public decimal Balance { get { return _balance; }  }
        // aucilebeli tostring methodi romelic gadavtvirte titoeuli classistvis 
        public override string ToString()
        {
            return $"\n fullname:{this.CustomerFullName}\n ID: {this.ID} \n balance: {this._balance}";
        }
        // constructori informaciis initializebistvis sadac aseve mowmdeba balance is negatiuri mnishvneloba 
        public Accounts(string initialCustomername , decimal intialbalance,int id ) 
        {
            CustomerFullName = initialCustomername ;
            _balance = intialbalance;
            ID = id ;
            if (Balance < 0) 
            {
                throw new ArgumentOutOfRangeException("\namount is negative in constructor in Accounts class\n");

            }
           
            
        }
       // tanxis gamotani funqcia romelic romelic amowmebs tanxis validurobas da gamoaqvs es tanxa 
        public bool  withdraw(decimal amount)
        {

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("\namount is negative in withdraw function in DepositAccount class\n");
            }
            if (amount > Balance)
            {
                Console.WriteLine("\nno such money on account\n");
                return false;
            }
            _balance -= amount;
            Console.WriteLine($"\nyou succesfully withdraw your money {amount}\n now Balance: {_balance}\n");
            return true;
        }
        // deposit funqcia romelic amowmebs tanxi validurobas da amatebs balanceze 
        public void deposit(decimal amount) 
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("\namount is negative in depositfromD function \n");
            }
            _balance += amount;
            Console.WriteLine($"\nyou have succesfully deposidet money in your acount {amount} now balance is: {_balance}\n");
        }
        
    }
    public class DepositAccount : Accounts
    {
        //vqmnit data memberebs account clasistvis 
        public double depositrate { get;  }
        public override string ToString()
        {
            return $"\n fullname:{this.CustomerFullName}\n ID: {this.ID} \n balance: {this._balance}\n Depositrate: {this.depositrate}";
        }
        // constructori informaciis initializebistvis sadac aseve mowmdeba balance is negatiuri mnishvneloba 
        public DepositAccount(string initialCustomername, decimal intialbalance ,int id, double d) : base(initialCustomername, intialbalance, id )   
        {
           
            if (depositrate < 0)
            {
                throw new ArgumentOutOfRangeException("\ndepositrate is negative in constuctor of depositAccount \n ");
            } 
            depositrate = d;
            if (Balance < 0) 
            {
                throw new ArgumentOutOfRangeException("\nbalance  is negative in constuctor of depositAccount \n ");
            }   
            
        
        }
        // tanxis gamotani funqcia romelic romelic amowmebs tanxis validurobas da gamoaqvs es tanxa 
        public bool WIthdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("\namount is negative in WIthdraw function in DepositAccount class\n");
            }
            if (amount > Balance)
            {
                Console.WriteLine("\nno such money on account\n");
                return false;
            }
            _balance -= amount;
            Console.WriteLine($"\nyou succesfully withdraw your money {amount}\n now Balance: {_balance}\n");
            return true;
        }
        // deposit funqcia romelic amowmebs tanxi validurobas da amatebs balanceze 
        public void DEposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("\namount is negative in DEposit function \n");
            }
            _balance += amount;
            Console.WriteLine($"\nyou have succesfully deposidet money in your acount {amount} now balance is: {_balance}\n");
        }
       
    }
    public class CreditAccount : Accounts
    {
        public double CreditRate { get; }
        private double _CreditAmount;
        private bool Approved;
       // credit amount is get da set wvodmit 
        public double Creditamount
        {
            get { return _CreditAmount; }
            private set {
                if (value < 0) 
                {
                    throw new ArgumentOutOfRangeException("\nCreditAmount cannot be negative\n");
                }   
                _CreditAmount = value;
            
            }
        }
        public override string ToString()
        {
            return $"\n fullname:{this.CustomerFullName}\n ID: {this.ID} \n balance: {this._balance}\n CreditRate: {this.CreditRate}\n";
        }
        // vamowmebt creditrates 
        public CreditAccount(string initialCustomername, decimal intialbalance,int id, double c):base(initialCustomername, intialbalance, id)
        {
           
            if (c < 0) {
                throw new ArgumentOutOfRangeException("\namount is negative in CrediAccount constructor \n ");
            }
             CreditRate = c;
           
        }
        // tu gamosatani tanxa metia sakredito tanxaze an gamomdzaxebelma akauntma ver gaira shemowmeba mashin tanxa is ver gamoitans 
        // tu arada methodi accounts gamoaraninebs tanxas 
        public bool Withdraw3(decimal amount)
        {

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("\namount is negative in Withdraw  function with object of a class CreditAccount \n");


            }
            if ((double)amount > _CreditAmount || !Approved)
            {
                Console.WriteLine("\nyou cannot withdraw that much money\n ");
                return false;
            }
            
            _balance -= amount;

            Console.WriteLine($"\nyou succesfully withdraw your money\n amount: {amount} \n now balance: {_balance} \n ");
            return true;
        }
        // shetana tanxis 
        public  void Deposit3(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount is negative in Deposit function in class CreditAccount ");
            }
            _balance += amount;
            Console.WriteLine($"\nyou have succesfully deposidet money in your account ::{amount}:: now balance:{_balance} \n");
        }
        /// <summary>
        /// tu gamosatani metia sashualo xelfasis 38 % ze da tan es balanci ar aris dadebiti na = 0 mashin mas ar eqneba ufleba creditis gamosatanad
        /// </summary>
        /// <param name="creditAmount"></param>
        /// <param name="averagesalary"></param>
        /// <returns></returns>
        public bool Approve(decimal creditAmount, decimal averagesalary)
        {
            if (creditAmount > averagesalary * (38 / 100) && Balance <= 0)
            {
                Console.WriteLine("\nwe cannot approve your credit!! because you average salary are little low or you have no balance\n");
                Approved = false;

                return false;
                
            }
            _CreditAmount = (double)creditAmount;

            Console.WriteLine($"\napproved a credit it's amount is {creditAmount}");
           Approved=true;
            return true;                            
        
        }
        
    }
}
