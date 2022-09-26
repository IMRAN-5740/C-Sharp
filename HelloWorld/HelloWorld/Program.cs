using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = Add(10, 22);
            Console.Write("The Sum of Result is shown below: ");
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static int Add(int firstNum,int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }
        
    }
}
