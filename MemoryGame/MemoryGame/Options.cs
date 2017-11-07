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
                     
                this.Dispose(); // gooit instantie uit geheugen
                 
                       
        }

        private void checkbox_soundeffects_CheckedChanged(object sender, EventArgs e)// soundeffect checkbox
        {
            if (checkbox_soundeffects.CheckState == CheckState.Checked) //checkbox aangevinkt
            {

                Options.Soundeffectsstate = true; //Soundeffects uit

            }
            if (checkbox_soundeffects.CheckState == CheckState.Unchecked)
            {

                Options.Soundeffectsstate = false; //zet soundeffect weer aan


            }

        }

       

        private void checkbox_mute_CheckedChanged(object sender, EventArgs e) //global mute
        {
            if (checkbox_mute.CheckState == CheckState.Checked) //checkbox aangevinkt
            {
                Options.CheckboxBGMstate = true; //Muziek uit
                Options.Soundeffectsstate = true; //Soundeffects uit
                Sounds.Stopmuziek(); //stopt alle muziek
            }
            if (checkbox_mute.CheckState == CheckState.Unchecked)
            {
                Options.CheckboxBGMstate = false; //zet muziek weer aan
                Options.Soundeffectsstate = false; //zet soundeffect weer aan

                if (Application.OpenForms.Count == 3) //als 3 forms openzijn (je komt van gameform)
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
        #region
        /// <summary>
        /// Geeft je de staat van het muziek checkboxje of laat je de staat veranderen
        /// </summary>
        public static bool CheckboxBGMstate { get; set; }
        #endregion
        #region
        /// <summary>
        /// Geeft je de staat van de geluidseffecten checkbox of laat je de staat veranderen
        /// </summary>
        public static bool Soundeffectsstate { get; set; }
        #endregion



    }
}
