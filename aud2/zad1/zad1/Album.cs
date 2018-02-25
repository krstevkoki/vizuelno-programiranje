using System.Collections.Generic;
using System.Text;

namespace zad1
{
    public class Album
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Song> Songs { get; private set; }

        public Album()
        {
            Songs = new List<Song>();
        }

        public Album(string name, int year)
        {
            Name = name;
            Year = year;
            Songs = new List<Song>();
        }

        public void AddSong(Song s)
        {
            Songs.Add(s);
        }

        public void AddSong(string name, int duration, decimal rating)
        {
            Songs.Add(new Song(name, duration, rating));
        }

        public Song FindSong(string songName)
        {
            foreach (var song in Songs)
                if (song.Name.ToLower() == songName.ToLower())
                    return song;
            throw new SongNotFoundException(songName);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Album name: ").Append(Name).Append("\n");
            sb.Append("Year of release: ").Append(Year).Append("\n");
            sb.Append("Songs: \n");
            foreach (var song in Songs)
                sb.Append(song).Append("\n");

            return sb.ToString();
        }
    }
}