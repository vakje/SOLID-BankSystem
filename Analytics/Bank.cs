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
   
        public static List<DepositAccount> bigamountofmoney( List<DepositAccount> account1 )
        {
            // desc order
            account1.Sort((p1,p2)=>p2._Balance.CompareTo(p1._Balance));
            List< DepositAccount > top3 = new List<DepositAccount>();
            int i = 0;
        
            while (i < 3&& i< account1.Count() ) {

                top3.Add(account1[i]);
                i++;
            }
            return top3;  
        }
        public static List<CreditAccount> bigamountofdept(List<CreditAccount> account1 )
        {
            //asc
            account1.Sort((p1, p2) => p1._Balance.CompareTo(p2._Balance));
            List<CreditAccount> bottom3 = new List<CreditAccount>();
            int i = 0;
             
            while (i < 3&&i < account1.Count())
            { 
                bottom3.Add(account1[i]);
                i++;
            }

            return bottom3;

        }

    }
}
