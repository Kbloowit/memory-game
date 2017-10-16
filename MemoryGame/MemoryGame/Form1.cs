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
        /* maakt een lijst aan met de foto's van avengers die in de resources staan */
        
          
        

        public Form1()
        {
            InitializeComponent();
            /*maakt een array aan met alle imagefiles ze staan er elk 2 keer in*/
            Bitmap[] avengers = new Bitmap[16];
            avengers[0] = Properties.Resources.america;
            avengers[1] = Properties.Resources.america;
            avengers[2] = Properties.Resources.fury;
            avengers[3] = Properties.Resources.fury;
            avengers[4] = Properties.Resources.thor;
            avengers[5] = Properties.Resources.thor;
            avengers[6] = Properties.Resources.widow;
            avengers[7] = Properties.Resources.widow;
            avengers[8] = Properties.Resources.hawkeyes;
            avengers[9] = Properties.Resources.hawkeyes;
            avengers[10] = Properties.Resources.hulk;
            avengers[11] = Properties.Resources.hulk;
            avengers[12] = Properties.Resources.meme;
            avengers[13] = Properties.Resources.meme;
            avengers[14] = Properties.Resources.stark;
            avengers[15] = Properties.Resources.stark;
            /*array met booleans for de random distributie*/
            bool[] usedpic = new bool[16];
            usedpic[0] = false;
            usedpic[1] = false;
            usedpic[2] = false;
            usedpic[3] = false;
            usedpic[4] = false;
            usedpic[5] = false;
            usedpic[6] = false;
            usedpic[7] = false;
            usedpic[8] = false;
            usedpic[9] = false;
            usedpic[10] = false;
            usedpic[11] = false;
            usedpic[12] = false;
            usedpic[13] = false;
            usedpic[14] = false;
            usedpic[15] = false;

            Bitmap nullimage = new Bitmap(1, 1);
            /*Lijst object voor als we meerdere thema's hebben later*/
            List<Array> theme = new List<Array>();
            {
                theme.Add(avengers);

            }
            /*Picturebox array, zodat alle pictureboxes een afbeelding toekennen makkelijker is*/
            PictureBox[] boxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16 };
            Random rand = new Random();
            /*dit geeft elke picturebox een afbeelding*/
            for (int i = 0; i < avengers.Length; i++ )
            {
                /*label voor de goto, zie else statement voor uitleg*/
                Retry:
                /* random nummer als een integer*/
                int attempt = rand.Next(0, avengers.Length);
                /*als de afbeelding nog niet gebruit is, doet hij dit stuk code*/
                if (usedpic[attempt] == false)
                {
                    /*koppelt een random box met foto nummer i*/
                    boxes[attempt].Image = avengers[i];
                   /*zet usedpic array op true zodat hij niet 2 keer dezelfde afbeelding pakt*/
                    usedpic[attempt] = true;
                }
                else
                {
                    /*als usedpic true is, gaat hij met dezelfde i waarde weer terug naar het maken van een random getal om het opnieuw te proberen*/
                    goto Retry;
                }
            }


        }
        
        



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*hij verandert hier de image van de standaard gay.jpeg naar meme.jpeg als een test*/
            pictureBox1.Image = Properties.Resources.meme;
            
            /*note: alle knoppen hebben dit event nu */

        }

        
    }
}
