using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallChaos
{
    public enum Actions
    {
        Add,
        Remove
    }

    public class Action
    {
        public Ball Ball { get; set; }
        public Actions CurrentAction { get; set; }
    }
}