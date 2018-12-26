using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreInterfaces
{
    public interface ICustomer
    {
        string Name { get; }

        string Email { get; }

        string Phone { get; }

        void PrintCustomer();
    }
}
