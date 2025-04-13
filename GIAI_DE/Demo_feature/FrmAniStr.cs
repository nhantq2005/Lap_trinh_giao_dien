using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_feature
{
    public partial class FrmAniStr : Form
    {
        public FrmAniStr()
        {
            InitializeComponent();
        }

        private void FrmAniStr_Load(object sender, EventArgs e)
        {
            txt.Text = "  Truong Dai hoc Mo TP. Ho Chi Minh    ";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt.Text = txt.Text.Substring(1,txt.Text.Length-1)+txt.Text.Substring(0,1);

        }

        private void paintBt_Click(object sender, EventArgs e)
        {
            FrmPaint frmPaint = new FrmPaint();
            frmPaint.ShowDialog();
        }
    }
}
