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

namespace ON_TAP
{
    public partial class Form1 : Form
    {
        Color color;
        Bitmap bm;
        Point pOld;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            color = cd.Color;
            demo.BackColor = color;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Rectangle rc = new Rectangle(pOld.X, pOld.Y, (e.Location.X - pOld.X), (e.Location.Y - pOld.Y));
                Graphics g = Graphics.FromImage(bm);
                g.Clear(Color.White);
                Pen pen = new Pen(color);
                g.DrawRectangle(pen,rc);
                Invalidate();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
