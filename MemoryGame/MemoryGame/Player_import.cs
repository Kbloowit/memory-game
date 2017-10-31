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
    public partial class Player_import : Form
    {
        public Player_import()
        {
            InitializeComponent();
        }

        public void buttonStart_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string[] players = { importP1.Text, importP2.Text };
            Gamepanel game = new Gamepanel(players); // In deze regel worden de namen meegestuurd in het volgende window
=======
            string[] players = { importP1.Text, importP2.Text }; // Hiermee worden de ingevulde namen opgeslagen in een array
            GamePanel game = new GamePanel(players); // In deze regel worden de namen meegestuurd in het volgende window
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            game.Show();
            
            this.Dispose();
            game.Focus();


        }


    } 
}
