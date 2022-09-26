using System;

namespace DynamicTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dynamicVariable = 12;
            //dynamicVariable = "Mohammad Abdullah Al Imran";
            //dynamicVariable=true;
            dynamicVariable = new Student();
            dynamicVariable.Name = "Mohammad Abdullah Al Imran";
            dynamicVariable.RegNo = "BSMRSTU-CSE-08";
            dynamicVariable.ID = "18CSE067";
            dynamicVariable.Email = "imranbsmrstucse@gmail.com";
            dynamicVariable.Address = "Satana Baluya,Gobindaganj,Gaibandha";
            Console.WriteLine("Student Information :");
            Console.WriteLine(dynamicVariable.StudentInfo());
            Console.ReadKey();
        }
    }
}
