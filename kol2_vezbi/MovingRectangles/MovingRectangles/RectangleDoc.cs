using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingRectangles
{
    [Serializable]
    public class RectangleDoc
    {
        public List<Rectangle> Rectangles { get; }

        public int Count
        {
            get { return Rectangles.Count; }
        }

        public RectangleDoc()
        {
            Rectangles = new List<Rectangle>();
        }

        public void AddRectangle(Point center, Color color)
        {
            Rectangles.Add(new Rectangle(center, color));
        }

        public void DrawRectangles(Graphics g)
        {
            Rectangles.ForEach(rect => rect.Draw(g));
        }

        public void LeftButtonClick(Point location)
        {
            foreach (var rectangle in Rectangles)
                if (rectangle.Clicked(location))
                    rectangle.LeftClicked = true;
        }

        public void MoveRectangles(int height)
        {
            foreach (var rectangle in Rectangles)
                if (rectangle.LeftClicked)
                    rectangle.Move(height);

            Rectangles.RemoveAll(rect =>  rect.LeftClicked && rect.Disappeared);
        }

        public void RightButtonClick(Point location)
        {
            foreach (var rectangle in Rectangles)
                if (rectangle.Clicked(location))
                    rectangle.RightClicked = true;
        }

        public void RotateRectangles(int width)
        {
            foreach (var rectangle in Rectangles)
                if (rectangle.RightClicked)
                    rectangle.Rotate(width);

            Rectangles.RemoveAll(rect => rect.RightClicked && rect.Disappeared);
        }
    }
}