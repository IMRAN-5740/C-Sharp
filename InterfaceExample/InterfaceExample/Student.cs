using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class Student:IInformation,IPrinter
    {
        public string Name { get; set; }   
        public string RegNo { get; set; }
        public string ID  { get; set; }
        public string Email { get; set; }

        //public string GetBasicInformation()
        //{

        //    return "Student Name :" + Name + " Student Registration No :" + RegNo + " Student ID :" + ID + " Student Email :" + Email + Environment.NewLine;
        //}

        string IInformation.GetBasicInformation()
        {

            return "Student Name :" + Name + " Student Registration No :" + RegNo + " Student ID :" + ID + " Student Email :" + Email + Environment.NewLine;
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void SetIPAddress(string ip)
        {
            throw new NotImplementedException();
        }

        string IPrinter.GetBasicInformation()
        {
            
            return "Student Name :" + Name + " Student Registration No :" + RegNo + " Student ID :" + ID + " Student Email :" + Email + Environment.NewLine;
        }




        //public string StudentInfo()
        //{
        // return "Student Name :" + Name + " Student Registration No :" + RegNo + " Student ID :" + ID + " Student Email :" + Email + Environment.NewLine;
        //}
    }
}
