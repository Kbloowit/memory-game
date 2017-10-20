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
    public partial class Form1 : Form
    {
        /*aanroep naam voor hoofdmenu form in de code*/
        Player_import hoofd;
        Hoofdmenu meme;

        /*geeft naam aan form waar deze vanaf geopend is*/
        public Form1(string P1, string P2) 
        {
            InitializeComponent();
            
            namep1.Text = P1;
            NameP2.Text = P2;
            
                
                                      
           
                                
                           
        }
        
        





        private void button_reset_Click(object sender, EventArgs e)
        {
            Player_import killme = new Player_import();
            killme.Show();
           
            this.Dispose();

            
            
            
        }

        private void button_opties_Click(object sender, EventArgs e)
        {
            Options opties = new Options();
            opties.ShowDialog();

        }
    }
}
