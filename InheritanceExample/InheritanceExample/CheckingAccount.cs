using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace InheritanceExample
{
    public class CheckingAccount : BankAccount
    {
       public CheckingAccount(string customerName,string accountNo,double serviceCharge):base(customerName,accountNo)
        {
            //CustomerName = customerName;
            //AccountNo = accountNo;  
            ServiceCharge=ServiceCharge;
        }
        //Checking Account/Current Account
        public double ServiceCharge { get; set; }
        public void TR(string toAccount, double amount)
        {
            //todo
        }

        public override void Transfer(string fromAccount, string toAccount, double amount)
        {
           // throw new NotImplementedException();
           //todo
        }
    }

   

}
