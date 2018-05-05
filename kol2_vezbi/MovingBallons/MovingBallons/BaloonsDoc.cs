using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingBallons
{
    [Serializable]
    public class BaloonsDoc
    {
        public List<Baloon> Baloons { get; }

        public BaloonsDoc()
        {
            Baloons = new List<Baloon>();
        }

        public int BallonsCount()
        {
            return Baloons.Count;
        }

        public void AddBaloon(Point center, Color color)
        {
            Baloons.Add(new Baloon(center, color));
        }

        public void DrawBaloons(Graphics g)
        {
            foreach (var baloon in Baloons)
                baloon.Draw(g);
        }

        public void MoveBaloons(int top, int height)
        {
            foreach (var baloon in Baloons)
                if (baloon.Selected)
                    baloon.Move(top, height);
        }

        public void SelectBaloon(int x, int y)
        {
            foreach (var baloon in Baloons)
                if (baloon.Select(x, y))
                    baloon.Selected = !baloon.Selected;
        }

        public void SelectAllBaloons(bool status)
        {
            foreach (var baloon in Baloons)
                baloon.Selected = status;
        }
    }
}