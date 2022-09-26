using System;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<bool> student = new Student<bool>();
            student.Name = "Mohammad Abdullah Al Imran";
            student.Success = true;
           // var student = new Student<bool>() { Name = "Mohammad Abdullah Al Imran",Success= true };

            Student<int> student1 = new Student<int>();
            student1.Name = "Mohammad Abdullah Al Imran";
            student1.Success = 1;
           // var student1 = new Student<int>() { Name = "Mohammad Abdullah Al Imran", Success=1 };

            Student<string> student2 = new Student<string>();
            student2.Name = "Mohammad Abdullah Al Imran";
            student2.Success = "Failed";
            // var student2 = new Student<string>() { Name="Mohammad Abdullah Al Imran",Success="Failed"};

            //StudentInt student1 = new StudentInt() { Name = "Mohammad Imran", Success=1 };
            //var student2 = new StudentString() { Name = "Imran", Success = "Failed" };
            //Console.WriteLine(student.Success);
            PrintInfo(student);
            //  Console.WriteLine(student1.Success);
            PrintInfo(student1);
            //Console.WriteLine(student2.Success);
            PrintInfo(student2);
            //Console.WriteLine(student1.Success);
            //Console.WriteLine(student2.Success);
            Console.ReadKey();
        }
        public static void PrintInfo<T>(Student<T> student)
        {
            Console.WriteLine("Student Name :"+student.Name+Environment.NewLine+"Student Status :"+student.Success+Environment.NewLine);
        }
    }
    public class Student<T>
    {
        //Generics Use
        public string Name { get; set; }
        public T Success { get; set; }
    }
    //public class StudentInt
    //{
    //    public string Name { get; set; }
    //    public int Success { get; set; }
    //}
    //public class StudentString
    //{
    //    public string Name { get; set; }
    //    public string Success { get; set; }
    //}

}
