using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsInterfaces
{
    public interface ICustomer
    {
        string Name { get; }
        int UniqueId { get; }

        void PrintCustomer();
    }
}
