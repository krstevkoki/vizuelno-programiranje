using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool OutOfBounds { get; set; }

        public static readonly int Radius = 30;
        private static readonly int Diameter = 2 * Radius;
        private static readonly Random Random = new Random();

        private int _direction;

        public Ball(Point center, Color color)
        {
            Center = center;
            Color = color;
            OutOfBounds = false;
            _direction = -1;
        }

        public void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Diameter, Diameter);
            }
        }

        public void Move(int width, int height)
        {
            if (_direction == -1)
                _direction = Random.Next(4);

            var newPos = Point.Empty;
            if (_direction == (int) Directions.Left)
            {
                newPos = new Point(Center.X - 10, Center.Y);
                if (newPos.X <= -Diameter)
                {
                    OutOfBounds = true;
                    return;
                }
            }
            else if (_direction == (int) Directions.Up)
            {
                newPos = new Point(Center.X, Center.Y - 10);
                if (newPos.Y <= -Diameter)
                {
                    OutOfBounds = true;
                    return;
                }

            }
            else if (_direction == (int) Directions.Right)
            {
                newPos = new Point(Center.X + 10, Center.Y);
                if (newPos.X >= (width + Diameter))
                {
                    OutOfBounds = true;
                    return;
                }

            }
            else if (_direction == (int) Directions.Down)
            {
                newPos = new Point(Center.X, Center.Y + 10);
                if (newPos.Y >= (height + Diameter))
                {
                    OutOfBounds = true;
                    return;
                }
            }

            Center = newPos;
        }

        public bool Clicked(Point point)
        {
            return Distance(Center, point) <= Radius * Radius;
        }

        public bool TouchesGreen(Ball b)
        {
            return b.Color == Color.Green && Distance(this.Center, b.Center) <= (Radius * Radius) * 4;
        }

        private static double Distance(Point point1, Point point2)
        {
            return Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2);
        }
    }

    public enum Directions
    {
        Left,
        Up,
        Right,
        Down
    }
}