using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines2
{
    public enum ActionType
    {
        Add,
        Remove
    }

    public class Action
    {
        public Line Line { get; set; }
        public ActionType Type { get; set; }
    }
}