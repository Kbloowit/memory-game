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
    public partial class Form2 : Form

    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };
        Hoofdmenu meme;
        int countP1 = 0;
        int countP2 = 0;

        public Form2(String P1, String P2)
        {
            InitializeComponent();

            NameP1.Text = P1;
            NameP2.Text = P2;

        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
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

        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("You are Retarded");
                    ResetScore();
                    ResetImages();
                }
                var ssTime = TimeSpan.FromSeconds(time);
                label1.Text = "00:" + time.ToString();
            };
        }

        private void ResetImages()
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
        private void HideImages()
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

        private void setRandomImages()
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
            clickTimer.Stop();
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;

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
                Soundplayers.Correct();

            }

            else
            {
                allowClick = false;
                clickTimer.Start();
                Soundplayers.Incorrect();
                Turn();
            }

            

            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("Congrats you aren't retarded");
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
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Player_import killme = new Player_import();
            killme.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Options opties = new Options(meme);
            opties.ShowDialog();
        }

       
    }
       
}
