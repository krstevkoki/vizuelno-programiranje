using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDraw
{
    [Serializable]
    public class RectanglesDoc
    {
        public List<Rectangle> Rectangles { get; set; }

        public int Count
        {
            get { return Rectangles.Count; }
        }

        public RectanglesDoc()
        {
            Rectangles = new List<Rectangle>();
        }

        public void AddRectangle(Point startingPoint, int width, int heigth, Color color)
        {
            Rectangles.Add(new Rectangle(startingPoint, width, heigth, color));
        }

        public void Draw(Graphics g)
        {
            foreach (var rectangle in Rectangles)
                rectangle.Draw(g);
        }

        public void Move(int x, int y)
        {
            foreach (var rectangle in Rectangles)
            {
                if (rectangle.Selected)
                {
                    rectangle.Move(x, y);
                    return;
                }
            }
        }

        public bool Select(Point location)
        {
            foreach (var rectangle in Rectangles)
            {
                if (rectangle.Select(location))
                {
                    rectangle.Selected = true;
                    return true;
                }
            }

            return false;
        }

        public void ClearSelected()
        {
            foreach (var rectangle in Rectangles)
                rectangle.Selected = false;
        }
    }
}