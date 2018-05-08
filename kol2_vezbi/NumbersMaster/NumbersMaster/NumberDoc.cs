using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersMaster
{
    [Serializable]
    public class NumberDoc
    {
        public List<Number> Numbers { get; set; }
        public Random Random { get; }
        public int Hits { get; set; }
        public int Misses { get; set; }

        public NumberDoc()
        {
            Numbers = new List<Number>();
            Random = new Random();
            Hits = Misses = 0;
        }

        public void AddNumber(int width, int height)
        {
            Numbers.Add(new Number(width, height, Random));
        }

        public void DrawNumbers(Graphics g)
        {
            foreach (var number in Numbers)
                number.Draw(g);
        }

        public void Tick()
        {
            foreach (var number in Numbers)
                number.Tick();

            var numRemoved = Numbers.RemoveAll(number => number.TimeLeft <= 0);
            if (numRemoved > 0)
                ++Misses;
        }

        public void KeyPressed(int key)
        {
            foreach (var number in Numbers)
                if (number.NumberGuess(key))
                    break;

            var numRemoved = Numbers.RemoveAll(number => number.NumberGuessed);
            if (numRemoved > 0)
                ++Hits;
        }
    }
}