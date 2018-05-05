using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public static readonly int Radius = 25;
        private static readonly int Diameter = 2 * Radius;
        private int _velocity;
        private double _velocityX;
        private double _velocityY;

        public Ball(Point center, Color color, int velocity)
        {
            Center = new Point(center.X - Radius, center.Y - Radius);
            Color = color;
            _velocity = velocity;
            var random = new Random();
            var angle = 2 * Math.PI * random.NextDouble();
            _velocityX = Math.Cos(angle) * _velocity;
            _velocityY = Math.Sin(angle) * _velocity;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X, Center.Y, Diameter, Diameter);
            brush.Dispose();
        }

        public void Move(int left, int top, int width, int height)
        {
            var nextX = Center.X + _velocityX;
            var nextY = Center.Y + _velocityY;

            if (nextX <= left || nextX + Diameter >= width)
                _velocityX *= -1;
            if (nextY <= top || nextY + Diameter >= height + top)
                _velocityY *= -1;
            Center = new Point((int) (Center.X + _velocityX), (int) (Center.Y + _velocityY));
        }
    }
}