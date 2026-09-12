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
                IAccountGenerator generator = new BankAccGenerator();
                BankAccSimulator simulation = new BankAccSimulator();

                simulation.Simulation(generator.CreateBankAccounts, generator.CreateDepositAccounts, generator.CreateCreditAccounts);
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


