using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Program
    {
        /// <summary>
        ///  hashseti rata unikaluri randomuli id hqondes momxmarebels 
        /// </summary>
       static HashSet<int> nums = new HashSet<int>();
        static Random random = new Random();
        static int generateuniquerandomnumber()
        {
            

            int randomnumber;
            do
            {
                randomnumber = random.Next(100000000, 999999999);
            }
            while (nums.Contains(randomnumber));
            nums.Add(randomnumber);

            return randomnumber;
        }
        static void Main(string[] args)
        {

            List<DepositAccount> TOP = new List<DepositAccount>();
            List<CreditAccount> BOTTOM = new List<CreditAccount>();
            
            int randomid1=generateuniquerandomnumber();
            int randomid2 = generateuniquerandomnumber();
            int randomid3 = generateuniquerandomnumber();
            int randomid4 = generateuniquerandomnumber();
            int randomid5 = generateuniquerandomnumber();
            int randomid6 = generateuniquerandomnumber();
            int randomid7 = generateuniquerandomnumber();
            int randomid8 = generateuniquerandomnumber();
            int randomid9 = generateuniquerandomnumber();
            int randomid10 = generateuniquerandomnumber();



            try
            {   // safety check 
                if (Bank.accounts == null)
                {
                    Bank.accounts = new List<Accounts>();
                }
                // vamateb masivshi obieqtebs da mat informacia 
                Bank.accounts.Add( new Accounts("vako sherozia", 10000, randomid1));
                Bank.accounts.Add(new Accounts("mixo sherozadze", 12000, randomid2));
                Bank.accounts.Add(new Accounts("alexandre sherozedadze", 10000, randomid3));
                Bank.accounts.Add(new Accounts("vakho smitadze", 1000, randomid4));
                Bank.accounts.Add(new Accounts("vaja shukakidze", 10000000, randomid5));

                List<DepositAccount> Deposit = new List<DepositAccount>
            {
                 new DepositAccount("saxeli saxelashvili", 500000,randomid6, 1.3),
                 new DepositAccount("saxeli saxelashvdze", 50000, randomid7, 1.3),
                 new DepositAccount("lashvardi saxelashvili", 500, randomid8, 1.3)
            };
                List<CreditAccount> Credit = new List<CreditAccount> {
                new CreditAccount("raxac raxacashvili", 500000,randomid9, 1.7),
                new CreditAccount("rax raxashvili", 1050000, randomid10, 10.5),
            };

                foreach (var item in Bank.accounts)
                {
                    Console.WriteLine(item.ToString());
                }
                
                foreach (var item in Deposit)
                {
                    Console.WriteLine(item.ToString());
                }
                foreach (var item in Credit)
                {
                    Console.WriteLine(item.ToString());
                }
                decimal dep = 10;
                
                Console.WriteLine("-----------------------------depositing------------------------------------------");
                foreach (var item in Bank.accounts)
                {
                    item.deposit(dep*10);
                }
                foreach (var item in Deposit)
                {
                    item.DEposit(dep * 10);
                }
                foreach (var item in Credit)
                {
                    item.Deposit3(dep * 10);
                }
                Console.WriteLine("-----------------------------after depositing------------------------------------------");
                foreach (var item in Bank.accounts)
                {
                    Console.WriteLine(item.ToString());
                }

                foreach (var item in Deposit)
                {
                    Console.WriteLine(item.ToString());
                }
                foreach (var item in Credit)
                {
                    Console.WriteLine(item.ToString());
                }
                
                Console.WriteLine("----------------------------approve system-------------------------------------------");
                foreach (var item in Credit)
                {
                    item.Approve(100000000, dep*100);
                    dep *= 2;
                   
                }
                 Console.WriteLine("-----------------------------withdrawing------------------------------------------");
                foreach (var item in Bank.accounts)
                {
                    item.withdraw(dep * 10);
                }
                foreach (var item in Deposit)
                {
                    item.WIthdraw(dep * 10);
                }
                foreach (var item in Credit)
                {
                     item.Withdraw3(5001000);
                }
                Console.WriteLine("-----------------------------after withdrawing------------------------------------------");
                foreach (var item in Bank.accounts)
                {
                    Console.WriteLine(item.ToString());
                }

                foreach (var item in Deposit)
                {
                    Console.WriteLine(item.ToString());
                }
                foreach (var item in Credit)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("-----------------------------top3 (positive)balance accounts------------------------------------------");
                TOP = Bank.bigamountofmoney(Deposit);
                foreach (var item in TOP)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("-----------------------------top3 (negative)balance accounts------------------------------------------");
                BOTTOM = Bank.bigamountofdept(Credit);
                foreach (var item in BOTTOM)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException ex)

            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }


        }

    }
}
