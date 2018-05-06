using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    [Serializable]
    public class CircleDoc
    {
        public List<Circle> Circles { get; set; }

        public int Count
        {
            get { return Circles.Count; }
        }

        public CircleDoc()
        {
            Circles = new List<Circle>();
        }

        public void AddCircle(Point center, Color color)
        {
            Circles.Add(new Circle(center, color));
        }

        public void DrawCircles(Graphics g)
        {
            foreach (var circle in Circles)
                circle.Draw(g);
        }

        public void SwapCirclesColors()
        {
            foreach (var circle in Circles)
                circle.SwapColors();
        }
    }
}