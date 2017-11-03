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

namespace MemoryGame
{
    public partial class Thema : Form
    {
        public Thema()
        {

            InitializeComponent();
        }
        public void Cars_Click(object sender, EventArgs e)
        {
            Themez.Themepicked = 1;//Voor de juiste afbeeldingen die in een if statement staan in de gamepanel.
            Themez.Achtergrond = Color.Crimson;// hiermee bepaal je de achtergrondskleur van de game, die wordt opgeslagen en opgehaald
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Avengers_Click(object sender, EventArgs e)
        {
            Themez.Themepicked = 2;
            Themez.Achtergrond = Color.Blue;

            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Royalty_Click(object sender, EventArgs e)
        {
            Themez.Themepicked = 3;
            Themez.Achtergrond = Color.RoyalBlue;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Winx_Click(object sender, EventArgs e)
        {
            Themez.Themepicked = 4;
            Themez.Achtergrond = Color.BlueViolet;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Gta5_Click(object sender, EventArgs e)
        {
            Themez.Themepicked = 5;
            Themez.Achtergrond = Color.YellowGreen;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Formule1_Click(object sender, EventArgs e)
        {
            Themez.Themepicked = 6;
            Themez.Achtergrond = Color.DarkOrange;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Social_Click(object sender, EventArgs e)
        {
            Themez.Themepicked = 7;
            Themez.Achtergrond = Color.PaleTurquoise;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Disney_Click(object sender, EventArgs e)
        {
            Themez.Themepicked = 8;
            Themez.Achtergrond = Color.LightPink;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }



    }
}
