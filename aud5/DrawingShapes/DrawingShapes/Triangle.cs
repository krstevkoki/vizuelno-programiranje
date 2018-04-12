using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes
{
    public class Triangle : Shape
    {
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }

        public Triangle(int x, int y, Color color, Point point2, Point point3) : base(x, y, color)
        {
            Point2 = point2;
            Point3 = point3;
        }

        public override void Draw(Graphics g)
        {
            Point[] points = {new Point(X, Y), Point2, Point3};
            Brush brush = new SolidBrush(Color);
            g.FillPolygon(brush, points);
            brush.Dispose();
        }

        public override bool IsHit(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}