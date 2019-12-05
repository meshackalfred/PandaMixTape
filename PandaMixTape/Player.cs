using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaMixTape
{
    class Player
    {

        List<Song> playList = new List<Song>();

        public Player()
        {

        }
        public void AddSong(Song song)
        {
            if(song != null)
            playList.Add(song);
        }
        public void RemoveSong(int songNumber)
        {
            if(playList != null)
            playList.RemoveAt(songNumber);      
        }
        public  void Play()
        {
            
            if(playList != null)
            {
                foreach (Song song in playList)
                {
                      Console.WriteLine(song);
                }
               
            }
               
        }
    }
}
