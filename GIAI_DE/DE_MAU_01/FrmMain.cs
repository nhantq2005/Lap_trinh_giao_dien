using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_MAU_01
{
    public partial class FrmMain : Form
    {
        string path = "pen.png";
        public FrmMain()
        {
            FrmDelay frmImg = new FrmDelay();
            frmImg.ShowDialog();
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImage frmImage = new FrmImage();
            frmImage.MdiParent = this;
            frmImage.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Đóng ứng dụng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result==DialogResult.No)
            {
                e.Cancel=true;
            }
        }


        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmList frmList = new FrmList();
            frmList.MdiParent = this;
            frmList.Show();
        }
    }
}
