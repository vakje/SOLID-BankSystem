using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                BankAccGenerator generator = new BankAccGenerator();
                BankAccSimulator simulation = new BankAccSimulator();

                var accounts = generator.CreateBankAccounts;
                var depositaccounts = generator.CreateDepositAccounts;
                var creditaccounts = generator.CreateCreditAccounts;


                simulation.Simulation(accounts, depositaccounts, creditaccounts);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
            finally
            {
                Console.ReadLine();
            }

            }
    }
}


