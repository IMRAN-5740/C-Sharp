using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityApp.Gateway;
using UniversityApp.Models;

namespace UniversityApp.Manager
{
    
    public class StudentManager
    {
        StudentGateway aGateway=new StudentGateway();
        

        public string SubmitStudent(Student astudent)
        {
            if (astudent.Name == "")        return "Please Enter Your Name";
            if (astudent.StudentID == "")   return "Please Provide Your Student Id";
            if (astudent.Email == "")       return "Please Provide Your Email";
            if (astudent.Department == "")  return "Please Enter Your Department";
            if (astudent.Phone == "")       return "Please Provide Your Phone Number";
            if (astudent.RegNo == "")       return "Please Provide Your Registration Number";
            if (astudent.Gender == "")      return "Please Select Your Gender";
            if (astudent.BloodGroup == "")  return "Please Select Your Blood Group";
            if (astudent.HallName == "")    return "Please Provide your Hall Name";
            if (astudent.Address == "")     return "Please Provide Your Address";
            if (astudent.University == "")  return "Please Provide Your University Name";
            
            if (aGateway.IsExistRegNo(astudent.RegNo))
            {
                return "This Registration No is Already Exist..!";
            }
            int rowCount=aGateway.SubmitStudent(astudent);
            if(rowCount>0)
            {
                return "Data has been Inserted Successfully...";
            }
            else
            {
                return "Data is Not Inserted.....!";
            }

        }
        public List<Student> GetAllStudents()
        {
            return aGateway.GetAllStudents();
        }
        public  Student SearchStudentByRegNo(string RegNo)
        {
            return aGateway.SearchStudentByRegNo(RegNo);
        }


        public string DeleteStudent(string RegNo)
        {
            int rowCount = aGateway.DeleteStudent(RegNo);
            if(rowCount>0)
            {
                return "Deleted a Student Data Successfully";
            }
            else
            {
                return "Delete Failed";
            }
        }
        public string UpdateStudent(Student student)
        {
            int rowCount = aGateway.UpdateStudent(student);
            if (rowCount > 0)
            {
                return " Student Data Has been Updated Successfully.";
            }
            else
            {
                return "Student Data Not Updated Try Again..!";
            }
        }
    }
}