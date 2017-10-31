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

        public static WindowsMediaPlayer grunty = new WindowsMediaPlayer();


        public static void Startmuziek()
        {
         startmuziek.URL = Directory.Basedirectory() + "/muziek/Bloodthirster.mp3";
         startmuziek.controls.play();
            

        }
        public static void Stopmuziek()
        {
            
            
            startmuziek.controls.stop();
            grunty.controls.stop();




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


        public static void Grunty()
        {
            
            grunty.URL = Directory.Basedirectory() + "/muziek/Grunty industries.mp3";
            grunty.settings.setMode("loop", true);
            grunty.controls.play();
            
        }


    }
}
