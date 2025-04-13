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

namespace Demo_feature
{

    public partial class FrmPaint : Form
    {
        ShapeType shapeType;
        string[] arrShape = { "Line", "Triangle", "Rectaingle", "Ellipse" };
        List<Shape> list = new List<Shape>();
        Color color = Color.Black;

        private void FrmPaint_Load(object sender, EventArgs e)
        {
            shapeType = ShapeType.LINE;
            foreach(string shape in arrShape)
            {
                listShape.Items.Add(shape);
            }
            listShape.SelectedIndex = 0;
        }

        public FrmPaint()
        {
            InitializeComponent();
        }

        private void FrmPaint_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width,this.Height,e.Graphics);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.HighQuality;
            foreach(Shape s in list)
            {
                s.Draw(e.Graphics);
            }
            e.Graphics.DrawImage(bmp,0,0);
            g.Dispose();
        }

        private void FrmPaint_MouseDown(object sender, MouseEventArgs e)
        {
            Shape shape = new Shape();
            shape.p1 = e.Location;
            shape.color = color;

            switch(listShape.Text)
            {
                case "Line": shapeType = ShapeType.LINE;break;
                case "Triangle": shapeType = ShapeType.TRIANGLE;break;
                case "Rectaingle": shapeType = ShapeType.TRIANGLE;break;
                case "Ellipse": shapeType = ShapeType.ELLIPSE;break;
            }
            shape.type = shapeType;
            list.Add(shape);
        }

        private void FrmPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                list[list.Count - 1].p2 = e.Location;
                Invalidate();
            }
        }

        private void colorBt_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            color = cd.Color;
        }
    }
}
