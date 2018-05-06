using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBall
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public int Counter { get; set; }
        public static readonly int Velocity = 10;
        private readonly int _diameter;
        private double _velocityX;   
        private double _velocityY;

        public Ball(Point center)
        {
            Center = center;
            Counter = 0;
            var rand = new Random();
            Radius = rand.Next(20, 41);
            _diameter = 2 * Radius;
            var angle = 2 * Math.PI * rand.NextDouble();
            _velocityX = Math.Cos(angle) * Velocity;
            _velocityY = Math.Sin(angle) * Velocity;
        }

        private Color GetColor()
        {
            if (Counter < 5)
                return Color.DarkRed;
            if (Counter < 10)
                return Color.DarkBlue;
            return Color.Black;
        }

        public void Draw(Graphics g, Font font)
        {
            Brush brush = new SolidBrush(GetColor());
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, _diameter, _diameter);
            Brush stringBrush = new SolidBrush(Color.White);
            g.DrawString($"{Counter}", font, stringBrush,
                Center.X - Radius / 2, Center.Y - Radius / 2);
            stringBrush.Dispose();
            brush.Dispose();
        }

        public void Move(int left, int top, int width, int height)
        {
            var nextX = Center.X + _velocityX;
            var nextY = Center.Y + _velocityY;

            if ((nextX - Radius) <= left || (nextX + Radius) >= width + left)
                _velocityX *= -1;
            if ((nextY - Radius) <= top || (nextY + Radius) >= height + top)
                _velocityY *= -1;

            Center = new Point((int) (Center.X + _velocityX), (int) (Center.Y + _velocityY));
        }

        public bool IsTouching(Ball ball)
        {
            return Math.Sqrt(Math.Pow(Center.X - ball.Center.X, 2) +
                             Math.Pow(Center.Y - ball.Center.Y, 2)) <= Radius + ball.Radius;
        }
    }
}