using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace MemoryGame
{
    public partial class Highscores : Form
    {
        public static List<string> Names = new List<string>();
        public static List<int> score = new List<int>();
        public Highscores()
        {
            InitializeComponent();

            XmlDocument doc = new XmlDocument();
            try
            {
                
                doc.Load("highscores.xml");
            }
            catch 
            {
                MessageBox.Show("Er is geen ranglijst bestand gevonden", "Foutmelding");
 
            }

            XmlNode idNodes = doc.SelectSingleNode("Highscores/Names");
            foreach (XmlNode node1 in idNodes.ChildNodes)
            {
                Names.Add(node1.InnerText);
            }

            XmlNode scorenodes = doc.SelectSingleNode("Highscores/Scores");
            foreach (XmlNode node1 in scorenodes.ChildNodes)
            {
                score.Add(Convert.ToInt32(node1.InnerText));
            }


        }


        private void Compare()
        {
            foreach (int item in score)
            {
                if (Gamepanel.countP1 > item)
                {
                    score.Add(Gamepanel.countP1);
                    Names.Add(Gamepanel.Players[0]);
                }
                if (Gamepanel.countP2 > item)
                {
                    score.Add(Gamepanel.countP2);
                    Names.Add(Gamepanel.Players[1]);
                }

            }
        }
        

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void Highscores_Load(object sender, EventArgs e)
        {

            if (File.Exists("Highscores.xml"))
            
            {
                SaveXML.Highscoressave();
            }
        }

        private void listBoxPlayers_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBoxScores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
