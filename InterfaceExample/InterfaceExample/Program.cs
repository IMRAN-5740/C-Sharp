using System;
using System.Collections.Generic;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Mohammad Abdullah Al Imran";
            student.RegNo = "BSMRSTU-CSE-08";
            student.ID = "18CSE067";
            student.Email = "imranbsmrstucse@gmail.com";
            //string sInfo=student.GetBasicInformation();

            IInformation st1 = student;
            st1.GetBasicInformation();
            IPrinter printer1 = student;
            printer1.GetBasicInformation();





            Department department = new Department();
            department.Name = "Computer Science & Engineering";
            string fInfo=department.GetBasicInformation();
            Course course = new Course();
            course.Name = "Structured Programming Language";
            string cInfo = course.GetBasicInformation();






            IInformation information = student;
            information = department;
            information = course;
           // IPrinter printer = student;
            List<IInformation> informations = new List<IInformation>();
            informations.Add(student);
            informations.Add(department);
            informations.Add(course);

            Console.ReadKey();

        }
    }
}
