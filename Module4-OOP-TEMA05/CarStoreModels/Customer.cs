using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreInterfaces;

namespace CarStoreModels
{
    public class Customer : ICustomer
    {
        public string Name { get; }

        public string Email { get; }

        public string Phone { get; }

        public Customer(string name, string email, string phone)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }

        public void PrintCustomer()
        {
            Console.WriteLine($"\t Customer name: {this.Name.ToUpper()} , email: {this.Email}, phone: {this.Phone}");
        }
    }
}
