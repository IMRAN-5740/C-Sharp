using System;

namespace OOPExample
{
   class Program
    {
        static void Main(string[] args)
        {
            Address address=new Address();
            address.HouseNo = "House No:1/2";
            address.RoadNo = "Road No:1/4";
            address.Area = "Satana Baluya,Gobindadanj,Gaibandha";
            address.PostCode = "5740";
            address.District = "Gaibandha";
            Person person1= new Person();
            person1.PresentAddress=address;


            Address myAddress = person1.PresentAddress;
            string houseNo=myAddress.HouseNo;
              







            //string firstName=Console.ReadLine();
            //string middleName=Console.ReadLine();
            //string lastName=Console.ReadLine();
           // Person person1 = new Person(firstName,middleName,lastName);
          //  Person person2 = new Person(firstName,lastName);
          //  string fullName=person1.GetFullName();
            //string fullName1 = person2.GetFullName1();
            //string firstName=Console.ReadLine();
            //Person person1 = new Person();

            //person1.FirstName = firstName;
            //string name=person1.FirstName;
            ////person1.SetFirstName(firstName);
            ////string name = person1.GetFirstName();


            ////person1.firstName = "Mohammad";

            //person1.middleName = "Abdullah";
            //person1.lastName = "Al Imran";
            //string fullname = person1.GetFullName();
          //  Console.WriteLine(fullName);
          //  Console.WriteLine(fullName1);
         //   Console.ReadKey();
        }
    }
}
