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


        // maakt media player instanties aan
        // werkt alleen als de computer WMP heeft tho

       public static WindowsMediaPlayer startmuziek = new WindowsMediaPlayer(); //hoofdmenu muziek
        public static WindowsMediaPlayer grunty = new WindowsMediaPlayer(); //gamepanel muziek
        public static WindowsMediaPlayer Nuclear = new WindowsMediaPlayer(); // highscore muziek(?)
        public static WindowsMediaPlayer todokete = new WindowsMediaPlayer(); // meme muziek
           
        public static void Startmuziek() //start hoofdmenu muziek
        {
            
            
            startmuziek.URL = Directory.Basedirectory() + "/muziek/Bloodthirster.mp3"; //geeft aan waar het muziek bestand dat je wilt afspelen staat
            startmuziek.controls.play(); //let it play
            

        }
        public static void Stopmuziek() //stopt muziek
        {
            
            
            startmuziek.controls.stop();
            grunty.controls.stop();

        }

        public static void Correct() //correct melodie
        {
            WindowsMediaPlayer correct = new WindowsMediaPlayer();
            correct.URL = Directory.Basedirectory() + "/muziek/SoundFX/correct.wav";
            correct.controls.play();
        }

        public static void Incorrect() //incorrect melodie
        {
            WindowsMediaPlayer incorrect = new WindowsMediaPlayer();
            incorrect.URL = Directory.Basedirectory() + "/muziek/SoundFX/incorrect.wav";
            incorrect.controls.play();
        }

        public static void Grunty() //speelt achtergrondmuziek
        {
            
            
            grunty.settings.setMode("loop", true); //loopt het nummer
            grunty.controls.play();
            
        }

        public static void Groonty() //zet achtergrond muziek als standaard, onderstaande zetten ze als een andere voor een ander thema
        {
            grunty.URL = Directory.Basedirectory() + "/muziek/Grunty industries.mp3";
        }
        public static void Avengers() //voor avengers thema
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/Grunty industries.mp3";
            

        }

        public static void Formule1() //formule 1 thema
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/F1.mp3";
            

        }

        public static void Runescape() //runescape thema
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/runescape.mp3";
           

        }

        public static void Disney()//didney thema
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/Disney.mp3";
            

        }

        public static void SnowHalation() //TODOKETE (misschien credits scherm
        {

            todokete.URL = Directory.Basedirectory() + "/muziek/BackgroundM/TODOKETE.mp3";
            todokete.settings.setMode("loop", true);
            todokete.controls.play();

        }

        public static void Siivagunner() //highscores scherm
        {

            Nuclear.URL = Directory.Basedirectory() + "/muziek/BackgroundM/Nuclear.mp3";
            Nuclear.settings.setMode("loop", true);
            Nuclear.controls.play();

        }

        public static void Gta5() //gta 5 thema
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/GTA V.mp3";
            

        }

        public static void Cars() //cars thema
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/cars.mp3";
            

        }

        public static void Social() //social media thema
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/Social.mp3";
            

        }

        public static void Winx() //winx thema
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/winx.mp3";
            

        }

        public static void Royalty() //wie zijn deze mensen? thema
        {

            grunty.URL = Directory.Basedirectory() + "/muziek/BackgroundM/GODSAVETHEQUEEN.mp3";
            
        }

    }
}
