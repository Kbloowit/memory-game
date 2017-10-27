using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MemoryGame
{
    public partial class Form2 : Form

    {
        #region allowClick
        /// <summary>
        /// Bool die de plaatjes klikbaar kan maken of juist niet.
        /// </summary>
        bool allowClick = false;
        #endregion
        #region firstguess
        /// <summary>
        /// Eerste gekozen plaatje.
        /// </summary>
        PictureBox firstGuess;
        #endregion
        #region rnd
        /// <summary>
        /// Geeft een Random getal.
        /// </summary>
        Random rnd = new Random();
        #endregion
        #region clicktimer
        /// <summary>
        /// Tijd voordat je weer op de plaatjes mag klikken
        /// </summary>
        Timer clickTimer = new Timer();
        #endregion
        int time = 60;
        #region
        /// <summary>
        /// Timer van de game
        /// </summary>
        Timer timer = new Timer { Interval = 1000 };
        #endregion


        #region
        /// <summary>
        /// Score Speler 1
        /// </summary>
        int countP1 = 0;
        #endregion
        #region
        /// <summary>
        /// Score Speler 2
        /// </summary>
        int countP2 = 0;
        #endregion
        #region
        /// <summary>
        /// geeft aan hoe vaak speler x een kaart heeft omgedraaid
        /// </summary>
        int omgedraaid1 = 0;
        int omgedraaid2 = 0;
        #endregion 

        /* neemt de namen mee van het Player_Import Form*/
        public Form2(String[] players)
        {
            InitializeComponent();

            NameP1.Text = players[0];
            NameP2.Text = players[1];

        }
        /* maakt een picturebox array*/
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        /*maakt een array met images, IEnumerable zorgt ervoor dat de Image class gebruikt kan worden voor een Foreach loop(ggrks)*/
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    /* o shit onze image files*/
                    Properties.Resources.meme,
                    Properties.Resources.america,
                    Properties.Resources.fury,
                    Properties.Resources.hulk,
                    Properties.Resources.widow,
                    Properties.Resources.thor,
                    Properties.Resources.stark,
                    Properties.Resources.hawkeyes




                };
            }
        }
        /*deze method start de Gametimer op, zodat hij naar beneden loopt*/
        private void startGameTimer()
        {
            timer.Start();
            /*delegate*/
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("De tijd is om!");
                    ResetScore();
                    ResetImages();
                }
                var ssTime = TimeSpan.FromSeconds(time);
                label1.Text = "00:" + time.ToString();
            };
        }

        public void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            setRandomImages();
            time = 60;
            timer.Start();
        }
        public void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.gay;
            }
        }

        private PictureBox getFreeSlot()
        {
            int num;

            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];

        }

        public void setRandomImages()
        {
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }
        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            
            HideImages();

            allowClick = true;
            Sounds.Incorrect();
            clickTimer.Stop();
        }

        public void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;
            if (x1.Text == "x")

            {
                omgedraaid1++;
            }
            else if (x2.Text == "x")
            {
                omgedraaid2++;
            }
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }

            pic.Image = (Image)pic.Tag;


            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                HideImages();

                if (x1.Text == "x")
                {
                    P1Score();
                }
                else if (x2.Text == "x")
                {
                    P2Score();
                }
                Sounds.Correct();

            }
            else if (pic.Image == firstGuess.Image && pic == firstGuess)
            {
                pic.Visible = firstGuess.Visible = true;
                {
                    firstGuess = pic;
                }
                HideImages();
            }

            else
            {
                
                allowClick = false;
                clickTimer.Start();
                Turn();
                
            }



            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            timer.Stop();
            countP1 = countP1 * (60 - (60 - time)*(1/omgedraaid1));
            countP2 = countP2 * (60 - (60 - time)*(1/omgedraaid2));
            if (countP1 > countP2)
            {
                MessageBox.Show(NameP1.Text + " Heeft gewonnen met " + countP1 + " Punten!" + NameP2.Text + " had " + countP2 + "Punten");
            }

            else if (countP2 > countP1)
            {
                MessageBox.Show(NameP2.Text + " Heeft gewonnen met " + countP2 + " Punten! " + NameP1.Text + " had " + countP1 + "Punten");
            }
            else if (countP1 == countP2)
            {
                MessageBox.Show("Gelijkspel!");
            }

            
            ResetScore();
            ResetImages();




        }
        private void startGame(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            button1.Enabled = false;
        }

        public void P1Score()
        {
            countP1++;
            score1.Text = countP1.ToString();
        }


        public void P2Score()
        {
            countP2++;
            score2.Text = countP2.ToString();

        }


        public void Turn()
        {
            if (x1.Text == "x")
            {
                x1.Text = "...";
                x2.Text = "x";
            }
            else if (x2.Text == "x")
            {
                x1.Text = "x";
                x2.Text = "...";
            }
            



        }

        public void ResetScore()
        {
            x1.Text = "x";
            x2.Text = "...";
            score1.Text = "0";
            score2.Text = "0";
            countP1 = 0;
            countP2 = 0;
            omgedraaid1 = 0;
            omgedraaid2 = 0;

        }




        private void button2_Click(object sender, EventArgs e)
        {
            Player_import killme = new Player_import();
            killme.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Options opties = new Options();
            opties.ShowDialog();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.NewLineOnAttributes = true;
            settings.Indent = true;
            using (XmlWriter write = XmlWriter.Create("Game.sav", settings))
            {
                write.WriteStartDocument();
                write.WriteStartElement("pictureboxes");
                foreach(var pic in pictureBoxes)
                {
                    write.WriteStartElement("pic");
                    write.WriteElementString(Form2.pic.Tag);
                }
            }


        }
    } 
}
