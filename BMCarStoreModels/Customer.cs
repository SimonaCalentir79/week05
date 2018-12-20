using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCarStoreModels
{
    public class Customer:ICustomer
    {
        public string CustomerName { get; }
        public string Email { get; }
        public string TelephoneNumber { get; }

        public Customer(string customerName, string email, string telephoneNumber)
        {
            this.CustomerName = customerName;
            this.Email = email;
            this.TelephoneNumber = telephoneNumber;
        }

        public void PrintCustomer()
        {
            Console.WriteLine($"\t Customer name: {this.CustomerName}, e-mail: {this.Email}, telephone: {this.TelephoneNumber}");
        }
    }
}
