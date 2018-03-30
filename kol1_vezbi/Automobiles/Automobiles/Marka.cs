namespace Automobiles
{
    public class Marka
    {
        public string Name { get; set; }
        public string Sifra { get; set; }

        public Marka()
        {
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Sifra);
        }
    }
}