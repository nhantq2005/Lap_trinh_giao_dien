using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ON_TAP_DO_HOA
{
    public partial class Form1 : Form
    {
        Color color;
        int penWidth;
        Bitmap bmpTmp;
        Point pOld;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush br = new SolidBrush(Color.Blue);
            Rectangle r1 = new Rectangle(0,0,ClientRectangle.Width/2,ClientRectangle.Height);
            Rectangle r2 = new Rectangle(ClientRectangle.Width/2,0,ClientRectangle.Width/2,ClientRectangle.Height/2);
            Rectangle r3 = new Rectangle(ClientRectangle.Width/2, ClientRectangle.Height/2,ClientRectangle.Width/2, ClientRectangle.Height/2);
            Rectangle[] arrRec = { r1, r2, r3 };
            e.Graphics.DrawRectangles(new Pen(Color.Red),arrRec);
            e.Graphics.DrawEllipse(pen, r2);
            e.Graphics.FillEllipse(br, r2);
            Image img = Image.FromFile("img.jpg");
            e.Graphics.DrawImage(img, r3);
            Font font = new Font("Arial",15,FontStyle.Bold);
            e.Graphics.DrawString("DEMO", font, br, r1);

            e.Graphics.DrawImage(bmpTmp, 0, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            color = Color.Red;
            penWidth = 2;
            bmpTmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }
    }
}
