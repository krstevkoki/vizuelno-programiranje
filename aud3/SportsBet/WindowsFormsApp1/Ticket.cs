using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Ticket
    {
        public Game Game { get; set; }
        public int Tip { get; set; }

        public Ticket()
        {
        }

        public Ticket(Game game, int tip)
        {
            Game = game;
            this.Tip = tip;
        }

        public override string ToString()
        {
            return string.Format("{0} vs. {1}: {2}", Game.Home, Game.Away, Tip == 0 ? "1" : (Tip == 1 ? "X" : "2"));
        }
    }
}
