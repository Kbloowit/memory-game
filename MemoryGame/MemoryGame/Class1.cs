using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class Soundplayers
    {
        System.Media.SoundPlayer startmuziek = new System.Media.SoundPlayer(Properties.Resources.Pentakill);
        public static void Startmuziek()
        {
            System.Media.SoundPlayer startmuziek = new System.Media.SoundPlayer(Properties.Resources.Pentakill);
            startmuziek.Play();   
        }
        public static void Stopmuziek()
        {
            System.Media.SoundPlayer startmuziek = new System.Media.SoundPlayer(Properties.Resources.Pentakill);
            startmuziek.Stop();
        }

    }
}
