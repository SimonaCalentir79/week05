using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountsInterfaces;

namespace BankAccountsModels
{
    public class AccountMortgage : Account, IDepositMoney 
    {
        public int ApprovedMonths { get; }
        public AccountMortgage(ICustomer customer, DateTime openDate, decimal balance, decimal interestRate, int months) : base(customer, openDate, balance, interestRate)
        {
            this.ApprovedMonths = months;
        }

        public override decimal CalculateInterest(DateTime dateOfInterest)
        {
            if (this.Customer.GetType().Name.ToLower().Contains("individual") && dateOfInterest < this.OpenDate.AddDays(180))
                return 0;
            if (this.Customer.GetType().Name.ToLower().Contains("company") && dateOfInterest < this.OpenDate.AddDays(360))
                return Math.Round(this.Balance * this.InterestRate/100 / 12 / 2,2);
            return Math.Round(this.Balance * this.InterestRate/100 / 12,2);
        }

        public decimal Deposit(DateTime dateOfDeposit)
        {
            if (this.CalculateInterest(dateOfDeposit)!=0)
                return Math.Round((this.Balance - this.CalculateInterest(dateOfDeposit) - this.Balance/240),2);
            return this.Balance;
        }

        public override void PrintAccount()
        {
            this.Customer.PrintCustomer();
            Console.WriteLine($"\t Type of account: {this.GetType().Name.ToUpper()}");
            Console.WriteLine($"\t Date of opening: {this.OpenDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"\t Balance: {this.Balance} RON");
            Console.WriteLine($"\t Months for reimbursement: {this.ApprovedMonths}");
            Console.WriteLine($"\t Interest rate (%): {this.InterestRate}");
        }
    }
}
