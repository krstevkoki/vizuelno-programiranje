using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    public class Circle
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool Selected { get; set; }
        public readonly int Radius;
        private readonly int _diameter;

        public Circle(Point center, Color color, int radius)
        {
            Center = center;
            Color = color;
            Radius = radius;
            _diameter = 2 * Radius;
            Selected = false;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, _diameter, _diameter);
            brush.Dispose();
            if (Selected)
            {
                var pen = new Pen(Color.Red, 5);
                g.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, _diameter, _diameter);
                pen.Dispose();
            }
        }

        public bool Select(Point location)
        {
            return Math.Sqrt(Math.Pow(Center.X - location.X, 2) + 
                             Math.Pow(Center.Y - location.Y, 2)) <= Radius;
        }
    }
}