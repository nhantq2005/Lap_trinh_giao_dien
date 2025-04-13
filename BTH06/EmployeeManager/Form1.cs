using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManager
{
    public partial class Form1 : Form
    {
        ManageEmployee manageEmployee = new ManageEmployee();
        public Form1()
        {
            InitializeComponent();
            listView.FullRowSelect = true;
        }

        private void LoadData()
        {
            listView.Items.Clear();
            foreach( Employee emp in manageEmployee.Employees)
            {
                ListViewItem item = new ListViewItem(emp.Name);
                item.SubItems.Add(emp.Age.ToString());
                item.SubItems.Add(emp.Address);
                listView.Items.Add(item);
            }
        }



        private void openItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Employee File|*.empl";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                manageEmployee.deserialization(ofd.FileName);
            }
            LoadData();
         }

        private void saveItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Employee File|*.empl";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                manageEmployee.serialization(sfd.FileName);
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Employee empl = new Employee(nameTb.Text,int.Parse(ageTb.Text),addressTb.Text);
                manageEmployee.add(empl);
                LoadData();
            }catch(FormatException)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            finally 
            {
                nameTb.Text = "";
                ageTb.Text = "";
                addressTb.Text = "";
            }
        }
    }
}
