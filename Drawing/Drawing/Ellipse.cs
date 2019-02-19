using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Ellipse : Shape
    {
        public Ellipse(Point p1, Point p2)
        {
            point_1 = p1;
            point_2 = p2;

        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(curPen, point_1.X,point_1.Y, point_2.X - point_1.X,point_2.Y - point_1.Y);
        }
    }
}
