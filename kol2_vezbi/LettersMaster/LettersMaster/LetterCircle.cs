using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersMaster
{
    [Serializable]
    public class LetterCircle
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public char Letter { get; }
        public bool Disappeared { get; set; }
        public bool Guessed { get; set; }

        public static readonly int Radius = 20;
        private static readonly int Diameter = 2 * Radius;

        public LetterCircle(Point center, char letter)
        {
            Center = center;
            Letter = char.ToUpper(letter);
            Color = Color.GreenYellow;
            Disappeared = Guessed = false;
        }

        public void Draw(Graphics g)
        {
            if (Guessed)
                Color = Color.Red;

            using (Brush brush = new SolidBrush(Color))
            {
                g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Diameter, Diameter);
            }

            using (Brush brush = new SolidBrush(Color.Black))
            {
                g.DrawString($"{Letter}", new Font("Arial", 22), brush,
                    Center.X - (Radius / 2) - 5, Center.Y - (Radius / 2) - 5);
            }
        }

        public void Move(int height)
        {
            int newY = Center.Y + 10;
            if (newY + Radius > height)
                Disappeared = true;

            Center = new Point(Center.X, newY);
        }

        public bool IsGuessed(char quess)
        {
            return char.ToUpper(quess) == Letter;
        }

        public bool Colided(LetterCircle another)
        {
            return Distance(this.Center, another.Center) <= Diameter;
        }

        public static double Distance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }
    }
}