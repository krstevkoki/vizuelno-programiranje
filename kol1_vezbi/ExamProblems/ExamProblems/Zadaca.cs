namespace ExamProblems
{
    public class Zadaca
    {
        public string Description { get; set; }
        public int Points { get; set; }

        public Zadaca()
        {
        }

        public override string ToString()
        {
            return string.Format("Description: {0}\nPoints: {1}", Description, Points);
        }
    }
}