using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaMixTape
{
    class HardCore : OldSchool
    {
        private string hardCoreSound;

        public HardCore(string newArtist, string newTitle) : base(newArtist, newTitle)
        {
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine(" " + hardCoreSound);
        }
    }
}
