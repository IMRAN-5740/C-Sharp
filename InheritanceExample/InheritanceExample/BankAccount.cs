using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExample
{
    public abstract class BankAccount
    {
       public BankAccount(string customerName, string accountNo):this()
        {
            CustomerName = customerName;
            AccountNo = accountNo;
           
        }
        public BankAccount()
        {
            Balance = 0;
        }

        public string CustomerName { get; set; }
        public string AccountNo{ get; set; }
        public double Balance { get; private set; }
       

        public string Deposit(double amount)
        {
            Balance=Balance+amount;
            return "Deposited Successfully...";
        }
        public virtual string Withdraw(double amount)
        {
            Balance=Balance-amount;
            return "Withdraw has been Successfull...";
        }

        public abstract void Transfer(string fromAccount, string toAccount, double amount);
        


    }
}
