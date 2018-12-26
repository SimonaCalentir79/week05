using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountsInterfaces;

namespace BankAccountsModels
{
    public class AccountDeposit : Account, IDepositMoney, IWithdrawMoney
    {
        public decimal CollectionValue { get; }
        public DateTime DateOfCollection { get; }
        public decimal PaymentValue { get; }
        public DateTime DateOfWithdraw { get; }

        public AccountDeposit(ICustomer customer, DateTime openDate, decimal balance, decimal interestRate, decimal collectionValue, DateTime dateOfCollection, decimal paymentValue, DateTime dateOfWithdraw) : base(customer, openDate, balance, interestRate)
        {
            this.CollectionValue = collectionValue;
            this.DateOfCollection = dateOfCollection;
            this.PaymentValue = paymentValue;
            this.DateOfWithdraw = dateOfWithdraw;
        }
        

        public override decimal CalculateInterest(DateTime dateOfInterest)
        {
            if (this.Balance < 1000)
                return 0;
            return Math.Round(this.Balance * this.InterestRate/100 / 360,2);
        }

        public decimal Deposit(DateTime dateOfInterest)
        {
            decimal noOfDays = (decimal)(dateOfInterest - this.OpenDate).TotalDays;
            decimal interestOfCollection = this.CollectionValue * this.InterestRate / 100 / 360;

            return Math.Round(this.Balance + this.CollectionValue + this.CalculateInterest(dateOfInterest) * noOfDays + interestOfCollection*noOfDays,2);
        }

        public decimal Payment(DateTime dateOfWithdraw)
        {
            return Math.Round(this.Deposit(dateOfWithdraw) - this.PaymentValue,2);
        }

        public override void PrintAccount()
        {
            this.Customer.PrintCustomer();
            Console.WriteLine($"\t Type of account: {this.GetType().Name.ToUpper()}");
            Console.WriteLine($"\t Date of opening: {this.OpenDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"\t Balance: {this.Balance} RON");
            Console.WriteLine($"\t Interest rate (%): {this.InterestRate}");
        }
    }
}
