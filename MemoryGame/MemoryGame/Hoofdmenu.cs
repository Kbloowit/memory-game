using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Xml;

namespace MemoryGame
{
    
    public partial class Hoofdmenu : Form
    {
        /*tip: zet de dingen die je wilt gebruiken in de memory game in de resources.resx bestand, lees doc dat hierbij zit voor hoe dat moet(hoe is wat onder tutorials)*/

        public string meme;


        /* dit stuk hieronder zet de muziek voor het startmenu klaar, ik heb hier eerst als placeholder Pentakill - Lightbringer gebruikt*/

        public Hoofdmenu()
        {
            InitializeComponent();
            /* dit start de pentakill muziek*/
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            /*dit stuk maakt een nieuwe instantie van het Opties form aan en opent deze*/
            Options opties = new Options();
            this.Hide(); //verstopt hoofdmenu form
            opties.ShowDialog();
            this.Show(); //doet een magische truc en brengt hoofdmenu form terug
           
            /* dit moet het hoofdmenu form sluiten maar het doet nog niet helemaal wat ik wil*/

        }

        public void buttonPlay_Click(object sender, EventArgs e)
        {
            if (File.Exists("Memory.sav"))
            {
                string[] spelernamen = new string[2];
                DialogResult dialog = MessageBox.Show("Wilt u verder met het vorige spel?", "Spel laden?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load("Memory.sav");

                    spelernamen[0] = Convert.ToString(xDoc.SelectSingleNode("Game/players/Player1").InnerText);
                    spelernamen[1] = Convert.ToString(xDoc.SelectSingleNode("Game/players/Player2").InnerText);

                    Savegameused = true;
                    Gamepanel game = new Gamepanel(spelernamen);
                    this.Hide();
                    game.ShowDialog();


                }
                else
                {
                    
                }
            }
            /* geeft aan waar weg hij gecalled wordt*/
            Thema themaselect = new Thema();
            //Player_import k = new Player_import();
            /*opent het game form*/
            this.Hide(); //verstopt hoofdmenu form
            themaselect.ShowDialog();
            //k.ShowDialog();


        }

        private void buttonHighscore_Click(object sender, EventArgs e) //opent highscores form
        {
            Highscores highscores = new Highscores();
            this.Hide(); //versteckt das Hauptmenu Form
            highscores.ShowDialog();
            this.Show(); //ZVARRI! het hoofdmenu form is terug
        }

        private void Hoofdmenu_Load(object sender, EventArgs e) //start de hoofdmenu muziek op opstarten
        {
            Sounds.Startmuziek();

            
        }

        public static bool Savegameused { get; set; }


    }
}
