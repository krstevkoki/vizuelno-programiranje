using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    [Serializable]
    public class BallsDoc
    {
        public List<Ball> Balls { get; }
        public List<Hole> Holes { get; }
        private static readonly int Velocity = 10;

        public BallsDoc()
        {
            Balls = new List<Ball>();
            Holes = new List<Hole>();
        }

        public int BallsCount()
        {
            return Balls.Count;
        }

        public int HolesCount()
        {
            return Holes.Count;
        }

        public void AddBall(Point center, Color color)
        {
            Balls.Add(new Ball(center, color, Velocity));
        }

        public void AddHole(Point center)
        {
            Holes.Add(new Hole(center));
        }

        public void DrawBalls(Graphics g)
        {
            foreach (var ball in Balls)
                ball.Draw(g);
        }

        public void MoveBalls(int left, int top, int width, int height)
        {
            foreach (var ball in Balls)
                ball.Move(left, top, width, height);
        }

        public void DrawHoles(Graphics g, Font font)
        {
            foreach (var hole in Holes)
                hole.Draw(g, font);
        }

        public void BallsSwallow()
        {
            foreach (var hole in Holes)
            {
                for (int i = Balls.Count - 1; i >= 0; i--)
                    if (hole.SwallowBall(Balls[i]))
                        Balls.RemoveAt(i);
            }
        }

        public void ClearHoles()
        {
            Holes.Clear();
        }
    }
}