using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersMaster
{
    [Serializable]
    public class Number
    {
        public Point Point { get; set; }
        public int TimeLeft { get; set; }
        public bool NumberGuessed { get; set; }
        private readonly int _ballNumber;
        public static readonly int Radius = 30;
        private static readonly int Diameter = 2 * Radius;

        public Number(int width, int height, Random random)
        {
            TimeLeft = 5;  // 5 seconds till it disappears
            _ballNumber = random.Next(10);
            int x = random.Next(Diameter, width - Diameter);
            int y = random.Next(Diameter + 30, height - Diameter - 20);
            Point = new Point(x, y);
            NumberGuessed = false;
        }

        public void Draw(Graphics g)
        {
            var color = Color.Aqua;
            if (TimeLeft < 3)
                color = Color.Red;

            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, Point.X - Radius, Point.Y - Radius, Diameter, Diameter);
            brush.Dispose();

            Brush strBrush = new SolidBrush(Color.Black);
            g.DrawString($"{_ballNumber}", new Font("Times New Roman", 22), strBrush, 
                Point.X - Radius / 2, Point.Y - Radius / 2);
            strBrush.Dispose();
        }

        public void Tick()
        {
            TimeLeft--;
        }

        public bool NumberGuess(int inputNum)
        {
            return NumberGuessed = _ballNumber == inputNum;
        }
    }
}
