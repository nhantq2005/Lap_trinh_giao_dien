using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DE_01
{
    public partial class FrmString : Form
    {
        List<string> ds = new List<string>();
        public FrmString()
        {
            InitializeComponent();
          
        }

        private void LoadData()
        {
            foreach (string item in ds)
            {
                list1.Items.Add(item);
            }
        }

        private void btSetTemplate_Click(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (addLast.Checked)
            {
                ds.Add(inputStr.Text);
            }
            else
            {
                ds.Insert(0, inputStr.Text);
            }
            list1.Items.Clear();
            LoadData();
        }
        
    }
}
