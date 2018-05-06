using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDraw
{
    [Serializable]
    public class Rectangle
    {
        public Point StartingPoint { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Selected { get; set; }

        public Rectangle(Point startingPoint, int width, int height, Color color)
        {
            StartingPoint = startingPoint;
            Width = width;
            Height = height;
            Color = color;
            Selected = false;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillRectangle(brush, StartingPoint.X, StartingPoint.Y, Width, Height);
            brush.Dispose();
        }

        public void Move(int x, int y)
        {
            StartingPoint = new Point(StartingPoint.X + x, StartingPoint.Y + y);
        }

        public bool Select(Point location)
        {
            return (location.X >= StartingPoint.X && Math.Abs(location.X - StartingPoint.X) <= Width) &&
                   (location.Y >= StartingPoint.Y && Math.Abs(location.Y - StartingPoint.Y) <= Height);
        }
    }
}