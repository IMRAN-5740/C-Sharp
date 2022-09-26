using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityApp.Manager;
using UniversityApp.Models;
using static System.Net.Mime.MediaTypeNames;

namespace UniversityApp.UI
{
    public partial class StudentEdit : System.Web.UI.Page
    {
        StudentManager aManager=new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string RegNo=regnoTextBox.Text;
            Student astudent = aManager.SearchStudentByRegNo(RegNo); 
            nameTextBox.Text        = astudent.Name;
            idTextBox.Text          = astudent.StudentID;
            emailTextBox.Text       = astudent.Email;
            deptTextBox.Text        = astudent.Department;
            phoneTextBox.Text       = astudent.Phone;
            updateregnoTextBox.Text = astudent.RegNo;
            genderTextBox.Text      = astudent.Gender;
            bgTextBox.Text          = astudent.BloodGroup;
            hallTextBox.Text        = astudent.HallName;
            addressTextBox.Text     = astudent.Address;
            universityTextBox.Text  = astudent.University;

        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            string RegNo = regnoTextBox.Text;
            string message = aManager.DeleteStudent(RegNo);
            messageLabel.Text = message;
            //nameTextBox.Text        = " ";
            //idTextBox.Text          = " ";
            //emailTextBox.Text       = " ";
            //deptTextBox.Text        = " ";
            //phoneTextBox.Text       = " ";
            //updateregnoTextBox.Text = " ";
            //genderTextBox.Text      = " ";
            //bgTextBox.Text          = " ";
            //hallTextBox.Text        = " ";
            //addressTextBox.Text     = " ";
            //universityTextBox.Text  = " ";
            ClearAllTextBoxes();

        }



        private void ClearAllTextBoxes()
        {
            nameTextBox.Text = " ";
            idTextBox.Text = " ";
            emailTextBox.Text = " ";
            deptTextBox.Text = " ";
            phoneTextBox.Text = " ";
            updateregnoTextBox.Text = " ";
            genderTextBox.Text = " ";
            bgTextBox.Text = " ";
            hallTextBox.Text = " ";
            addressTextBox.Text = " ";
            universityTextBox.Text = " ";
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student astudent = new Student();
            astudent.Name = nameTextBox.Text;
            astudent.StudentID = idTextBox.Text;
            astudent.Email = emailTextBox.Text;
            astudent.Department = deptTextBox.Text;
            astudent.Phone = phoneTextBox.Text;
            astudent.RegNo = regnoTextBox.Text;
            astudent.Gender = genderTextBox.Text;
            astudent.BloodGroup = bgTextBox.Text;
            astudent.HallName = hallTextBox.Text;
            astudent.Address = addressTextBox.Text;
            astudent.University = universityTextBox.Text;
            messageLabel.Text= aManager.UpdateStudent(astudent);
            ClearAllTextBoxes();
        }
    }
}