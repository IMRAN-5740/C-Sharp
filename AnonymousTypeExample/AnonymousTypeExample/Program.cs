using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AnonymousTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //var student1 = new
            //{
            //    Name        = "Mohammad Abdullah Al Imran",
            //    RegNo       = "BSMRSTU-CSE-08",
            //    Id          = "18CSE067",
            //    Age         = 21,
            //    Email       = "imranbsmrstucse@gmail.com",
            //    Address     = "Saatana Baluya,Gobindaganj,Gaibandha"
            //};

            var studentList = new[]
            {
                new{Name        = "Mohammad Abdullah Al Imran",
                RegNo       = "BSMRSTU-CSE-09",
                Id          = "19CSE067",
                Age         = 22,
                Email       = "cse19@gmail.com",
                Address     = "Saatana Baluya,Gobindaganj,Gaibandha"
                },
                new
                {
                    Name        = "Mohammad Imran",
                RegNo       = "BSMRSTU-CSE-09",
                Id          = "19CSE067",
                Age         = 22,
                Email       = "cse19@gmail.com",
                Address     = "Saatana Baluya,Gobindaganj,Gaibandha"},
                new
                {
                    Name        = "Imran",
                RegNo       = "BSMRSTU-CSE-10",
                Id          = "20CSE067",
                Age         = 20,
                Email       = "cse20@gmail.com",
                Address     = "Saatana Baluya,Gobindaganj,Gaibandha"
                },
                new
                {
                    Name        = "Abdullah Al Imran",
                RegNo       = "BSMRSTU-CSE-08",
                Id          = "17CSE067",
                Age         = 22,
                Email       = "cse17@gmail.com",
                Address     = "Saatana Baluya,Gobindaganj,Gaibandha"
                }
            };

            var searchList = studentList.Where(c => c.Name.StartsWith("M")).ToList();
            foreach (var info in searchList)
            {
                Console.WriteLine(info.Name);
            }
            Console.WriteLine();
            foreach (var data in studentList)
            {
                Console.WriteLine(data.Name); 
            }
          
         //   Console.WriteLine(student);
            
          //  Console.WriteLine(student1);
            Console.ReadKey();
        }
    }
}
