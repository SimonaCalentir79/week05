using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountsInterfaces;
using BankAccountsModels;


namespace BankAccountsApp
{
    class Program
    {
        static void Main()
        {
            ICustomer customer1 = new CustomerIndividual("PERSOANA FIZICA",123);
            ICustomer customer2 = new CustomerCompany("COMPANIE", 456);

            AccountLoan contImprumutPF = new AccountLoan(customer1,new DateTime(2018,09,01),30000,(decimal)8.5,60);
            contImprumutPF.PrintAccount();//primele 90 zile -> dobanda 0
            Console.WriteLine("\t Interest value on {0} (during the first 90 days) is {1} RON/month and remaining balance will be {2} RON.",
                contImprumutPF.OpenDate.AddDays(85).ToString("dd.MM.yyyy"),
                contImprumutPF.CalculateInterest(contImprumutPF.OpenDate.AddDays(85)),
                contImprumutPF.Deposit(contImprumutPF.OpenDate.AddDays(85)));
            Console.WriteLine("\t Interest value on {0} (after the first 90 days) is {1} RON/month and remaining balance will be {2} RON.", 
                contImprumutPF.OpenDate.AddDays(125).ToString("dd.MM.yyyy"), 
                contImprumutPF.CalculateInterest(contImprumutPF.OpenDate.AddDays(125)),
                contImprumutPF.Deposit(contImprumutPF.OpenDate.AddDays(125)));

            AccountLoan contImprumutPJ = new AccountLoan(customer2, new DateTime(2018,09,01),1500000,(decimal)5.5,60);
            contImprumutPJ.PrintAccount();//primele 60 zile -> dobanda 0
            Console.WriteLine("\t Interest value on {0} (during the first 60 days) is {1} RON/month and remaining balance will be {2} RON.",
                contImprumutPJ.OpenDate.AddDays(45).ToString("dd.MM.yyyy"),
                contImprumutPJ.CalculateInterest(contImprumutPJ.OpenDate.AddDays(45)),
                contImprumutPJ.Deposit(contImprumutPJ.OpenDate.AddDays(45)));
            Console.WriteLine("\t Interest value on {0} (after the first 60 days) is {1} RON/month and remaining balance will be {2} RON.", 
                contImprumutPJ.OpenDate.AddDays(65).ToString("dd.MM.yyyy"),
                contImprumutPJ.CalculateInterest(contImprumutPJ.OpenDate.AddDays(65)),
                contImprumutPJ.Deposit(contImprumutPJ.OpenDate.AddDays(65)));

            AccountMortgage contIpotecaPF = new AccountMortgage(customer1,new DateTime(2018,09,01),50000,(decimal)4.5,240);
            contIpotecaPF.PrintAccount();//primele 180 zile -> dobanda 0
            Console.WriteLine("\t Interest value on {0} (during the first 180 days) is {1} RON/month and remaining balance will be {2} RON.",
                contIpotecaPF.OpenDate.AddDays(175).ToString("dd.MM.yyyy"),
                contIpotecaPF.CalculateInterest(contIpotecaPF.OpenDate.AddDays(175)),
                contIpotecaPF.Deposit(contIpotecaPF.OpenDate.AddDays(175)));
            Console.WriteLine("\t Interest value on {0} (after the first 180 days) is {1} RON/month and remaining balance will be {2} RON.", 
                contIpotecaPF.OpenDate.AddDays(185).ToString("dd.MM.yyyy"),
                contIpotecaPF.CalculateInterest(contIpotecaPF.OpenDate.AddDays(185)),
                contIpotecaPF.Deposit(contIpotecaPF.OpenDate.AddDays(185)));

            AccountMortgage contIpotecaPJ = new AccountMortgage(customer2, new DateTime(2018, 09, 01), 2500000, (decimal)2.5,120);
            contIpotecaPJ.PrintAccount();//primele 360 zile -> dobanda la jumatate
            Console.WriteLine("\t Interest value on {0} (during the first 360 days) is {1} RON/month (half of the value) and remaining balance will be {2} RON.",
                contIpotecaPJ.OpenDate.AddDays(350).ToString("dd.MM.yyyy"),
                contIpotecaPJ.CalculateInterest(contIpotecaPJ.OpenDate.AddDays(350)),
                contIpotecaPJ.Deposit(contIpotecaPJ.OpenDate.AddDays(350)));
            Console.WriteLine("\t Interest value on {0} (after the first 360 days) is {1} RON/month and remaining balance will be {2} RON.", 
                contIpotecaPJ.OpenDate.AddDays(380).ToString("dd.MM.yyyy"),
                contIpotecaPJ.CalculateInterest(contIpotecaPJ.OpenDate.AddDays(380)),
                contIpotecaPJ.Deposit(contIpotecaPJ.OpenDate.AddDays(380)));

            AccountDeposit contDepozitPF = new AccountDeposit(customer1,new DateTime(2018,09,01),1500,(decimal)1.5,1000,new DateTime(2018,11,15),700,new DateTime(2018,12,10));
            contDepozitPF.PrintAccount();//balance > 1.000
            Console.WriteLine("\t Interest value on {0} is {1} RON/day for the balance (If balance < 1.000 RON, the interest is 0 RON/day).",
                contDepozitPF.DateOfCollection.ToString("dd.MM.yyyy"),
                contDepozitPF.CalculateInterest(contDepozitPF.DateOfCollection));
            Console.WriteLine("\t After a deposit of {0} RON on {1}, the balance is {2} RON.",
                contDepozitPF.CollectionValue,
                contDepozitPF.DateOfCollection.ToString("dd.MM.yyyy"),
                contDepozitPF.Deposit(contDepozitPF.DateOfCollection));
            Console.WriteLine("\t After a withdraw of {0} RON on {1}, the balance is {2} RON.",
                contDepozitPF.PaymentValue,
                contDepozitPF.DateOfWithdraw.ToString("dd.MM.yyyy"),
                contDepozitPF.Payment(contDepozitPF.DateOfWithdraw));

            AccountDeposit contDepozitPJ = new AccountDeposit(customer2, new DateTime(2018, 09, 01), 500, (decimal)1.5, 1000, new DateTime(2018, 11, 15), 700, new DateTime(2018, 12, 10));
            contDepozitPJ.PrintAccount();//balance > 1.000
            Console.WriteLine("\t Interest value on {0} is {1} RON/day for the balance (If balance < 1.000 RON, the interest is 0 RON/day).",
                contDepozitPJ.DateOfCollection.ToString("dd.MM.yyyy"),
                contDepozitPJ.CalculateInterest(contDepozitPJ.DateOfCollection));
            Console.WriteLine("\t After a deposit of {0} RON on {1}, the balance is {2} RON.",
                contDepozitPJ.CollectionValue,
                contDepozitPJ.DateOfCollection.ToString("dd.MM.yyyy"),
                contDepozitPJ.Deposit(contDepozitPJ.DateOfCollection));
            Console.WriteLine("\t After a withdraw of {0} RON on {1}, the balance is {2} RON.",
                contDepozitPJ.PaymentValue,
                contDepozitPJ.DateOfWithdraw.ToString("dd.MM.yyyy"),
                contDepozitPJ.Payment(contDepozitPJ.DateOfWithdraw));

            Console.ReadLine();
        }
    }
}
