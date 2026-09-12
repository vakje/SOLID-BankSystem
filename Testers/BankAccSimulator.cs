using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class BankAccSimulator
    {
        public List<DepositAccount> GetTopThreeDepositAccounts(List<DepositAccount> accounts)
        {
            // desc 
            return accounts.OrderByDescending(a => a._Balance).Take(3).ToList();
        }
        public List<CreditAccount> GetTopThreeCreditDebts(List<CreditAccount> accounts)
        {
            //asc
            return accounts.OrderBy(a => a._Balance).Take(3).ToList();
        }
        public void Simulation(List<Accounts> BaseAccs, List<DepositAccount> DepAccs, List<CreditAccount> CreditAccs)
        {

            var Allaccounts = BaseAccs.Concat(DepAccs).Concat(CreditAccs).ToList();

            PrintSections("Printing", Allaccounts);

            decimal dep = 10;

            Allaccounts.ForEach(a => a.deposit(dep * 10));
            PrintSections("Depositing", Allaccounts);

            foreach (var credit in CreditAccs)
            {
                credit.Approve(100000000, dep * 100);
                dep *= 2;
            }

            BaseAccs.ForEach(a => a.withdraw(dep * 10));
            DepAccs.ForEach(a => a.withdraw(dep * 10));
            CreditAccs.ForEach(a => a.withdraw(5001000));
            PrintSections("After Withdrawing", Allaccounts);


            Console.WriteLine("--- top 3 Positive Balance Accounts ---");
            var top3 = GetTopThreeDepositAccounts(DepAccs);
            top3.ForEach(a => Console.WriteLine(a));

            Console.WriteLine("\n--- bottom 3 Credit Debts ---");
            var bottom3 = GetTopThreeCreditDebts(CreditAccs);
            bottom3.ForEach(a => Console.WriteLine(a));
        }

        public void PrintSections(string title, IEnumerable<Accounts> AccLists)
        {
            Console.WriteLine($"\n----------------------------------{title}-------------------------------------------\n");
            foreach (var account in AccLists)
            {
                Console.WriteLine(account);
            }

        }

    }
}
