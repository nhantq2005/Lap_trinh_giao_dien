using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DE_MAU_01
{
    public partial class FrmDelay : Form
    {
        public FrmDelay()
        {
            InitializeComponent();
        }

        private void FrmImg_Paint(object sender, PaintEventArgs e)
        { 
            Font font = new Font("Arial", 60, FontStyle.Italic);
            HatchBrush hbr = new HatchBrush(HatchStyle.Trellis, Color.White);
            LinearGradientBrush lbr = new LinearGradientBrush(new Point(0, 0), new Point(ClientRectangle.Width, ClientRectangle.Height),
               Color.Red, Color.Yellow);
            StringFormat f = new StringFormat();
            f.Alignment = StringAlignment.Center;
            f.LineAlignment = StringAlignment.Center;
            e.Graphics.FillRectangle(lbr, ClientRectangle);
            e.Graphics.DrawString("Nguyen Van A", font, hbr, ClientRectangle, f);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
