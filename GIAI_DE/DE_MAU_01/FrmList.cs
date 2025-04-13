using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DE_MAU_01
{
    public partial class FrmList : Form
    {
        Dictionary<string,string> list = new Dictionary<string,string>();
        public FrmList()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            listView1.Items.Clear();
            foreach(string key in list.Keys)
            {
                ListViewItem listViewItem = new ListViewItem(key,0);
                listViewItem.SubItems.Add(list[key]);
                listView1.Items.Add(listViewItem);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                list.Add(tenSach.Text, tacGia.Text);
                LoadData();
                tenSach.Text = "";
                tacGia.Text = "";
            }
            catch { }
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            for(int i = listView1.SelectedItems.Count-1;i>=0;i--) {
                list.Remove(listView1.SelectedItems[i].Text);
                listView1.Items.Remove(listView1.SelectedItems[i]);
            }
        }
    }
}
