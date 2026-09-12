using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public interface IAccountGenerator
    {
        List<Accounts> CreateBankAccounts { get; }
        List<DepositAccount> CreateDepositAccounts { get; }
        List<CreditAccount> CreateCreditAccounts { get; }
    }
}
