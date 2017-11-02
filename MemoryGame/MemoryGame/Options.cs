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
        
        public Options()
        {
            InitializeComponent();
            
            
        }

        private void button_back_Click(object sender, EventArgs e)
        {
                     
                this.Hide();
                 
                       
        }

        private void checkbox_soundeffects_CheckedChanged(object sender, EventArgs e)
        {
            Options.Soundeffectsstate = true;

        }

        

        private void Options_Load(object sender, EventArgs e)
        {
            if (Options.CheckboxBGMstate == true)
            {
                checkbox_backgroundmusic.CheckState = CheckState.Checked;
            }


        }

        private void checkbox_mute_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_mute.CheckState == CheckState.Checked)
            {
                Options.CheckboxBGMstate = true;
                Options.Soundeffectsstate = true;
                Sounds.Stopmuziek();
            }
            if (checkbox_mute.CheckState == CheckState.Unchecked)
            {
                Options.CheckboxBGMstate = false;
                Options.Soundeffectsstate = false;

                if (Application.OpenForms.Count == 3)
                {
                    Sounds.Grunty();
                }
                else
                {
                    Sounds.Startmuziek();

                }
            }


        }

        private void checkbox_backgroundmusic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_backgroundmusic.CheckState == CheckState.Unchecked)
            {
                Options.CheckboxBGMstate = false;
                if (Application.OpenForms.Count == 3)
                {
                    Sounds.Grunty();
                }
                else
                {
                    Sounds.Startmuziek();
                }
                
            }
            else if (checkbox_backgroundmusic.CheckState == CheckState.Checked)
            {
                Options.CheckboxBGMstate = true;
                Sounds.Stopmuziek();

            }
        }
        public static bool CheckboxBGMstate { get; set; }
        public static bool Soundeffectsstate { get; set; }
        
        
       
    }
}
