using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersMaster
{
    [Serializable]
    public class LettersDoc
    {
        public List<LetterCircle> LetterCircles { get; set; }
        public List<int> Distribution { get; set; }
        public int Hits { get; set; }
        public int Misses { get; set; }

        public LettersDoc()
        {
            LetterCircles = new List<LetterCircle>();
            Distribution = new List<int>();
            for (int i = 0; i <= 'Z' - 'A'; i++)
                Distribution.Add(0);
            Hits = Misses = 0;
        }

        public void AddLetter(int width, Random random)
        {
            while (true)
            {
                var x = random.Next(2 * LetterCircle.Radius, width - 2 * LetterCircle.Radius);
                var y = -LetterCircle.Radius;
                var letter = (char) random.Next(65, 65 + 26);
                var circle = new LetterCircle(new Point(x, y), letter);

                if (IsUnique(circle.Letter) && !IsColided(circle))
                {
                    LetterCircles.Add(circle);
                    break;
                }
            }
        }

        public void DrawLetters(Graphics g)
        {
            LetterCircles.ForEach(letter => letter.Draw(g));
        }

        public void Move(int height)
        {
            LetterCircles.ForEach(letter => letter.Move(height));

            Misses += LetterCircles.RemoveAll(letter => letter.Disappeared);
            LetterCircles.RemoveAll(letter => letter.Guessed);
        }

        public void Guess(char guess)
        {
            foreach (var letterCircle in LetterCircles)
            {
                if (letterCircle.IsGuessed(guess))
                {
                    letterCircle.Guessed = true;
                    ++Hits;
                    var index = letterCircle.Letter - 'A';
                    Distribution[index]++;
                }
            }
        }

        public string GetDistribution()
        {
            var sb = new StringBuilder();

            for (int i = 'A'; i <= 'Z'; i++)
                sb.Append((char) i).Append(" : ").Append(Distribution[i - 'A']).Append(" ");

            return sb.ToString();
        }

        private bool IsColided(LetterCircle circle)
        {
            foreach (var letterCircle in LetterCircles)
                if (letterCircle.Colided(circle))
                    return true;

            return false;
        }

        private bool IsUnique(char letter)
        {
            foreach (var letterCircle in LetterCircles)
                if (letterCircle.Letter == letter)
                    return false;

            return true;
        }
    }
}