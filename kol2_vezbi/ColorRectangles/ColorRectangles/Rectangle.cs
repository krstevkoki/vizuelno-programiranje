using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorRectangles
{
    [Serializable]
    public class Rectangle
    {
        public Point Teme { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        public bool Selected { get; set; }

        public Rectangle(Point teme, int width, int heigth, Color color)
        {
            Teme = teme;
            Width = width;
            Heigth = heigth;
            Color = color;
            Selected = false;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillRectangle(brush, Teme.X, Teme.Y, Width, Heigth);
            if (Selected)
            {
                var pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, Teme.X, Teme.Y, Width, Heigth);
                pen.Dispose();
            }

            brush.Dispose();
        }

        public bool Hit(int x, int y)
        {
            return (x >= Teme.X && Math.Abs(Teme.X - x) <= Width) &&
                   (y >= Teme.Y && Math.Abs(Teme.Y - y) <= Heigth);
        }
    }
}