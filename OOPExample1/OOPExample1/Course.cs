using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample1
{
    class Course
    {
        public string CourseTitle { get; set; }
        public string CourseCode { get; set; }
        public double CourseCredit { get; set; }
        
        public string GetCourseInfo()
        {
            return "Course Title : " + CourseTitle + " " + " Course Code : " + CourseCode + " " + "Course Credit : " + CourseCredit;
        }



        Calculator calculator=new Calculator();
        public int GetResult()
        {
            int mid = 20;
            int final = 10;
            int result = calculator.Add(mid, final);
            return result;
        }

    }
}
