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
        List<Image> avengers = new List<Image>
        {
            Properties.Resources.thor , Properties.Resources.thor ,  Properties.Resources.widow , Properties.Resources.widow , Properties.Resources.hulk , Properties.Resources.hulk ,  Properties.Resources.meme ,
            Properties.Resources.meme , Properties.Resources.stark , Properties.Resources.stark ,  Properties.Resources.fury , Properties.Resources.fury , Properties.Resources.hawkeyes , Properties.Resources.hawkeyes ,  Properties.Resources.america , Properties.Resources.america
        };
        public Form1()
        {
            InitializeComponent();
        }
        



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.meme;
        }


    }
}
