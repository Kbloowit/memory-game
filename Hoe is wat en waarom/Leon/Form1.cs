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
        bool allowClick = false; //
        PictureBox firstguess; // we maken een picturebox object aan en noemen hem firstguess
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 60; //Je hebt 60 seconde om het spel te halen
        Timer timer = new Timer { Interval = 1000 };




        List<Image> avengers = new List<Image>
        {
            Properties.Resources.thor , Properties.Resources.thor ,  Properties.Resources.widow , Properties.Resources.widow , Properties.Resources.hulk , Properties.Resources.hulk ,  Properties.Resources.meme ,
            Properties.Resources.meme , Properties.Resources.stark , Properties.Resources.stark ,  Properties.Resources.fury , Properties.Resources.fury , Properties.Resources.hawkeyes , Properties.Resources.hawkeyes ,  Properties.Resources.america , Properties.Resources.america
        };
        private object firstGuess;
        private object Messagebox;
        public object Control;

        public Form1()
        {
            InitializeComponent();
        }
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[] //array aanmaken van de image class
                {
                  Properties.Resources.widow,
                  Properties.Resources.america,
                  Properties.Resources.hawkeyes,
                  Properties.Resources.hulk,
                  Properties.Resources.stark,
                  Properties.Resources.fury,
                  Properties.Resources.meme,
                  Properties.Resources.thor,
                };
            }


        }


        private void startGametimer() //Gametimer starten
        {
            timer.Start();

            {
                time--;
                if (time < 0) //voorwaarde van wanneer de tijd op is
                {
                    timer.Stop(); //de timer laten stoppen
                    MessageBox.Show("Out of time"); //bericht weergeven dat de tijd op is
                    ResetImages(); // vervolgens resetten
                }

                var ssTime = TimeSpan.FromSeconds(time);

                label1.Text = "00: " + time.ToString(); //op 00 stoppen en tekst weergeven
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
            timer.Start(); }
            private void HideImages()
            {
            foreach (var pic in pictureBoxes)
            {
            pic.Image = Properties.Resources.question;
            }
        }
            private PictureBox getFreeSlot()
            {
            int num; do { num = rnd.Next(0, pictureBoxes.Count());
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
        }
        else
        { allowClick = false; clickTimer.Start();
        }
        firstGuess = null;
        if (pictureBoxes.Any(p => p.Visible)) return;
        MessageBox.Show("You Win Now Try Again");
        ResetImages();
        }
        private void startGame(object sender, EventArgs e)
        {
        allowClick = true;
        setRandomImages();
        HideImages();
        startGametimer();
        clickTimer.Interval = 1000;
        clickTimer.Tick += CLICKTIMER_TICK;
        button1.Enabled = false;
        }
    }
} 






            
        