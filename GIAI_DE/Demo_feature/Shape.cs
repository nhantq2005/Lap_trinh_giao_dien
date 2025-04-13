using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_feature
{
    enum ShapeType
    {
        RECTAINGLE,
        TRIANGLE,
        ELLIPSE,
        LINE
    }
    internal class Shape
    {
        public Point p1, p2;
        public Color color;
        public ShapeType type;
        public Shape() { }

        public void DrawLine(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawLine(pen, p1, p2);
        }

        public void DrawRectaingle(Graphics g)
        {
            SolidBrush br = new SolidBrush(color);
            g.FillRectangle(br, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
        }

        public void DrawTriangle(Graphics g)
        {
            SolidBrush br = new SolidBrush(color);
            Point[] arrP =
            {
                 new Point((p2.X+p1.X)/2,p1.Y),
                        new Point(p1.X,p2.Y),
                p2
            };
            g.FillPolygon(br, arrP);
        }

        public void DrawEllipse(Graphics g)
        {
            SolidBrush br = new SolidBrush(color);
            g.FillEllipse(br, new Rectangle(p1.X, p1.Y,  p2.X - p1.X, p2.Y - p1.Y));
        }

        public void Draw(Graphics g)
        {
            switch(type)
            {
                case ShapeType.LINE: DrawLine(g); break;
                case ShapeType.ELLIPSE: DrawEllipse(g); break;
                case ShapeType.RECTAINGLE: DrawRectaingle (g); break;
                case ShapeType.TRIANGLE: DrawTriangle(g); break;
            }
        }
    }
}
