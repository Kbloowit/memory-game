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
            Themez.Achtergrond = Color.Crimson;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Avengers_Click(object sender, EventArgs e)
        {
            Themez.Achtergrond = Color.Blue;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Royalty_Click(object sender, EventArgs e)
        {
            Themez.Achtergrond = Color.Blue;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Winx_Click(object sender, EventArgs e)
        {
            Themez.Achtergrond = Color.Blue;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Gta5_Click(object sender, EventArgs e)
        {
            Themez.Achtergrond = Color.Blue;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Formule1_Click(object sender, EventArgs e)
        {
            Themez.Achtergrond = Color.Blue;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Social_Click(object sender, EventArgs e)
        {
            Themez.Achtergrond = Color.Azure;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
        public void Disney_Click(object sender, EventArgs e)
        {
            Themez.Achtergrond = Color.LightPink;
            Player_import importatie = new Player_import();
            /*opent het game form*/
            this.Dispose();
            importatie.ShowDialog();
        }
    }
}
