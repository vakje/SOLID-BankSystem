using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class BankAccGenerator : IAccountGenerator
    {
        static Random _Random = new Random();
        static int digits = 9;
        static int min = (int)Math.Pow(10, digits - 1); //100 000 000 number

        private static int GenerateRandomId() => _Random.Next(min, int.MaxValue);

        public List<Accounts> CreateBankAccounts => new List<Accounts>
        {
            new Accounts("vako sherozia", 10000, GenerateRandomId()),
            new Accounts("mixo sherozadze", 12000, GenerateRandomId()),
            new Accounts("alexandre sherozedadze", 10000, GenerateRandomId()),
            new Accounts("vakho smitadze", 1000, GenerateRandomId()),
            new Accounts("vaja shukakidze", 10000000, GenerateRandomId())
        };
        public List<DepositAccount> CreateDepositAccounts => new List<DepositAccount>
        {
            new DepositAccount("saxeli saxelashvili", 500000, GenerateRandomId(), 1.3),
            new DepositAccount("saxeli saxelashvdze", 50000, GenerateRandomId(), 1.3),
            new DepositAccount("lashvardi saxelashvili", 500, GenerateRandomId(), 1.3)
        };

        public List<CreditAccount> CreateCreditAccounts => new List<CreditAccount>
        {
            new CreditAccount("raxac raxacashvili", 500000, GenerateRandomId(), 1.7),
            new CreditAccount("rax raxashvili", 1050000, GenerateRandomId(), 10.5)
        };
    }
    public interface IAccountGenerator
    {
        List<Accounts> CreateBankAccounts { get; }
        List<DepositAccount> CreateDepositAccounts { get; }
        List<CreditAccount> CreateCreditAccounts { get; }
    }
}
