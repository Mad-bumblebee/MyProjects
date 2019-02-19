using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    class Line : Shape
    {

        public Line()
        {
            //point_1.X = point_1.Y = 0;
            //point_2 = new Point(0, 0);

        }

        public Line(Point p1, Point p2)
        {
            point_1 = p1;
            point_2 = p2;
        }
        
        public override void Draw(Graphics g)
        {
            g.DrawLine(curPen, point_1, point_2);
        }

    }
}
