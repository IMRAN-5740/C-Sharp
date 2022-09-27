using System;

namespace ReflectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();
            var studentInfo = typeof(Student);
            string assemblyName=studentInfo.Assembly.FullName;
            Console.WriteLine(assemblyName);
            var methods=studentInfo.GetMethods();
            //foreach (var method in methods)
            //{
            //    Console.WriteLine("Return Type :"+method.ReturnType+"Name :"+method.Name);
            //}
            var Properties=studentInfo.GetProperties();
            foreach (var property in Properties)
            {
                Console.WriteLine(property.Name);
            }
            Console.ReadKey();
        }
    }
}
