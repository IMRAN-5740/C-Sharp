using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateWebApp
{
    public partial class HomeUl : System.Web.UI.Page
    {
        public object MessageBox { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            string name;
            name = nameTextBox.Text;
            ViewState["name"] = name;
            ViewState["number"] = 100; 
            nameTextBox.Text = "";
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            string name = (string)ViewState["name"];
            int value = (int)ViewState["number"];
            outputTextBox.Text = name + " " + value;  
        }
    }
}