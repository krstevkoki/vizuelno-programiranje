namespace Busses
{
    public class Line
    {
        public string City { get; set; }
        public decimal Price { get; set; }
        public string DepartureTime { get; set; }

        public Line()
        {
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} Ден.", DepartureTime, City, Price);
        }
    }
}