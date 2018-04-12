using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public bool Selected { get; set; }

        protected Shape(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public abstract void Draw(Graphics g);

        public abstract bool IsHit(int x, int y);

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }
    }
}
