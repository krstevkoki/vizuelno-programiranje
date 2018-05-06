using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    [Serializable]
    public class Circle
    {
        public Point Center { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public static readonly int Radius = 40;
        private static readonly int Diameter = 2 * Radius;

        public Circle(Point center, Color color)
        {
            Center = new Point(center.X - Radius, center.Y - Radius);
            PrimaryColor = color;
            SecondaryColor = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(PrimaryColor);
            g.FillPie(brush, Center.X, Center.Y, Diameter, Diameter, 180, 180);
            brush.Dispose();

            brush = new SolidBrush(SecondaryColor);
            g.FillPie(brush, Center.X, Center.Y, Diameter, Diameter, 0, 180);
            brush.Dispose();
        }

        public void SwapColors()
        {
            var temp = PrimaryColor;
            PrimaryColor = SecondaryColor;
            SecondaryColor = temp;
        }
    }
}