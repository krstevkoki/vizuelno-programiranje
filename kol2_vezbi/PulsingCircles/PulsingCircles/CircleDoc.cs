using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsingCircles
{
    [Serializable]
    public class CircleDoc
    {
        public List<Circle> Circles { get; }

        public CircleDoc()
        {
            Circles = new List<Circle>();
        }

        public void AddCircle(Point center, Color color)
        {
            Circles.Add(new Circle(center, color));
        }

        public int CirclesCount()
        {
            return Circles.Count;
        }

        public void Draw(Graphics g)
        {
            foreach (var circle in Circles)
                circle.Draw(g);
        }

        public void IncrementCirclesRadius()
        {
            foreach (var circle in Circles)
                circle.IncrementRadius();
        }
    }
}
