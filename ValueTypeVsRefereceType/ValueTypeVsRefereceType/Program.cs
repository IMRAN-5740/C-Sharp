using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace ValueTypeVsRefereceType
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Change(num);
            Console.WriteLine(num);
            Console.ReadKey();
           
            //Person aperson = new Person();
            //aperson.firstName = "Mominul";
            //aperson.middleName = "Bashar";
            //aperson.lastName = "Ovi";
            //Change(aperson);
            //Console.WriteLine(aperson.lastName);
            //Console.ReadKey();
            
        }
        //public static void Change(Person ok)
        //{
        //    ok.firstName = "Mohammad";
           
        //    ok.lastName = "Al Imran";
        //}
        public static void Change(int a)
        {
            a = 20;
        }


    }
}
