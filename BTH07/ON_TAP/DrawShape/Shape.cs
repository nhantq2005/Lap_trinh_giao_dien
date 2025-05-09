﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ON_TAP.DrawShape.FrmMain;
using System.Drawing.Drawing2D;

namespace ON_TAP.DrawShape
{
    
    public class Shape
    {
        public Point p1, p2;
        public Color color;
        public ShapeType nShape;

        public Shape()
        {
            p1 = p2 = new Point(0, 0);
        }

        public void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(color);
            switch(nShape)
            {
                case ShapeType.Rectangle: g.FillRectangle(br, p1.X,p1.Y,p2.X-p1.X,p2.Y-p1.Y); break;
                case ShapeType.Ellipse: g.FillEllipse(br, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y); break;
                case ShapeType.Triangle:
                    Point[] arrP ={
                        new Point(p2.X-p1.X/2,p1.X),
                        new Point(p1.X,p2.Y),
                        new Point(p2.X,p2.Y)
                    };
                    g.FillPolygon(br, arrP);
                    break;
                case ShapeType.Line:
                    Pen pen = new Pen(br);
                    g.DrawLine(pen, p1, p2);
                    break;
            }
        }
    }


}
