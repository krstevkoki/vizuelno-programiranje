using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Game
    {
        public Team Home { get; set; }
        public Team Away { get; set; }
        public string Code { get; set; }
        public decimal[] Coefficients { get; set; }

        public Game(Team home, Team away, string code, decimal[] coefficients)
        {
            Home = home;
            Away = away;
            Code = code;
            Coefficients = coefficients;
        }

        public Game()
        {
            Coefficients = new decimal[3];
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} vs. {2}", Code, Home.Name, Away.Name);
        }
    }
}