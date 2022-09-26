using System;
using System.Collections.Generic;

namespace OOPExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            department.DeptName = "Computer Science & Engineering";
            department.DeptCode = "CSE001";

            Course course1 = new Course();
            course1.CourseTitle = "Structured Programming Language";
            course1.CourseCode = "CSE-101";
            course1.CourseCredit = 3.0;

            Course course2 = new Course();
            course2.CourseTitle = "Data Structure";
            course2.CourseCode = "CSE-201";
            course2.CourseCredit = 3.0;

            Course course3 = new Course();
            course3.CourseTitle = "Analytical Programming Lab";
            course3.CourseCode = "CSE-305";
            course3.CourseCredit = 2.0;

            //department.Courses = new List<Course>();
            department.Courses.Add(course1);
            department.Courses.Add(course2);
            department.Courses.Add(course3);

           Console.WriteLine( department.GetDeptInfo());
            Console.ReadKey();

        }
    }
}
