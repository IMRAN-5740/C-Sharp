using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityApp.Models
{
    public class CourseEnroll
    {
        public int Id { get; set; }
        public string StudentID { get; set; }
        public string CourseCode { get; set; }
        public DateTime DateTime { get; set; }

    }
}