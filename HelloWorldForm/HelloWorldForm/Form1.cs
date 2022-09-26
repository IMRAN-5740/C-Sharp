using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForm
{
    public partial class HelloAppUI : Form
    {
        public HelloAppUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //string name = firstNameTextBox.Text;
            //MessageBox.Show("Hi "+name+", Welcome To Show Button","Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if(firstNameTextBox.Text.Trim()=="")
            {
                MessageBox.Show("Please Require to Fill First Name..!");
                firstNameTextBox.Focus();
                return;
            }
            string firstName    = firstNameTextBox.Text;
            string middleName   = middleNameTextBox.Text;
            string lastName     = lastNameTextBox.Text;

            string fullName      = firstName + " " + middleName + " " + lastName;
            fullNameTextBox.Text = fullName;
            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        
    }
}
