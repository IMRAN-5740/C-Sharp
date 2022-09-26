using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExample
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string customerName,string accountNo,double interestAmount):base(customerName,accountNo)
        {
            //CustomerName = customerName;
            //AccountNo = accountNo; 
            InterestAmount = interestAmount;
        }

        //Savings Account
        public double InterestAmount { get; set; }

        public override void Transfer(string fromAccount, string toAccount, double amount)
        {
           // throw new NotImplementedException();
           //todo
        }

        public override string Withdraw(double amount)
        {
            if(Balance>=amount)
            {
                return base.Withdraw(amount);
            }
            else
            {
                return "Insufficient Balance ";
            }
        }

        //public override void Transfer(string fromAccount, string toAccount, double amount)
        //{
        //    base.Transfer(fromAccount, toAccount, amount);
        //}
        //public override void Transfer(string fromAccount, string toAccount, double amount,DateTime date)
        //{
        //   //todo
        //}
    }
}
