using System;

namespace DelegateExample1
{
    internal class Program
    {
        public delegate T PrintHandeler<T>(T value);
        public delegate TResult Func<in T, out TResult>(T param);

      static void Main(string[] args)
        {
            //Func<int, int, int> CalculatoHandeler = Add;
            //Func<int, int, int> CalculatoHandeler = (int p, int q) =>
            //{
            //    return p + q;
            //};
            Func<int, int, int> CalculatoHandeler = (int p, int q) =>p + q;
            int result = CalculatoHandeler(10, 20);
            Console.WriteLine(result);
            PrintHandeler<string> printHandeler = Hello;
            printHandeler += GoodBye;
            printHandeler.Invoke("Mohammad Abdullah Al Imran");
            Console.WriteLine(".............");
            Console.WriteLine(".............");

            PrintHandeler<string> printHandeler1 = printHandeler;
            printHandeler -= GoodBye;
            printHandeler.Invoke("Mohammad Abdullah Al Imran");
            Console.ReadKey();
        }

        static string Hello<T>(T name)
        {
            Console.WriteLine("Hello..! "+name);
            return " ";
        }

        static string GoodBye<T>(T name)
        {
            Console.WriteLine("Good Bye..! " + name);
            return "";
        }

        static int Add(int firstNum,int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
