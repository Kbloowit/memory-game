
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace MemoryGame
{
    public  class Sounds
    {




       public static WindowsMediaPlayer startmuziek = new WindowsMediaPlayer();
        public static void Startmuziek()
        {

            
            startmuziek.URL = Directory.Basedirectory() + "/muziek/Pent.mp3";
            startmuziek.controls.play();
            

        }
        public static void Stopmuziek()
        {
            
            
            startmuziek.controls.stop();


        }

        public static void Correct()
        {
            WindowsMediaPlayer correct = new WindowsMediaPlayer();
            correct.URL = Directory.Basedirectory() + "/muziek/SoundFX/correct.wav";
            correct.controls.play();
        }

        public static void Incorrect()
        {
            WindowsMediaPlayer incorrect = new WindowsMediaPlayer();
            incorrect.URL = Directory.Basedirectory() + "/muziek/SoundFX/incorrect.wav";
            incorrect.controls.play();
        }




    }
}
