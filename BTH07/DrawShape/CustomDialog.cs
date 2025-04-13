using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawShape
{
    public partial class CustomDialog : Form
    {
        public Color color;
        public ShapeType nShape;
        public CustomDialog()
        {
            InitializeComponent();
        }

        private void previewColor_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            //cld.FullOpen = true;
            if (cld.ShowDialog() == DialogResult.OK)
            {
                color = cld.Color;
                previewColor.BackColor = color;
            }
        }

        private void CustomDialog_Load(object sender, EventArgs e)
        {
            previewColor.BackColor = color;
            if (nShape == ShapeType.Rectaingle)
            {
                Rectaingle.Checked=true;
            }
            else if (nShape == ShapeType.Triangle)
            {
                 Triangle.Checked=true;
            }
            else if (nShape == ShapeType.Ellipse)
            {
                Ellipse.Checked=true;
            }
            else
            {
                Line.Checked=true;
            }
        }

        private void Rectaingle_CheckedChanged(object sender, EventArgs e)
        {
            nShape = ShapeType.Rectaingle;
        }

        private void Triangle_CheckedChanged(object sender, EventArgs e)
        {
            nShape = ShapeType.Triangle;
        }

        private void Ellipse_CheckedChanged(object sender, EventArgs e)
        {
            nShape = ShapeType.Ellipse;
        }

        private void Line_CheckedChanged(object sender, EventArgs e)
        {
            nShape= ShapeType.Line;
        }
    }
}
