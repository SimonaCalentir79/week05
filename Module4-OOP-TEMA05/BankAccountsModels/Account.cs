using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountsInterfaces;

namespace BankAccountsModels
{
    public abstract class Account : IAccount,ICalculateInterest
    {
        public ICustomer Customer { get; }

        public DateTime OpenDate { get; }

        public decimal Balance { get; }

        public decimal InterestRate { get; }

        public Account(ICustomer customer, DateTime openDate, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.OpenDate = openDate;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public abstract decimal CalculateInterest(DateTime dateOfInterest);

        public virtual void PrintAccount()
        {
            this.Customer.PrintCustomer();
            Console.WriteLine($"\t Date of opening: {this.OpenDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"\t Balance: {this.Balance}");
            Console.WriteLine($"\t Interest (%): {this.InterestRate}");
        }
    }
}
