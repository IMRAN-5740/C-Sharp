using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityApp.Manager;
using UniversityApp.Models;

namespace UniversityApp.UI
{
    public partial class StudentUI : System.Web.UI.Page
    {
        StudentManager amanager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            studentGridView.DataSource = null;
            studentGridView.DataSource = amanager.GetAllStudents();
            studentGridView.DataBind();
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.StudentID=idTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Department=deptTextBox.Text;
            aStudent.Phone=phoneTextBox.Text;
            aStudent.RegNo = regnoTextBox.Text;
            aStudent.Gender=genderTextBox.Text;
            aStudent.BloodGroup = bgTextBox.Text;
            aStudent.HallName = hallTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.University=universityTextBox.Text;
           
            string message=amanager.SubmitStudent(aStudent);
            DataLoad(); 
            messageLabel.Text = message;
            
        }
    }
}