namespace Airports
{
    public class Destination
    {
        public string City { get; set; }
        public decimal Distance { get; set; }
        public int Price { get; set; }

        public Destination()
        {
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}km - {2} EUR", City, Distance, Price);
        }
    }
}