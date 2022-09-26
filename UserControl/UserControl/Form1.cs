using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            string value = departmentComboBox.Text;
            MessageBox.Show(value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> departmentList = new List<string>();
            departmentList.Add("....Select....");
            departmentList.Add("Computer Science and Engineering");
            departmentList.Add("ELectronics and Electrical Engineering");
            departmentList.Add("Applied Chemistry and Chemical Engineering ");
            departmentList.Add("Civil Engineering");
            departmentList.Add("Food and Agro-Process Engineering");
            departmentList.Add("Architecture");

            //departmentComboBox.DataSource = departmentList;


            //departmentComboBox.Items.Add("Computer Science and Engineering");
            //departmentComboBox.Items.Add("ELectronics and Electrical Engineering");
            //departmentComboBox.Items.Add("Applied Chemistry and Chemical Engineering ");
            //departmentComboBox.Items.Add("Civil Engineering");
            //departmentComboBox.Items.Add("Food and Agro-Process Engineering");
            //departmentComboBox.Items.Add("Architecture");
            foreach (var data in departmentList)
            {
                departmentComboBox.Items.Add(data);
            }

        }

        private void anotherButton_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            //Form1 f1 = new Form1();
            this.Hide();
        }
    }
}
