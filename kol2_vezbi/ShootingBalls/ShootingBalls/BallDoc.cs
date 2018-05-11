using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingBalls
{
    [Serializable]
    public class BallDoc
    {
        public List<Ball> Balls { get; }
        public Ball Bomb { get; private set; }
        public int Points { get; private set; }

        public BallDoc()
        {
            Balls = new List<Ball>();
            Points = 0;
        }

        public void AddBall(int width, int height)
        {
            while (true)
            {
                bool coliding = false;
                var b = new Ball(width, height);
                foreach (var ball in Balls)
                {
                    if (ball.Colide(b))
                    {
                        coliding = true;
                        break;
                    }
                }

                if (!coliding)
                {
                    Balls.Add(b);
                    break;
                }
            }
        }

        public void AddBomb(Point center)
        {
            Bomb = new Ball(center, Color.Black);
        }

        public void Draw(Graphics g)
        {
            Balls.ForEach(ball => ball.Draw(g));
            if (Bomb != null)
                Bomb.Draw(g);
        }

        public void Tick()
        {
            foreach (var ball in Balls)
            {
                if (ball.Tick())
                {
                    ball.Disappeared = true;
                }

                if (Bomb != null)
                {
                    if (ball.Colide(Bomb))
                    {
                        ball.Disappeared = true;
                        Points += 1;
                    }
                    Bomb = null;
                }
            }

            Balls.RemoveAll(ball => ball.Disappeared);
        }

        public void Click(Point point)
        {
            foreach (var ball in Balls)
            {
                int points = ball.IsHit(point);
                if (points > 0)
                {
                    ball.Disappeared = true;
                    Points += points;
                }
            }
        }
    }
}