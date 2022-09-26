using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class Course:IInformation
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Credit { get; set; }
        //public List<string> CourseInfo()
        //{
        //    List<string> list = new List<string>();
        //    list.Add(Name);
        //    list.Add(Code);   
        //    list.Add(Credit);
        //    return list;

        //}

        public string GetBasicInformation()
        {
            return "Course Name :" + Name + " Course Code :" + Code + " Course Credit : " + Credit+Environment.NewLine;
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
