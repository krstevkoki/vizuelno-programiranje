using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    public class CircleDoc
    {
        public List<Circle> Circles { get; }

        public CircleDoc()
        {
            Circles = new List<Circle>();
        }

        public void AddCircle(Point center, Color color, int radius)
        {
            Circles.Add(new Circle(center, color, radius));
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

        public void Select(Point location)
        {
            foreach (var circle in Circles)
                if (circle.Select(location))
                    circle.Selected = !circle.Selected;
        }

        public void RemoveSelected()
        {
            for (int i = Circles.Count - 1; i >= 0; i--)
                if (Circles[i].Selected)
                    Circles.RemoveAt(i);
        }

        public void SelectAll(bool status)
        {
            foreach (var circle in Circles)
                circle.Selected = status;
        }
    }
}
