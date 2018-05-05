using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingBallons
{
    [Serializable]
    public class Baloon
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool Selected { get; set; }
        public static readonly int Radius = 20;
        private static readonly int Diameter = 2 * Radius;
        private int Velocity;

        public Baloon(Point center, Color color)
        {
            Center = new Point(center.X, center.Y);
            Color = color;
            Selected = false;
            Velocity = 10;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X, Center.Y, Diameter, Diameter);
            brush.Dispose();
        }

        public void Move(int top, int height)
        {
            Point temp = new Point(Center.X, Center.Y + Velocity);

            if (temp.Y >= height - Diameter || temp.Y <= top)
            {
                Velocity *= -1;
                Center = new Point(Center.X, Center.Y + Velocity);
            }
            else Center = temp;
        }

        public bool Select(int x, int y)
        {
            return Math.Sqrt(Math.Pow(Center.X - x, 2) + Math.Pow(Center.Y - y, 2)) <= Diameter;
        }
    }
}