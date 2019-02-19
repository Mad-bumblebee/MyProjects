using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
   public abstract class Shape
    {
        protected Point point_1;
        protected Point point_2;


        public Pen curPen;
        public abstract void Draw(Graphics e);

    }
}
