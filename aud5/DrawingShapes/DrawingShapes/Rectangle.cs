using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int heigth, Color color) : base(x, y, color)
        {
            Width = width;
            Height = heigth;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillRectangle(brush, X - (Width / 2), Y - (Height / 2), Width, Height);
            if (Selected)
            {
                Pen pen = new Pen(Color.DarkGreen, 3);
                g.DrawRectangle(pen, X - (Width / 2), Y - (Height / 2), Width, Height);
                pen.Dispose();
            }
            brush.Dispose();
        }

        public override bool IsHit(int x, int y)
        {
            return Math.Abs(X - x) <= (Width / 2) && Math.Abs(Y - y) <= (Height / 2);
        }
    }
}