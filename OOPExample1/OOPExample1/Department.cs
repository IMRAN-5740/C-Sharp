using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample1
{
    class Department
    {
        public Department()
        {
            Courses = new List<Course>();
        }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public List<Course> Courses { get; set; }
        public string GetDeptInfo()
        {
            string info = "Deparment Name :"+DeptName +" "+ "Department Code :"+DeptCode+Environment.NewLine;
            foreach (Course course in Courses)
            {
                info=info+course.GetCourseInfo()+"\n";   
               // Console.WriteLine(course.GetCourseInfo());
            }
            return info;    
        }
    }
}
