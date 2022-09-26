using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserDefineTypeApp1
{
    public partial class HomeUI : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            List<Person>persons=new List<Person>();
            Person aperson = new Person();
            aperson.firstName =     firstNameTextBox.Text;
            aperson.middleName=     middleNameTextBox.Text;
            aperson.lastName =      lastnameTextBox.Text; 
            

            if (ViewState["person"]!=null)
            {
                persons = (List<Person>)ViewState["person"];
            }
            persons.Add(aperson);
            ViewState["person"] = persons;
            firstNameTextBox.Text=  String.Empty;
            middleNameTextBox.Text= String.Empty;
            lastnameTextBox.Text=   String.Empty;
        }

        protected void showAllButton_Click(object sender, EventArgs e)
        {
            //  Person bperson = (Person)ViewState["person"];
            List<Person> bperson = (List < Person >) ViewState["person"];
            foreach(var data in bperson)
            {
                string fullname = data.GetFullName();
                nameListBox.Items.Add(fullname);
            }

        }
    }
}