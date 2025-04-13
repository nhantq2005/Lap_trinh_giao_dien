using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_MAU_02
{
    public partial class FrmDelay : Form
    {
        public FrmDelay()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picL.Right < picR.Left)
            {
                picL.Left += 10;
                picR.Left -= 10;
            }
            else
            {
                this.Close();
            }
        }
    }
}
