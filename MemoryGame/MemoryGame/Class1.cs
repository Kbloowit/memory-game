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
<<<<<<< HEAD
        public static WindowsMediaPlayer grunty = new WindowsMediaPlayer();
=======
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        public static void Startmuziek()
        {

            
<<<<<<< HEAD
            startmuziek.URL = Directory.Basedirectory() + "/muziek/Bloodthirster.mp3";
=======
            startmuziek.URL = Directory.Basedirectory() + "/muziek/Pent.mp3";
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            startmuziek.controls.play();
            

        }
        public static void Stopmuziek()
        {
            
            
            startmuziek.controls.stop();
<<<<<<< HEAD
            grunty.controls.stop();
=======

>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd

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

<<<<<<< HEAD
        public static void Grunty()
        {
            
            grunty.URL = Directory.Basedirectory() + "/muziek/Grunty industries.mp3";
            grunty.settings.setMode("loop", true);
            grunty.controls.play();
            
        }
=======

>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd


    }
}
