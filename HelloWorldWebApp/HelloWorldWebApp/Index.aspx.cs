using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorldWebApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            //Response.Write("Mohammad Abdullah Al Imran");
            messageLabel.Text = "Mohammad Abdullah Al Imran";
            //string name = nameTextBox.Value;
            string name = nameTextBox.Text;
            messageLabel.Text = "Hi , Iam  "+name;

        }

 
    }
}