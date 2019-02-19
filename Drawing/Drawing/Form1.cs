using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        Point p1 = new Point();
        Point p2 = new Point();

        Pen pen;
        Color curcolor;

        Graphics g;
        Line line;
        Rectangle rect;
        Ellipse ring;
        Triangle three;
        Triangle_2 three_2;
        int ShapeType;

        List<Shape> list;

        bool clicked = false;
        int X = 0;
        int Y = 0;

        int X1 = 0;
        int Y1 = 0;
        public Form1()
        {
            InitializeComponent();

            g = pictureBox1.CreateGraphics();

            curcolor = Color.Black;
         // pen = new Pen(curcolor, 3);

            list =  new List<Shape>();

            
            
        }




        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            X = e.X;
            Y = e.Y;          
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            pictureBox1.Invalidate();
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                X1 = e.X;
                Y1 = e.Y;
              // pictureBox1.Invalidate();
            }
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            p1.X = X;
            p1.Y = Y;

            p2.X = X1;
            p2.Y = Y1;

            g = e.Graphics;

            //  e.Graphics.DrawLine(Pens.Aqua, p1, p2);

            //  e.Equals(line);

             if (p2.X != 0 && p2.Y != 0)
            {

                switch (ShapeType)
                {
                    case 0:
                        line = new Line(p1, p2);
                        pen = new Pen(curcolor, 3);
                        line.curPen = pen;
                        list.Add(line);
                        break;
                    case 1:
                        rect = new Rectangle(p1, p2);
                        pen = new Pen(curcolor, 3);
                        rect.curPen = pen;
                        list.Add(rect);
                        break;
                    case 2:
                        ring = new Ellipse(p1, p2);
                        pen = new Pen(curcolor, 3);
                        ring.curPen = pen;
                        list.Add(ring);
                        break;
                    case 3:
                        three = new Triangle(p1, p2);
                        pen = new Pen(curcolor, 3);
                        three.curPen = pen;
                        list.Add(three);
                        break;
                    case 4:
                        three_2 = new Triangle_2(p1, p2);
                        pen = new Pen(curcolor, 3);
                        three_2.curPen = pen;
                        list.Add(three_2);
                        break;
                }

                X = X1 = Y = Y1 = 0;    

             }



            foreach (Shape shape in list)
            {
                shape.Draw(g);
            }            
            
        }






        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == DialogResult.OK)
            {
                curcolor = colorDialog1.Color;
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            ShapeType = 0; // Line     
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShapeType = 1; // Rectangle
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShapeType = 2; // Ellipse
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShapeType = 3; // Triangle
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShapeType = 4; // Triangle_2
        }
    }
}
