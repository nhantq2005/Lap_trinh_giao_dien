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

namespace SimplePaint
{
    public partial class FrmDrawImage : Form
    {
        public FrmDrawImage()
        {
            InitializeComponent();
        }

        private void FrmDrawImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc1 = new Rectangle(0, 0, ClientRectangle.Width/2, ClientRectangle.Height/2);
            Rectangle rc2 = new Rectangle(0, ClientRectangle.Height / 2, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc3 = new Rectangle(ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height);
            Pen pen = new Pen(Color.Blue, 1);
            DrawImage(e.Graphics, rc1);
            DrawText(e.Graphics, rc2);
            DrawPolygon(e.Graphics, rc3);
            e.Graphics.DrawRectangles(pen, new Rectangle[] {rc1, rc2, rc3});

        }

        private void DrawImage(Graphics g, Rectangle r) 
        {
            Image img = Image.FromFile("flower.jpg");
            g.DrawImage(img, r);
            Color color = Color.FromArgb(100, 255, 255, 0);
            Font font = new Font("Arial",48,FontStyle.Bold);
            StringFormat fm = new StringFormat();
            fm.LineAlignment = StringAlignment.Far;
            g.DrawString("FLOWER", font,new SolidBrush(color),r, fm);
        }

        private void DrawText(Graphics g, Rectangle r)
        {
            LinearGradientBrush br1 = new LinearGradientBrush(r, Color.Black, Color.White, LinearGradientMode.BackwardDiagonal);
            LinearGradientBrush br2 = new LinearGradientBrush(r, Color.Red, Color.Yellow, 45);
            g.FillRectangle(br1, r);
            Font font = new Font("Arial", 48, FontStyle.Bold);
            StringFormat fm = new StringFormat();
            fm.LineAlignment = StringAlignment.Center;
            fm.Alignment = StringAlignment.Center;
            g.DrawString("HELLO", font, br2, r, fm);
        }

        private void DrawPolygon(Graphics g, Rectangle r)
        {
            Point[] arrP =
            {
                new Point(r.Left, r.Height/4),
                new Point(r.Left+r.Width/2, r.Top),
                new Point(r.Left+r.Width, r.Height/4),
                new Point(r.Left+r.Width/2, r.Height)
            };
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(arrP);
            PathGradientBrush br = new PathGradientBrush(path);
            br.CenterColor = Color.White;
            br.SurroundColors = new Color[] { Color.Yellow, Color.Green, Color.Cyan, Color.Red };
            g.FillPolygon(br, arrP);
        }

        private void FrmDrawImage_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
