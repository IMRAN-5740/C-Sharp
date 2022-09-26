using System;
using System.Numerics;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)OrderStatus.OrderPlace);
            Console.WriteLine((int)OrderStatus.OrderConfirmed);
            Console.WriteLine((int)OrderStatus.Packaging);
            Console.WriteLine((int)OrderStatus.Delivering);
            Console.WriteLine((int)OrderStatus.Received);


            int Status = Convert.ToInt32(Console.ReadLine());
            if(Status == (int)OrderStatus.OrderPlace)
            {
                Console.WriteLine("Thank You, Your Order is now placed .....");
            }
            else if(Status == (int)OrderStatus.OrderConfirmed)
            {
                Console.WriteLine("Dear Customer, Your Order is now Confirmed,Stay With Us ,Happy Shopping .....");
            }
            else if(Status == ((int)OrderStatus.Packaging))
            {
                Console.WriteLine("Dear Customer, Your Order is now Packed ,Wait for Delivering .....");
            }
            else if(Status==(int)OrderStatus.Delivering)
            {
                Console.WriteLine("Dear Customer, Our Rider has Picked up your Order .");
            }
            else if(Status==((int)OrderStatus.Received))
            {
                Console.WriteLine("Congrats.!,  Dear Customer, Our Rider is now On the Way for Delevering Product Please Drop your Order in the Few Times."); ;
            }
            Console.ReadKey();
        }
    }
}
