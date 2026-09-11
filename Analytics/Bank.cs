using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public static class Bank
    {
        public static List<Accounts> _Accounts;
   
        public static List<DepositAccount> GetTopThreeDepositAccounts(List<DepositAccount> accounts)
        {
            // desc 
            return accounts.OrderByDescending(a => a._Balance).Take(3).ToList();
        }
        public static List<CreditAccount> GetTopThreeCreditDebts(List<CreditAccount> accounts)
        {
            //asc
            return accounts.OrderBy(a => a._Balance).Take(3).ToList();
        }

    }
}
