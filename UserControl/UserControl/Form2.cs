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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> departmentList = new List<string>();
            departmentList.Add("....Select....");
            departmentList.Add("Computer Science and Engineering");
            departmentList.Add("ELectronics and Electrical Engineering");
            departmentList.Add("Applied Chemistry and Chemical Engineering ");
            departmentList.Add("Civil Engineering");
            departmentList.Add("Food and Agro-Process Engineering");
            departmentList.Add("Architecture");

            foreach (var data in departmentList)
            {
                departmentComboBox.Items.Add(data);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string dept = departmentComboBox.Text;
            departmentListBox.Items.Add(dept);
        }

        
    }
}
