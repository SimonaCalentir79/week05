using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountsInterfaces;

namespace BankAccountsModels
{
    public abstract class Customer : ICustomer
    {
        public string Name { get; }

        public int UniqueId { get; }

        public Customer(string name, int uniqueId)
        {
            this.Name = name;
            this.UniqueId = uniqueId;
        }

        public virtual void PrintCustomer()
        {
            Console.WriteLine($"\n\t Customer: {this.Name}");
        }
    }
}
