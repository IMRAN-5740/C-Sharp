using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateWithCollection
{
    public partial class ViewStateWithCollection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        List<string> namelist = new List<string>();
      

        protected void submitButton_Click(object sender, EventArgs e)
        {
            if (ViewState["names"]!=null)
            {
                namelist = (List<string>)ViewState["names"];
            }
            string name=nameTextBox.Text;
           
            namelist.Add(name);
            ViewState["names"] = namelist;
        }

        protected void showAllButton_Click(object sender, EventArgs e)
        {
            namelist = (List<string>)ViewState["names"];
            nameListBox.Items.Clear();
            foreach(var data in namelist)
            {
                nameListBox.Items.Add(data);
            }
        }
    }
}