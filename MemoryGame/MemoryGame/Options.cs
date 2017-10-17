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
        Hoofdmenu hfd;
        public Options(Hoofdmenu call)
        {
            InitializeComponent();
            hfd = call;
        }

        private void button_back_Click(object sender, EventArgs e)
        {

            hfd.Show();
            this.Close();
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
            if (checkbox_backgroundmusic.CheckState == CheckState.Checked)
            {
                hfd.Hoofdmenu_Load(checkbox_backgroundmusic, e);
            }
        }
    }
}
