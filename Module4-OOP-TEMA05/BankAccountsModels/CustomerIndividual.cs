using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsModels
{
    public class CustomerIndividual:Customer
    {
        public CustomerIndividual(string name, int uniqueId) : base(name, uniqueId) { }
    }
}
