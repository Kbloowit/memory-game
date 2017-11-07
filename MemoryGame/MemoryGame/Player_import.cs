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
            string[] players = { importP1.Text, importP2.Text };
            Gamepanel game = new Gamepanel(players); // In deze regel worden de namen meegestuurd in het volgende window
            game.Show();
            
            this.Dispose();
        }
    } 
}
