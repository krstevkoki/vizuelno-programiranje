namespace F1Race
{
    public class Lap
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Lap()
        {
        }

        public int ToSeconds()
        {
            return Minutes * 60 + Seconds;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", Minutes, Seconds);
        }
    }
}