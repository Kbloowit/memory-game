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
    }
}
