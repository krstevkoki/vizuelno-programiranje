using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Album album = new Album("Queen", 1984);
            album.AddSong(new Song("I want to break free", 200, Convert.ToDecimal(3.5), @"C:\Users\krste\Queen - I Want To Break Free.m4a"));
            album.AddSong("Bohemian Rapsody", 150, Convert.ToDecimal(4.3));
            album.AddSong(new Song("Wind of changing", 230, Convert.ToDecimal(2.7)));
            Console.WriteLine(album);
            try
            {
                Song s = album.FindSong("I Want To Break Free");
                Console.WriteLine(s);
                s.PlaySong();
                // Console.WriteLine(album.FindSong("Volis li me"));
            }
            catch (SongNotFoundException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            Console.Read();
        }
    }
}
