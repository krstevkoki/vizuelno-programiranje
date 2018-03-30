using System.Collections.Generic;

namespace Busses
{
    public class Avtobus
    {
        public string Registration { get; set; }
        public string Name { get; set; }

        public bool IsLocal { get; set; }
        public List<Line> Lines { get; set; }

        public Avtobus()
        {
            Lines = new List<Line>();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Name, Registration, IsLocal ? "L" : "M");
        }
    }
}