using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCarStoreModels
{
    interface ICustomer
    {
        string CustomerName { get; }
        string Email { get; }
        string TelephoneNumber { get; }
    }
}
