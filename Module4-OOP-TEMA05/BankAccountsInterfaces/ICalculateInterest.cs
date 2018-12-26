using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsInterfaces
{
    public interface ICalculateInterest
    {
        decimal CalculateInterest(DateTime dateOfInterest);
    }
}
