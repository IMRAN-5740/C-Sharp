using System;

namespace ObjectIntializerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Initializer
            Student student = new Student() 
            { Name= "Mohammad Abdulah Al Imran", 
                ID = "18CSE067", 
                Age = 21,
                Address = "Satana Baluya,Gobindaganj,Gaibandha"
            };

            //student.Name = "Mohammad Abdulah Al Imran";
            //student.ID = "18CSE067";
            //student.Age = 21;
            //student.Address = "Satana Baluya,Gobindaganj,Gaibandha";
        }
    }
}
