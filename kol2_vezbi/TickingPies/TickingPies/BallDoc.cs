using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
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

        public void AddBall(Point center, Color color)
        {
            Balls.Add(new Ball(center, color));
        }

        public void Draw(Graphics g)
        {
            Balls.ForEach(ball => ball.DrawPie(g));
        }

        public void Tick()
        {
            foreach (var ball in Balls)
                if (ball.Tick())
                    ball.Disappeared = true;

            Balls.RemoveAll(ball => ball.Disappeared);
        }
    }
}
