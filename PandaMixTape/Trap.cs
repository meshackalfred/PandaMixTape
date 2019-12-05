using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaMixTape
{
    class Trap : HipHop
    {
        private  string trapSound;
        public Trap(string newArtist, string newTitle) : base ( newArtist, newTitle)
        {
          
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine(" " + trapSound);
        }
    }
}
