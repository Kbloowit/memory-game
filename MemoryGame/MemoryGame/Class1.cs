using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace MemoryGame
{
    public class Sounds
    {
        
        
        
        
        
        public static void Startmuziek()
        {

            WindowsMediaPlayer startmuziek = new WindowsMediaPlayer();
            startmuziek.URL = Directory.Basedirectory() + "/muziek/Pent.mp3";
            startmuziek.controls.play();
            

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
