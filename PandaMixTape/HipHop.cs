using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaMixTape
{
    class HipHop : Song
    {
        private string hiphopSound;

        public HipHop(string newArtist, string newTitle) : base( newArtist, newTitle)
        {
          
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine(" " + hiphopSound);
        }
    }
}
