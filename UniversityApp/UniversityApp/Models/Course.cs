using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityApp.Models
{
    public class Course
    {
        public string CourseName { get; set; }
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public decimal CourseCredit { get; set; }

    }
}