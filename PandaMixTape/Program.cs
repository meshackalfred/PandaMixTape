using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaMixTape
{
    class Program
    {
        static void Main(string[] args)
        {
            string songGenre;
            string artist;
            string title;
            string decisionFromUser;

            Song song;
            Player player = new Player();
            do
            {
                Console.Write("Enter Music Genre: >> ");
                songGenre = Console.ReadLine();
                Console.Write("Enter Music Artist: >> ");
                artist = Console.ReadLine();
                Console.Write("Enter Music Title: >> ");
                title = Console.ReadLine();

                if (songGenre == "HipHop" || songGenre == "hiphop")
                {
                    song = new HipHop(artist, title);
                }
                else if (songGenre == "Romantic" || songGenre == "romantic")
                {
                    song = new Romantic(artist, title);
                }
                else if (songGenre == "OldSchool" || songGenre == "OldSchool")
                {
                    song = new OldSchool(artist, title);
                }
                else if (songGenre == "HardCore" || songGenre == "hardcore")
                {
                    song = new HardCore(artist, title);
                }

                else 
                {
                    song = new Trap(artist, title);
                }
                player.AddSong(song);
                Console.WriteLine("Do you want to add more Music??? Y/N");
                decisionFromUser = Console.ReadLine();
                Console.Clear();
            } while (decisionFromUser == "Y" || decisionFromUser == "y");

            
            player.Play();

        }


    }
}
