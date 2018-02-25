using WMPLib;

namespace zad1
{
    public class Song
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public decimal Rating { get; set; }

        public string URL { get; private set; }

        public Song()
        {
        }

        public Song(string name, int duration, decimal rating, string url = "")
        {
            Name = name;
            Duration = duration;
            Rating = rating;
            URL = url;
        }

        public void PlaySong()
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            wmp.URL = this.URL;
            wmp.controls.play();
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Duration: {1}, Rating: {2}", Name, Duration, Rating);
        }
    }
}