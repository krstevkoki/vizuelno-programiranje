using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    public class Avtomobil
    {
        public Marka Marka { get; set; }
        public string Model { get; set; }
        public decimal Potrosuvacka { get; set; }
        public decimal Cena { get; set; }

        public Avtomobil()
        {
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2:.0} {3}", Marka.Name, Model, Potrosuvacka, Cena);
        }
    }
}