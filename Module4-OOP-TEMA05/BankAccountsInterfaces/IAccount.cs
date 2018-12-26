using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsInterfaces
{
    public interface IAccount
    {
        ICustomer Customer { get; }
        DateTime OpenDate { get; }
        decimal Balance { get; }
        decimal InterestRate { get; }

        void PrintAccount();
    }
}
