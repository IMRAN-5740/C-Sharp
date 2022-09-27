using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionExample
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string RegNo { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string GetInfo()
        {
            return "Student Id :" + Id + Environment.NewLine + "Student Name :" + Name + Environment.NewLine +"Student Age :"+Age+Environment.NewLine+"Student Registraion No :" + RegNo + Environment.NewLine + "Student Address :" + Address + Environment.NewLine;
        }
    }
    
}
