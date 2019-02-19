using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Triangle_2 : Shape
    {
        public Triangle_2(Point p1, Point p2)
        {
            point_1 = p1;
            point_2 = p2;
        }
        public override void Draw(Graphics g)
        {

          //  double R = Math.Sqrt(Math.Pow(point_2.X-point_1.X,2)+ Math.Pow(point_2.Y-point_1.Y,2));

            double angle = 120 * Math.PI / 180;

            float X1 = (float)((point_2.X - point_1.X) * Math.Cos(angle)
                - (point_2.Y - point_1.Y) * Math.Sin(angle) + point_1.X);

            float Y1 = (float)((point_2.X - point_1.X) * Math.Sin(angle)
                + (point_2.Y - point_1.Y) * Math.Cos(angle) + point_1.Y);


            float X2 = (float)((point_2.X - point_1.X) * Math.Cos(-angle)
               - (point_2.Y - point_1.Y) * Math.Sin(-angle) + point_1.X);

            float Y2 = (float)((point_2.X - point_1.X) * Math.Sin(-angle)
                + (point_2.Y - point_1.Y) * Math.Cos(-angle) + point_1.Y);


            Point P1 = new Point(point_2.X, point_2.Y);

            Point P2 = new Point((int)X1,(int)Y1);

            Point P3 = new Point((int)X2, (int)Y2);

            g.DrawLine(curPen, P1, P2);
            g.DrawLine(curPen, P2, P3);
            g.DrawLine(curPen, P3, P1);

        }
    }
}






