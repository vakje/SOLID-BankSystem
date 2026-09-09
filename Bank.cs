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
       public static List<Accounts> accounts;
        /// <summary>
        /// abrundebs yvelaze didi balancis mqone akauntebs martivi sortis methodit 
        /// </summary>
        /// <param name="account1"></param>
        /// <returns></returns>
        public static List<DepositAccount> bigamountofmoney( List<DepositAccount> account1 )
        {

           
            // desc order
            account1.Sort((p1,p2)=>p2.Balance.CompareTo(p1.Balance));
            List< DepositAccount > top3 = new List<DepositAccount>();
            int i = 0;
            // shedis pirveli 3 akaunti am siashi radgan pirveli valuebi sul didebi iqnebian 
            while (i < 3&& i< account1.Count() ) {

                top3.Add(account1[i]);
                i++;
            }
            return top3;
            

            
        }
        /// <summary>
        /// abrundebs yvelaze patara balancis mqone akauntebs martivi sortis methodit 
        /// </summary>
        /// <param name="account1"></param>
        /// <returns></returns>
        public static List<CreditAccount> bigamountofdept(List<CreditAccount> account1 )
        {

           
            //asc
            account1.Sort((p1, p2) => p1.Balance.CompareTo(p2.Balance));
            List<CreditAccount> bottom3 = new List<CreditAccount>();
            int i = 0;
            // shedis pirveli 3 akaunti am siashi radgan pirveli valuebi sul patarebi iqnebian 
            while (i < 3&&i < account1.Count())
            {

                bottom3.Add(account1[i]);
                i++;
            }

            return bottom3;

        }

    }
}
