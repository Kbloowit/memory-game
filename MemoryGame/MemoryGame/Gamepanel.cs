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
    public partial class Gamepanel : Form

    {

        public static List<string> Players = new List<string>();
        public static List<int> Plaatjenummer = new List<int>();
        public static Dictionary<int, Image> frontImage = new Dictionary<int, Image>();
        public static int[] ID = new int[16];

        public static int Turn = 1;
       
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
        public static int time = 60;
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
       public static int countP1 = 0;
        #endregion
        #region
        /// <summary>
        /// Score Speler 2
        /// </summary>
       public static int countP2 = 0;
        #endregion
        #region
        /// <summary>
        /// geeft aan hoe vaak speler x een kaart heeft omgedraaid
        /// </summary>
        int omgedraaid1 = 0;
        int omgedraaid2 = 0;
        #endregion 

        /* neemt de namen mee van het Player_Import Form*/
        public Gamepanel(String[] players)
        {
            InitializeComponent();

            NameP1.Text = players[0];
            NameP2.Text = players[1];
            Players.Add(players[0]);
            Players.Add(players[1]);
        }
        /* maakt een picturebox array*/
        public PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        public static int[] pictures = new int[16]; // Hier worden alle random cijfers in opgeslagen, zodat deze worden onthouden voor de save-game.

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
                TimeLeft.Text = "00:" + time.ToString();
            };
        }

        public void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            frontImage.Clear();
            //setRandomImages();
            time = 60;
            timer.Start();
        }
        
        private void getFreeSlot(int Plaatjenummer)
        {
            int num;

            do
                num = rnd.Next(0, pictureBoxes.Count());
            while (pictureBoxes[num].Tag != null);

            //Console.WriteLine("num = " + num + "    :" + pictureBoxes.Count() + "    ID" + Plaatjenummer);
            //pictures[num] = Plaatjenummer;
            pictureBoxes[num].Image = Properties.Resources.BackFont;
            pictureBoxes[num].Tag = Plaatjenummer;
            ID[num] = Plaatjenummer;

        }
        


        public void setRandomImages()
        {
             
            int plaatje = 0;
            foreach (var image in images)
            {
                getFreeSlot(plaatje);                
                getFreeSlot(plaatje);

                frontImage.Add(plaatje, image);
                // Plaatjenummer.Add(nummer);
                plaatje++;
           
    }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {

            //HideImages();
            if (firstGuess != null)
                firstGuess.Image = Properties.Resources.BackFont;

            Sounds.Incorrect();
            allowClick = true;
            
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
            int ID = Convert.ToInt32(pic.Tag);

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = frontImage[ID];
                //MessageBox.Show(ID.ToString());
                //pic.Image = (Image)pic.Tag;
                return;
            }


            pic.Image = frontImage[ID];


            #region
            /// <summary>
            /// hier wordt even een pauze gedaan voordat de kaarten weer worden omgedraaid
            /// </summary>
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddMilliseconds(500) > DateTime.Now);
            #endregion
            //MessageBox.Show(pic.Tag.ToString());

            if (pic == firstGuess)
                return;

            if (ID == Convert.ToInt32(firstGuess.Tag))
            {
                pic.Visible = firstGuess.Visible = false;

                

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
            else
            {
                pic.Visible = firstGuess.Visible = true;
                pic.Image = firstGuess.Image = Properties.Resources.BackFont;
                firstGuess = null;
                ToTurn();
            }
            
            

            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            timer.Stop();
            countP1 = countP1 * ((100 - (60 - time) * -100));
            countP2 = countP2 * ((100 - (60 - time) * -100));
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
            //HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            buttonStart.Hide();
            buttonPauze.Show();
        }

        private void buttonPauze_Click(object sender, EventArgs e)
        {
            allowClick = false;
            timer.Stop();
            buttonPauze.Hide();
            buttonResume.Show();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            allowClick = true;
            timer.Start();
            buttonPauze.Show();

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


        public void ToTurn()
        {
            if (x1.Text == "x")
            {
                x1.Text = "...";
                x2.Text = "x";
                Turn = 2;
            }
            else if (x2.Text == "x")
            {
                x1.Text = "x";
                x2.Text = "...";
                Turn = 1;
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult dialog = MessageBox.Show("Wilt u het spel opslaan voordat het gereset wordt?", "Reset", MessageBoxButtons.YesNoCancel);
            if (dialog == DialogResult.Yes)
            {
                SaveXML.button_click();
                Player_import killme = new Player_import();
                killme.Show();
                this.Dispose();

            }
            else if (dialog == DialogResult.No)
            {
                Player_import killme = new Player_import();
                killme.Show();
                this.Dispose();
            }
            else if (dialog == DialogResult.Cancel)
            {
                timer.Start();
                return;
                
            }
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            Options opties = new Options();
            opties.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Sounds.Stopmuziek();
            Sounds.Grunty();
        }

        private void buttonQuitSave_Click(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult dialog = MessageBox.Show("Wilt u het spel opslaan voordat het wordt afgesloten?", "Afsluiten", MessageBoxButtons.YesNoCancel);
            if (dialog == DialogResult.Yes)
            {
                SaveXML.button_click();
               // Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.Cancel)
            {
                timer.Start();
                return;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveXML.button_click();
        }

    } 
}
