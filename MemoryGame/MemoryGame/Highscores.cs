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
    public partial class Highscores : Form
    {
        public Highscores()
        {
            InitializeComponent();
            List<string> names = new List<string>
            {

            };
            List<int> score = new List<int>
            {

            };
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
