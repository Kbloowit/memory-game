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
<<<<<<< HEAD
    public partial class Gamepanel : Form

    {
        public static List<string> Players = new List<string>();

        public static int Turn = 1;
        public static List<int> Time = new List<int>();
        public static List<string> Cards = new List<string>();
=======
    public partial class GamePanel : Form

    {
        public static List<string> Players = new List<string>(); // hierin zijn de namen opgeslagen op ze aanroepbaar te maken voor de save class

        public static int Turn = 1;
        //public static List<int> Time = new List<int>();
       //public static List<string> Cards = new List<string>();

>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
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
<<<<<<< HEAD
       public static int countP1 = 0;
=======
        public static int countP1 = 0;
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        #endregion
        #region
        /// <summary>
        /// Score Speler 2
        /// </summary>
<<<<<<< HEAD
       public static int countP2 = 0;
=======
        public static int countP2 = 0;
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        #endregion
        #region
        /// <summary>
        /// geeft aan hoe vaak speler x een kaart heeft omgedraaid
        /// </summary>
        int omgedraaid1 = 0;
        int omgedraaid2 = 0;
        #endregion 

        /* neemt de namen mee van het Player_Import Form*/
<<<<<<< HEAD
        public Gamepanel(String[] players)
=======
        public GamePanel(String[] players)
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        {
            InitializeComponent();

            NameP1.Text = players[0];
            NameP2.Text = players[1];
            Players.Add(players[0]);
            Players.Add(players[1]);
<<<<<<< HEAD
=======

>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        }
        /* maakt een picturebox array*/
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        public int[] pictures = new int[16]; // Hier worden alle random cijfers in opgeslagen, zodat deze worden onthouden voor de save-game.
<<<<<<< HEAD
        
=======
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
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
<<<<<<< HEAD
                label1.Text = "00:" + time.ToString();
=======
                Timertime.Text = "00:" + time.ToString();
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
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

        private PictureBox getFreeSlot(int plaatjenummer)
        {
            int num;

            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            pictures[num] = plaatjenummer;
            return pictureBoxes[num];

        }

<<<<<<< HEAD
        public void setRandomImages(int plaatje)
        {
=======
        public void setRandomImages()
        {
            int plaatje = 0;
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            foreach (var image in images)
            {
                getFreeSlot(plaatje).Tag = image;
                getFreeSlot(plaatje).Tag = image;
<<<<<<< HEAD
=======
                plaatje++;  // Tel een bij de int van plaatje op wanneer hij twee pictures in de picturebox heeft gezet. Dit weer in verband met save-game. 
                //Omdat wij in de tag een afbeelding mee sturen en geen cijfer.
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            }
        }
        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
            HideImages();
            Sounds.Incorrect();
            allowClick = true;
            
=======

            HideImages();

            allowClick = true;
            Sounds.Incorrect();
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
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
<<<<<<< HEAD
                
                allowClick = false;
                clickTimer.Start();
                Turn1();
                
=======

                allowClick = false;
                clickTimer.Start();
                ToTurn();

>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            }



            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            timer.Stop();
<<<<<<< HEAD
            countP1 = countP1 * (60 - (60 - time)*(1/omgedraaid1));
            countP2 = countP2 * (60 - (60 - time)*(1/omgedraaid2));
            if (countP1 > countP2)
            {
                MessageBox.Show(NameP1.Text + " Heeft gewonnen met " + countP1 + " Punten!" + NameP2.Text + " had " + countP2 + "Punten");
=======
            countP1 = countP1 * (60 - (60 - time) * (1 / omgedraaid1));
            countP2 = countP2 * (60 - (60 - time) * (1 / omgedraaid2));
            if (countP1 > countP2)
            {
                MessageBox.Show(NameP1.Text + " heeft gewonnen met " + countP1 + " punten! " + NameP2.Text + " had " + countP2 + " punten");
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            }

            else if (countP2 > countP1)
            {
<<<<<<< HEAD
                MessageBox.Show(NameP2.Text + " Heeft gewonnen met " + countP2 + " Punten! " + NameP1.Text + " had " + countP1 + "Punten");
=======
                MessageBox.Show(NameP2.Text + " heeft gewonnen met " + countP2 + " punten! " + NameP1.Text + " had " + countP1 + " punten");
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            }
            else if (countP1 == countP2)
            {
                MessageBox.Show("Gelijkspel!");
            }

<<<<<<< HEAD
            
=======

>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
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
<<<<<<< HEAD
            button1.Enabled = false;
=======
            buttonStart.Enabled = false;
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        }

        public void P1Score()
        {
            countP1++;
            score1.Text = countP1.ToString();
<<<<<<< HEAD
=======

>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        }


        public void P2Score()
        {
            countP2++;
            score2.Text = countP2.ToString();

<<<<<<< HEAD
        }


        public void Turn1()
=======

        }


        public void ToTurn()
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        {
            if (x1.Text == "x")
            {
                x1.Text = "...";
                x2.Text = "x";
<<<<<<< HEAD
=======
                Turn = 2; // Toegevoegd voor het opslaan wie er aan de beurt is
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            }
            else if (x2.Text == "x")
            {
                x1.Text = "x";
                x2.Text = "...";
<<<<<<< HEAD
            }
            
=======
                Turn = 1; // Toegevoegd voor het opslaan wie er aan de beurt is
            }

>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd



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




<<<<<<< HEAD
        private void button2_Click(object sender, EventArgs e)
=======
        private void buttonReset_Click(object sender, EventArgs e)
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        {
            Player_import killme = new Player_import();
            killme.Show();
            this.Dispose();
        }

<<<<<<< HEAD
        private void button3_Click(object sender, EventArgs e)
=======
        private void buttonOptions_Click(object sender, EventArgs e)
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        {
            Options opties = new Options();
            opties.ShowDialog();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
<<<<<<< HEAD
            

=======
            Application.OpenForms[0].Show();
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        }

        private void Form2_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Sounds.Stopmuziek();
            Sounds.Grunty();
        }

        


        
    } 
=======

        }


        private void buttonSaveQuit_Click(object sender, EventArgs e)
        {
            SaveXML.button_click(); // Hier word de saveXML class aangeroepen
        }
    }
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
}
