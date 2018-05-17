using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingRectangles
{
    [Serializable]
    public class Rectangle
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool Disappeared { get; set; }
        public bool LeftClicked { get; set; }
        public bool RightClicked { get; set; }

        private int _width;
        private int _height;

        public Rectangle(Point center, Color color)
        {
            _width = 100;
            _height = 50;
            Center = new Point(center.X - (_width / 2), center.Y - (_height / 2));
            Color = color;
            Disappeared = LeftClicked = RightClicked = false;
        }

        public void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, Center.X, Center.Y, _width, _height);
            }
        }

        public void Move(int height)
        {
            var newY = Center.Y + _height;

            if ((newY + _height) > height)
                Disappeared = true;

            Center = new Point(Center.X, newY);
        }

        public void Rotate(int width)
        {
            int newX = Center.X + _width;
            int newY = Center.Y + (_height - _width);

            var temp = _width;
            _width = _height;
            _height = temp;

            if (newX > width)
                Disappeared = true;

            Center = new Point(newX, newY);
        }

        public bool Clicked(Point location)
        {
            if (LeftClicked || RightClicked)
                return false;
            return ((location.X >= Center.X) && (location.X - Center.X <= _width)) &&
                   ((location.Y >= Center.Y) && (location.Y - Center.Y <= _height));
        }
    }
}