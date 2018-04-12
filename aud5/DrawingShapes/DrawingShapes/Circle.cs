using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public int Diameter { get; }

        public Circle(int x, int y, int radius, Color color) : base(x, y, color)
        {
            Radius = radius;
            Diameter = 2 * radius;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, X - Radius, Y - Radius, Diameter, Diameter);
            if (Selected)
            {
                Pen pen = new Pen(Color.DarkGreen, 3);
                g.DrawEllipse(pen, X - Radius, Y - Radius, Diameter, Diameter);
                pen.Dispose();
            }
            brush.Dispose();
        }

        public override bool IsHit(int x, int y)
        {
            return Math.Sqrt(Math.Pow((X - x), 2) + Math.Pow((Y - y), 2)) <= Convert.ToDouble(Diameter);
        }
    }
}