using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class Sounds
    {
        int Muziek = 1;
        int Soundeffects = 1;
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

        public static void Correct()
        {
            System.Media.SoundPlayer correct = new System.Media.SoundPlayer(Properties.Resources.Correct);
            correct.Play();
        }

        public static void Incorrect()
        {
            System.Media.SoundPlayer incorrect = new System.Media.SoundPlayer(Properties.Resources.Incorrect);
            
            incorrect.Play();
        }




    }
}
