using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
               int val= Convert.ToInt32(Console.ReadLine());
                numbers[i] = val;
            }
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            foreach (var data in numbers)
            {
                Console.WriteLine(data);
            }

            Console.ReadKey();
        }
    }
}
