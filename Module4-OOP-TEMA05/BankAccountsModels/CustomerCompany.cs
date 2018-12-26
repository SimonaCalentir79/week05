using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsModels
{
    public class CustomerCompany:Customer
    {
        public CustomerCompany(string name, int uniqueId) : base(name, uniqueId) { }
    }
}
