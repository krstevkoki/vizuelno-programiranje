using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallChaos
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool IsColided { get; set; }

        private double _velocityX;
        private double _velocityY;

        public static int Radius = 20;
        private static readonly int Diameter = Radius * 2;
        private const int Velocity = 10;

        public Ball(Point center, Color color)
        {
            Center = center;
            Color = color;
            var random = new Random();
            var angle = 2 * Math.PI * random.NextDouble();
            _velocityX = Math.Cos(angle) * Velocity;
            _velocityY = Math.Sin(angle) * Velocity;
        }

        public bool AreColiding(Ball ball)
        {
            var distance = Math.Sqrt(Math.Pow(Center.X - ball.Center.X, 2) + Math.Pow(Center.Y - ball.Center.Y, 2));
            return distance < Diameter;
        }

        public void Draw(Graphics g)
        {
            var brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Diameter, Diameter);
            brush.Dispose();
        }

        public void Move(int left, int top, int width, int height)
        {
            var nextX = Center.X + _velocityX;
            var nextY = Center.Y + _velocityY;

            if ((nextX - Radius) <= left || (nextX + Radius) >= width + left)
            {
                _velocityX *= -1;
            }

            if ((nextY - Radius) <= top || (nextY + Radius) >= height + top)
            {
                _velocityY *= -1;
            }

            Center = new Point((int) (Center.X + _velocityX), (int) (Center.Y + _velocityY));
        }
    }
}