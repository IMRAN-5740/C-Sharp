using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicTypeExample
{
    public class Student
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string StudentInfo()
        {
            return "Student Name :" + Name + Environment.NewLine + "Student Registration No :" + RegNo + Environment.NewLine + "Student ID :" + ID + Environment.NewLine + "Student Email Address :" + Email + Environment.NewLine + "Student Address :" + Address + Environment.NewLine;
        }

        
    }
}
