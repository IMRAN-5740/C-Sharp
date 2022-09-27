using System;

namespace ExtensionMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person();
            person.Id = 101;
            person.Name = "Mohammad Imran";
            person.Address = "Satana Baluya,Gobindaganj,Gaibandha";
            string info=person.GetInfo();
            Console.WriteLine(info);
            Console.ReadKey();
        }
    }
}
