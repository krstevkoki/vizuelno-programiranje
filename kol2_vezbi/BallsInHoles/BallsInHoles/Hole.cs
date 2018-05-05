using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    [Serializable]
    public class Hole
    {
        public Point Center { get; set; }
        public int Counter { get; set; }
        public static readonly int Radius = 30;
        private static readonly int Diameter = 2 * Radius;

        public Hole(Point center)
        {
            Center = new Point(center.X - Radius, center.Y - Radius);
            Counter = 0;
        }

        public void Draw(Graphics g, Font font)
        {
            Brush brush = new SolidBrush(Color.Black);
            g.FillEllipse(brush, Center.X, Center.Y, Diameter, Diameter);
            brush.Dispose();

            Brush cBrush = new SolidBrush(Color.White);
            g.DrawString($"{Counter}", font, cBrush, Center.X + 18, Center.Y + 22);
            cBrush.Dispose();
        }

        public bool TouchAnotherHole(Hole another)
        {
            return Math.Sqrt(Math.Pow(this.Center.X - another.Center.X, 2) +
                             Math.Pow(this.Center.Y - another.Center.Y, 2)) <= Diameter;
        }

        public bool SwallowBall(Ball ball)
        {
            if (Math.Sqrt(Math.Pow(this.Center.X - ball.Center.X, 2) +
                          Math.Pow(this.Center.Y - ball.Center.Y, 2)) <= Ball.Radius)
            {
                ++Counter;
                return true;
            }

            return false;
        }
    }
}