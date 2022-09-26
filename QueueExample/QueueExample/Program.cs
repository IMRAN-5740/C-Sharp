using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue aQueue = new Queue();
            aQueue.Enqueue(10);
            aQueue.Enqueue("Mohammad Imran");
            aQueue.Enqueue("Bashar Ovi");
            aQueue.Enqueue(20.33);
            aQueue.Dequeue();
            foreach (var data in aQueue)
            {
                Console.WriteLine(data);
            }
            Console.ReadKey();
        }
    }
}
