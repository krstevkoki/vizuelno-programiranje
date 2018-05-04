using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorRectangles
{
    [Serializable]
    public class RectangleDoc
    {
        public List<Rectangle> Rectangles { get; set; }
        public Color Color { get; set; }

        public RectangleDoc(Color color)
        {
            Rectangles = new List<Rectangle>();
            Color = color;
        }

        public void AddRectangle(Point teme, int width, int height, Color color)
        {
            Rectangles.Add(new Rectangle(teme, width, height, color));
        }

        public void Draw(Graphics g)
        {
            foreach (var rectangle in Rectangles)
                rectangle.Draw(g);
        }

        public int RectanglesCount()
        {
            return Rectangles.Count;
        }

        public void Hit(int x, int y)
        {
            foreach (var rectangle in Rectangles)
                if (rectangle.Hit(x, y))
                    rectangle.Selected = !rectangle.Selected;
        }

        public void DeleteSelected()
        {
            for (int i = Rectangles.Count - 1; i >= 0; i--)
                if (Rectangles[i].Selected)
                    Rectangles.RemoveAt(i);
        }
    }
}
