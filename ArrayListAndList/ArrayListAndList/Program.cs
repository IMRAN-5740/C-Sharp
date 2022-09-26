using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Mohammad Imran");
            names.Add("Bashar Ovi");
            names.Add("Abdullah Al Muhit");

            foreach (var data in names)
            {
                if (data =="Bashar Ovi")
                {
                    Console.WriteLine("This User is Found");
                    break;
                }
                Console.WriteLine(data);
            }
            Console.WriteLine(names.Count());
            Console.ReadKey();
        }
    }
}
