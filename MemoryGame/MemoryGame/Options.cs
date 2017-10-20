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
    public partial class Options : Form
    {
        private readonly Hoofdmenu hfd;
        Form2 uhh;
        public Options()
        {
            InitializeComponent();
            
            
        }

        private void button_back_Click(object sender, EventArgs e)
        {
                     
                this.Dispose();
                 
                       
        }

        private void checkbox_soundeffects_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void checkbox_mute_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_backgroundmusic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_backgroundmusic.CheckState == CheckState.Unchecked)
            {
                Sounds.Startmuziek();
            }
            else if (checkbox_backgroundmusic.CheckState == CheckState.Checked)
            {
                Sounds.Stopmuziek();
            }
        }

       
    }
}
