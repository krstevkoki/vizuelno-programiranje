using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBall
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public int State { get; set; }
        public static readonly int Radius = 25;
        private static readonly int _diameter = 2 * Radius;

        public Ball(Point center)
        {
            Center = center;
            var rand = new Random();
            State = rand.Next(1, 4); // 1, 2, 3
        }

        public void Draw(Graphics g)
        {
            Brush brush = null;

            if (State == 1)
                brush = new SolidBrush(Color.DarkRed);
            else if (State == 2)
                brush = new SolidBrush(Color.DarkBlue);
            else if (State == 3)
                brush = new SolidBrush(Color.DarkGreen);

            if (brush == null) return;

            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, _diameter, _diameter);
            brush.Dispose();
        }

        public void Move(Point newPosition)
        {
            Center = newPosition;
        }

        public bool IsHit(int x, int y)
        {
            var diff = Math.Sqrt(Math.Pow(Center.X - x, 2) + Math.Pow(Center.Y - y, 2));
            return diff <= _diameter && --State == 0;
        }
    }
}