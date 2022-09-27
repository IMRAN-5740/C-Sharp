using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityApp.Manager;
using UniversityApp.Models;

namespace UniversityApp.UI
{
    public partial class StudentEnrollUI : System.Web.UI.Page
    {
        StudentManager aManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                studentNameDropDownList.DataSource = aManager.GetAllStudents();
                studentNameDropDownList.DataTextField = "Name";
                studentNameDropDownList.DataValueField = "StudentID";
                studentNameDropDownList.DataBind();
                courseNameDropDownList.DataSource = aManager.GetAllCourses();
                courseNameDropDownList.DataTextField = "CourseName";
                courseNameDropDownList.DataValueField = "CourseID";
                courseNameDropDownList.DataBind();
            }
            
        }

        protected void enrollButton_Click(object sender, EventArgs e)
        {
            CourseEnroll courseEnroll = new CourseEnroll();
            courseEnroll.StudentID = studentNameDropDownList.SelectedValue;
            courseEnroll.CourseCode = courseNameDropDownList.SelectedValue;
            courseEnroll.DateTime = DateTime.Now;
            string message= aManager.EnrollStudent(courseEnroll);
            messageLabel.Text = message;
        }
    }
}