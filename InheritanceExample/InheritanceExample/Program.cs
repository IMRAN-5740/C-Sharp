using System;
using System.Collections.Generic;

namespace InheritanceExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //BankAccount bankAccount = new BankAccount();
            
            //Saving
            SavingsAccount savingsAccount = new SavingsAccount("Mohammad Abdullah Al Imran","SA-MTB-Graduate-178394",798.00);
            savingsAccount.Deposit(500);
            DateTime date = DateTime.Now;
            savingsAccount.Transfer("Mirpur Branch","Bashundhara Branch",23,date);
            savingsAccount.Transfer("","",98);

           // savingsAccount.CustomerName = "Mohammad Abdullah Al Imran";
           // savingsAccount.AccountNo = "SA-MTB-Graduate-138577";
           // savingsAccount.InterestAmount=174.00;
           //Console.WriteLine( savingsAccount.Deposit(1000));
           //Console.WriteLine( savingsAccount.Withdraw(1200));

           // double balance = savingsAccount.Balance;

            //Checking 
            CheckingAccount checkingAccount = new CheckingAccount("Al Imran", "CA-MTB-Graduate-138577", 75668.00);
            checkingAccount.Deposit(1500);
            //checkingAccount.CustomerName = "Mohammad Mominul Bashar";
            //checkingAccount.AccountNo = "CA-MTB-Graduate-178394";
            //checkingAccount.ServiceCharge = 125;
            //Console.WriteLine(checkingAccount.Deposit(105500));
            //Console.WriteLine(checkingAccount.Withdraw(1055011));
            //balance = checkingAccount.Balance;
            checkingAccount.Transfer("","",099);

            

            //BankAccount
            //BankAccount bankAccount1 = savingsAccount;
            //Console.WriteLine();
            //  SavingsAccount savingAccount1 = (SavingsAccount)bankAccount1;
            //  double interestAmount =savingAccount1.InterestAmount;
            //  BankAccount bankAccount2 = new SavingsAccount();
            ////  bankAccount2.
            //  BankAccount bankAccount3 = new CheckingAccount();

            //BankAccount b1 = new BankAccount();

            //b1.CustomerName = "Imran";
            //b1.AccountNo = "1001";
            //b1.Deposit(700);
            //List<BankAccount>account = new List<BankAccount>();
            //account.Add(b1);    
            //account.Add(savingsAccount);
            //account.Add(checkingAccount);
            //foreach(BankAccount bankAccount in account)
            //{
            //    bankAccount.Withdraw(1000);
            //}
            BankAccount b2 = savingsAccount;
            b2.Transfer();
              Console.ReadKey();

        }
    }
}
