using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBall
{
    [Serializable]
    public class BallDoc
    {
        public List<Ball> BallList { get; set; }
        public int Width { get; set; }
        public int Misses { get; set; }
        public int Hits { get; set; }
        private const int Velocity = 10;

        public BallDoc(int width)
        {
            BallList = new List<Ball>();
            Width = width;
        }

        public void AddBall(Point center)
        {
            BallList.Add(new Ball(center));
        }

        public void Move()
        {
            foreach (var ball in BallList)
            {
                ball.Move(new Point(ball.Center.X + Velocity, ball.Center.Y));
                if (ball.Center.X >= Width + Ball.Radius)
                {
                    ball.State = -1;
                    ++Misses;
                }
            }

            BallList.RemoveAll(ball => ball.State == -1);
        }

        public void Draw(Graphics g)
        {
            foreach (var ball in BallList)
                ball.Draw(g);
        }

        public void IsHit(int x, int y)
        {
            foreach (var ball in BallList)
                if (ball.IsHit(x, y))
                    ++Hits;

            BallList.RemoveAll(ball => ball.State == 0);
        }
    }
}