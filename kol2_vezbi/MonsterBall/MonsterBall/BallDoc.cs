using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBall
{
    [Serializable]
    public class BallDoc
    {
        public List<Ball> Balls { get; set; }

        public int Count
        {
            get { return Balls.Count; }
        }

        public BallDoc()
        {
            Balls = new List<Ball>();
        }

        public void AddBall(Ball ball)
        {
            Balls.Add(ball);
        }

        public void DrawBalls(Graphics g, Font font)
        {
            foreach (var ball in Balls)
                ball.Draw(g, font);
        }

        public void MoveBalls(int left, int top, int width, int height)
        {
            foreach (var ball in Balls)
                ball.Move(left, top, width, height);
        }

        public void CanSwallow()
        {
            for (int i = 0; i < Count; ++i)
            {
                for (int j = i + 1; j < Count; ++j)
                {
                    if (!Balls[i].IsTouching(Balls[j])) continue;

                    if (Balls[i].Radius > Balls[j].Radius)
                    {
                        Balls[i].Counter++;
                        Balls[j].Counter--;
                    }
                    else if (Balls[i].Radius < Balls[j].Radius)
                    {
                        Balls[i].Counter--;
                        Balls[j].Counter++;
                    }
                }
            }

            Balls.RemoveAll(ball => ball.Counter < 0);
        }
    }
}