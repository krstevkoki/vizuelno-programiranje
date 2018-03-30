using System.Collections.Generic;

namespace Airports
{
    public class Airport
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Destination> Destinations { get; set; }

        public Airport()
        {
            Destinations = new List<Destination>();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Code, Name, City);
        }
    }
}