using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections;

namespace MemoryGame
{
    public partial class Highscores : Form
    {
        public Highscores()
        {
            InitializeComponent();

            











        }



        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Highscores_Load(object sender, EventArgs e)
        {
            
            ArrayList highscore = new ArrayList(); // maakt een list die je kan uitlezen als een array aan
            if (File.Exists("Highscores.xml")) // als highscores.xml
            {
                int[] scores = new int[10]; // lijst met hoogste scores (om in uit te lezen? kijk maar of je ze nodig hebt)
                string[] names = new string[10]; // lijst met namen bij hoogste scores
            }
            else// als het er niet is
            {
                if (Gamepanel.countP1 > Gamepanel.countP2) // p1 heeft hogere score
                {
                    highscore.Add(Gamepanel.Players[0] +"         "+ Gamepanel.countP1); //p1 eerst
                    highscore.Add(Gamepanel.Players[1] +"         "+ Gamepanel.countP2); //p2 eerts

                    highscorebox.Items.Clear(); //leegmaken box
                    
                    highscorebox.DataSource = highscore; //data voor listbox = highscore arraylist
                }
                else //anders,
                {
                    highscore.Add(Gamepanel.Players[1] +"         "+ Gamepanel.countP2); // p2 eerst
                    highscore.Add(Gamepanel.Players[0] +"         "+ Gamepanel.countP1); // p1 eerst

                    highscorebox.Items.Clear(); // leegmaken box
                    
                    highscorebox.DataSource = highscore; // data voor listbox = highscore arraylist
                }
            }


          



        }
    }
    
}


       
