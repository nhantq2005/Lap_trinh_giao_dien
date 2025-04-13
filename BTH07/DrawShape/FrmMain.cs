using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DrawShape
{
    public enum ShapeType
    {
        Rectaingle,
        Triangle,
        Line,
        Ellipse
    }
    public partial class FrmMain : Form
    {
        ArrayList arrShape = new ArrayList();
        ShapeType nShape;
        Color color;
        public FrmMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            color = Color.Red;
            nShape = ShapeType.Line;
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            Shape shape = new Shape();
            shape.p1 = (Point)e.Location;
            shape.color = color;
            shape.nShape = nShape;
            arrShape.Add(shape);
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Shape s = (Shape)arrShape[arrShape.Count-1];
                s.p2 = (Point)e.Location;
                Invalidate();
            }
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height, e.Graphics);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.HighQuality;
            foreach(Shape shape in arrShape)
            {
                shape.Draw(g);
            }
            e.Graphics.DrawImage(bmp, 0, 0);
            g.Dispose();
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomDialog cd = new CustomDialog();
            cd.color = color;
            cd.nShape = nShape;
            //cd.ShowDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                color = cd.color;
                nShape = cd.nShape;
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrShape.Clear();
            Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Shape File(*.shp)|*.shp";
            sfd.ShowDialog();
            FileStream stream = new FileStream(sfd.FileName,FileMode.Create,FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, arrShape);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd  = new OpenFileDialog();
            ofd.Filter = "Shape File(*.shp)|*.shp";
            ofd.ShowDialog();
            FileStream s = new FileStream(ofd.FileName,FileMode.Open,FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            arrShape = (ArrayList)bf.Deserialize(s);
            Invalidate();
        }
    }
}
