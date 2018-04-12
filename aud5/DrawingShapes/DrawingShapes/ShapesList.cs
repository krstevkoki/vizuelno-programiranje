using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes
{
    public enum ShapeType
    {
        Circle,
        Rectangle,
        Triangle
    }

    public class ShapesList
    {
        public List<Shape> Shapes { get; set; }

        public ShapesList()
        {
            Shapes = new List<Shape>();
        }

        public void AddShape(int x, int y, Color color, ShapeType type)
        {
            Shape shape = null;
            if (type == ShapeType.Circle)
                shape = new Circle(x, y, 20, color);
            if (type == ShapeType.Rectangle)
                shape = new Rectangle(x, y, 60, 30, color);
            if (type == ShapeType.Triangle)
                shape = new Triangle(x, y, color, new Point(x + 50, y + 30), new Point(x + 40, y - 20));
            Shapes.Add(shape);
        }

        public Shape Select(int x, int y)
        {
            foreach (var shape in Shapes)
                if (!(shape is Triangle) && shape.IsHit(x, y))
                {
                    shape.Selected = true;
                    return shape;
                }

            return null;
        }

        public void Draw(Graphics g)
        {
            foreach (var shape in Shapes)
                shape.Draw(g);
        }
    }
}