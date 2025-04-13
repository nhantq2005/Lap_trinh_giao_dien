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

namespace SimplePaint
{
    public partial class FrmDrawByMouse : Form
    {
        Color color;
        int penWidth;
        Bitmap bmpTmp;
        Point pOld;
        public FrmDrawByMouse()
        {
            InitializeComponent();
        }

        private void FrmDrawByMouse_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void FrmDrawByMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(color, penWidth);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                Graphics g = Graphics.FromImage(bmpTmp);
                g.DrawLine(pen, pOld, e.Location);
                pOld = e.Location;
                Invalidate();
            }
        }

        private void FrmDrawByMouse_Load(object sender, EventArgs e)
        {
            color = Color.Red;
            penWidth = 2;
            bmpTmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void FrmDrawByMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmpTmp,0,0);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Up: 
                    if(penWidth<50)
                        penWidth++; break;
                case Keys.Down:
                    if(penWidth>1)
                        penWidth--; break;
                case Keys.R: color = Color.Red; break;
                case Keys.B: color = Color.Blue; break;
                case Keys.G: color = Color.Green; break;
            }    
            return base.ProcessDialogKey(keyData);
        }
    }
}
