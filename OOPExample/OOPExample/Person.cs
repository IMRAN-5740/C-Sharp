using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace OOPExample
{
    class Person
    {
        //Auto Properties:
        //public string FirstName { get; set; }

        //Properties:

        //private string firstName;
        //public string FirstName
        //{
        //    set
        //    {
        //        if (value.Length >= 2)
        //        {
        //            firstName = value;
        //        }
        //    }

        //    get { return firstName; }
        //}
        //public string firstName;
        //public string middleName;
        //public string lastName;


        //SetMethod & GetMethod

        //public void SetFirstName(string firstName)
        //{
        //    if (firstName.Length >= 2)
        //    {
        //        this.firstName = firstName;
        //    }
        //}
        //public string GetFirstName()
        //{
        //    return firstName;
        //}
        //Get Method
        //public string GetFullName()
        //{
        //    string fullname = firstName + " " + middleName + " " + lastName;
        //    return fullname;    
        //}

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Address PresentAddress { get; set; }
        public string GetFullName()
        {
            string fullname = FirstName + " " + MiddleName + " " + LastName;
            return fullname;
        }
        //Constructor Chaining
        //public Person(string firstName, string middleName, string lastName) : this( firstName,lastName)
        //{
        //    //FirstName = firstName;
        //    MiddleName = middleName;
        //    //LastName = lastName;
        //}
        //Constructor Overloading
        //public Person(string firstName,string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //}
      
        //public string GetFullName1()
        //{
        //    string fullname = FirstName + " " + LastName;
        //    return fullname;
        //}


    }
}
