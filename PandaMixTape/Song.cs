using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaMixTape
{
    class Song
    {
        protected string artist { get; private set; }
        protected string title { get; private set; }

        public Song(string newArtist, string newTitle)
        {
            this.artist = newArtist;
            this.title = newTitle;
        }

        public virtual void Play()
        {
            Console.Write(artist+ " " + title); 
        }
    }
}
