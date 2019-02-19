using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Triangle : Shape
    {
        public Triangle(Point p1, Point p2)
        {
            point_1 = p1;
            point_2 = p2;
            

        }
        public override void Draw(Graphics g)
        {                  

            Point P1 = new Point(point_1.X,point_1.Y);
            Point P2 = new Point(point_2.X,point_2.Y);
            Point P3 = new Point(point_1.X,point_2.Y);   
            
                g.DrawLine(curPen, P1, P2);
                g.DrawLine(curPen, P2, P3);
                g.DrawLine(curPen, P3, P1);       
            
        }
    }
}
