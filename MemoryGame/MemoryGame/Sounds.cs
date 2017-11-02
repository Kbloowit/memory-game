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
        public static WindowsMediaPlayer Nuclear = new WindowsMediaPlayer();
        public static WindowsMediaPlayer todokete = new WindowsMediaPlayer();
           
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

        public static void Avengers()
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/Grunty industries.mp3";
            grunty.settings.setMode("loop", true);
            grunty.controls.play();

        }

        public static void Formule1()
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/Nuclear.mp3";
            grunty.settings.setMode("loop", true);
            grunty.controls.play();

        }

        public static void Runescape()
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/Nuclear.mp3";
            grunty.settings.setMode("loop", true);
            grunty.controls.play();

        }

        public static void Disney()
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/Disney.mp3";
            grunty.settings.setMode("loop", true);
            grunty.controls.play();

        }

        public static void SnowHalation()
        {

            todokete.URL = Directory.Basedirectory() + "/muziek/BackgroundM/TODOKETE.mp3";
            todokete.settings.setMode("loop", true);
            todokete.controls.play();

        }

        public static void Siivagunner()
        {

            Nuclear.URL = Directory.Basedirectory() + "/muziek/BackgroundM/Nuclear.mp3";
            Nuclear.settings.setMode("loop", true);
            Nuclear.controls.play();

        }

        public static void Gta5()
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/GTA V.mp3";
            grunty.settings.setMode("loop", true);
            grunty.controls.play();

        }

        public static void Cars()
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/cars.mp3";
            grunty.settings.setMode("loop", true);
            grunty.controls.play();

        }

        public static void Social()
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/Social.mp3";
            grunty.settings.setMode("loop", true);
            grunty.controls.play();

        }

        public static void Winx()
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/winx.mp3";
            grunty.settings.setMode("loop", true);
            grunty.controls.play();

        }

        public static void Royalty()
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/GODSAVETHEQUEEN.mp3";
            grunty.settings.setMode("loop", true);
            grunty.controls.play();
            
        }

    }
}
