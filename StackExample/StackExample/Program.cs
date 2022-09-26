using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack aStack = new Stack();
            aStack.Push(10);
            aStack.Push(20.12);
            aStack.Push("Mohammad Imran");
            aStack.Push("Bashar Ovi");
            aStack.Pop();
            
            foreach(var data in aStack)
            {
                Console.WriteLine(data);
            }
            Console.ReadKey();
        }
    }
}
