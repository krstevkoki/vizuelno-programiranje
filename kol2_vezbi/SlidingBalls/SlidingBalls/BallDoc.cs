using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingBalls
{
    [Serializable]
    public class BallDoc
    {
        public List<Ball> Balls { get; set; }
        private Ball _movingBall;

        public int Count
        {
            get { return Balls.Count; }
        }

        public bool IsMoving
        {
            get { return _movingBall != null; }
        }

        public BallDoc()
        {
            Balls = new List<Ball>();
            _movingBall = null;
        }

        public void AddBall(Point center, Color color)
        {
            Balls.Add(new Ball(center, color));
        }

        public void DrawBalls(Graphics g)
        {
            Balls.ForEach(ball => ball.Draw(g));
        }

        public bool SelectBall(Point point)
        {
            if (_movingBall == null)
            {
                foreach (var ball in Balls)
                {
                    if (ball.Clicked(point) && ball.Color == Color.Red)
                    {
                        _movingBall = ball;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool Move(int width, int height)
        {
            for (int i = Count - 1; i >= 0; --i)
            {
                if (_movingBall.TouchesGreen(Balls[i]))
                    Balls.RemoveAt(i);
            }

            _movingBall.Move(width, height);

            if (Balls.RemoveAll(ball => ball.OutOfBounds) > 0)
            {
                _movingBall = null;
                return true;
            }

            return false;
        }
    }
}