using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserDefineTypeApp1
{
    [Serializable]
    public class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string GetFullName()
        {
            string fullname = firstName + " " + middleName + " " + lastName;
            return fullname;
        }
    }
}