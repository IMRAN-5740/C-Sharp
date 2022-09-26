using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class Department:IInformation,IPrinter
    {
        public Department()
        {
            Students = new List<Student>();
            Courses  =new List<Course>();
        }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        //public string FindInfo()
        //{
           // return "Department Name :" + Name + " Department Code :" + Code + " Total Students :" + Students.Count + Environment.NewLine;
        //}

        public string GetBasicInformation()
        {
           
            return "Department Name :" + Name + " Department Code :" + Code + " Total Students :" + Students.Count + Environment.NewLine;
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void SetIPAddress(string ip)
        {
            throw new NotImplementedException();
        }
    }
}
