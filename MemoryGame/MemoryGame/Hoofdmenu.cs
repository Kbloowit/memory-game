using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Hoofdmenu : Form
    {
        /*tip: zet de dingen die je wilt gebruiken in de memory game in de resources.resx bestand, lees doc dat hierbij zit voor hoe dat moet(hoe is wat onder tutorials)*/
        
        
        

        /* dit stuk hieronder zet de muziek voor het startmenu klaar, ik heb hier eerst als placeholder Pentakill - Lightbringer gebruikt*/
        System.Media.SoundPlayer startmuziek = new System.Media.SoundPlayer(Properties.Resources.Pentakill);
        public Hoofdmenu()
        {
            InitializeComponent();
            /* dit start de pentakill muziek*/
             
            
        }
        

        private void button_options_Click(object sender, EventArgs e)
        {
            /*dit stuk maakt een nieuwe instantie van het Opties form aan en opent deze*/
            Options opties = new Options(this);
            opties.Show();
            this.Hide();
            /* dit moet het hoofdmenu form sluiten maar het doet nog niet helemaal wat ik wil*/
            
               
        }

        public void button1_Click(object sender, EventArgs e)
        {
            /* geeft aan waar weg hij gecalled wordt*/
            Player_import game = new Player_import();
            /*opent het game form*/
            game.Show();
            
            
            
        }

        private void button_highscore_Click(object sender, EventArgs e)
        {
            Highscores highscores = new Highscores();
            highscores.ShowDialog();
                
        }

<<<<<<< HEAD
       
=======
        private void Hoofdmenu_Load(object sender, EventArgs e)
        {
            startmuziek.Play();
        }
>>>>>>> c2c4f725d7b354463c18eaf9e082689d3185544f
    }
}
