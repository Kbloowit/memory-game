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
        #region time
        /// <summary>
        /// geeft de overgebleven tijd aan
        /// </summary>
        public static int time = 60;

        #endregion

        #region timer
        /// <summary>
        /// Timer van de game
        /// </summary>
        Timer timer = new Timer { Interval = 1000 };
        #endregion


        #region Count P1
        /// <summary>
        /// Score Speler 1
        /// </summary>
       public static int countP1 = 0;
        #endregion
        #region Count P2
        /// <summary>
        /// Score Speler 2
        /// </summary>
       public static int countP2 = 0;
        #endregion
        #region Omgedraaid
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
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        public static int[] pictures = new int[16]; // Hier worden alle random cijfers in opgeslagen, zodat deze worden onthouden voor de save-game.
        
        /*maakt een array met images, IEnumerable zorgt ervoor dat de Image class gebruikt kan worden voor een Foreach loop(ggrks)*/
        private static IEnumerable<Bitmap> images
        {
            get
            {
                return new Bitmap[]
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
            /*delegate zet 2 methodes in elkaar*/
            timer.Tick += delegate
            {
                time--; //tijd loopt af
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("De tijd is om!");
                    ResetScore();
                    ResetImages();
                }
                var ssTime = TimeSpan.FromSeconds(time); //zet de tijd afloop naar secondes ipv erg snel
                TimeLeft.Text = "00:" + time.ToString(); // updatet de time label op het form
            };
        }

        public void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null; //zet de tag van de picturebox op leeg
                pic.Visible = true; //maakt de pictureboxes zichtbaar
            }
            HideImages();
            setRandomImages();
            time = 60; //zet de int time naar 60
            timer.Start(); //start de timer
        }
        public void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.gay; //verstopt de foto's door de picturebox een andere afbeelding te geven (echte zit nog in de tag)
            }
        }

        private PictureBox getFreeSlot(int plaatjenummer)
        {
            int num; // maakt een getal aan voor de random functie

            do
            {
                num = rnd.Next(0, pictureBoxes.Count()); //random getal tussen 0(niet genomen) en het aantal pictureboxes (hier 16, en wel megenomen)
            }
            while (pictures[num] != 0); //het bovenste doet hij totdat pictures[num](array om de getallen van de plaatjes in op te slaan) niet meer 0 is.
            Console.WriteLine("num= " + num + "     ID:" + plaatjenummer); // was om te kijken welk plaatje wat kreeg
            pictures[num] = plaatjenummer; // slaat het id van het plaatje op
            return pictureBoxes[num]; // geeft de waarde van hte plaatje in de picturebox weer terug aan de picturebox

        }

        public void setRandomImages()
        {
            int plaatje = 1;
            foreach (var image in images)
            {
                getFreeSlot(plaatje).Tag = image;// zoekt 2 lege PB op en zet een image erin
                getFreeSlot(plaatje).Tag = image;

                plaatje++;
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            
            HideImages();
            if (Options.Soundeffectsstate == false) // deze wordt veranderd in het opties menu, als deze optie niet is aangevinkt speelt hij het geluidje af
            {
                Sounds.Incorrect(); // puh-uh
            }
            
            allowClick = true;
            
            clickTimer.Stop();
        }

        public void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return; //als allowclick false is, doet hij niks als je op n kaart klikt
            if (x1.Text == "x") // voor de omgedraaid aantal kaarten int

            {
                omgedraaid1++;
            }
            else if (x2.Text == "x")
            {
                omgedraaid2++;
            }
            var pic = (PictureBox)sender;

            if (firstGuess == null) // als dit het eerste plaatje is
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }

            pic.Image = (Image)pic.Tag; //tweede plaatje


            if (pic.Image == firstGuess.Image && pic != firstGuess) //als plaatje 1 gelijk is aan plaatje 2 en niet hetzelfde plaatjes is (eg zelfde pic box)
            {
                pic.Visible = firstGuess.Visible = false; // de afbeeldingen worden onzicht baar en onklikbaar
                {
                    firstGuess = pic; //firstguess is hier hetzelfde als wat pic is, dus ook dezelfde staat
                }
                HideImages(); // hide images om het weer terug te zetten

                if (x1.Text == "x") //score p1 omhoog als p1 degene is die het kiest
                {
                    P1Score();
                }
                else if (x2.Text == "x")
                {
                    P2Score();
                }
                if (Options.Soundeffectsstate == false) //speelt correct geluidseffect
                {
                    Sounds.Correct(); // tu-du-du-ding!
                }

            }
            else if (pic.Image == firstGuess.Image && pic == firstGuess) // als first guess en pic wel hetzelfde zijn (er is 2 keer op dezelfde pic box geklikt)
            {
                pic.Visible = firstGuess.Visible = true; //zet hem weer op zichtbaar
                {
                    firstGuess = pic; //firstguess wordt weer pic
                }
                HideImages(); //verstopt
            }

            else //als de plaatjes niet gelijk zijn
            {
                
                allowClick = false; //allowclick gaat uit (je kan dus niet op andere plaatjes klikken
                clickTimer.Start(); //start clicktimer (1sec)
                ToTurn();// wisselt van beurt van speler 1 naar speler 2 of andersom
                
            }



            firstGuess = null; //firstguess is weer niks
            if (pictureBoxes.Any(p => p.Visible)) return; //als er geen pictureboxes meer visible zijn (dus alles is geraden)
            timer.Stop(); //stopt gametimer
            countP1 = countP1 * ((100 - (60 - time) * -100)); //(slechte) score formule
            countP2 = countP2 * ((100 - (60 - time) * -100));
            SaveXML.Compare(); //maakt een opslag bestand voor vergelijken van highscores(weet niet zeker of dit goed is)
            if (countP1 > countP2) //speler 1 heeft de meeste punten
            {
                MessageBox.Show(NameP1.Text + " Heeft gewonnen met " + countP1 + " Punten!" + NameP2.Text + " had " + countP2 + "Punten");
            }

            else if (countP2 > countP1) //speler 2 heeft de meeste punten
            {
                MessageBox.Show(NameP2.Text + " Heeft gewonnen met " + countP2 + " Punten! " + NameP1.Text + " had " + countP1 + "Punten");
            }
            else if (countP1 == countP2)// puntenaantal is gelijk
            {
                MessageBox.Show("Gelijkspel!");
            }

            
            ResetScore(); //scores worden weer 0
            ResetImages(); //pic boxes worden visible etc




        }
        private void startGame(object sender, EventArgs e)//als op de startknop gedrukt wordt
        {
            allowClick = true; //je kan op plaatjes klikken
            setRandomImages(); //random image verdelen
            HideImages(); // achtergrond plaatje in pictureboxes zetten
            startGameTimer(); //gametimer gaat lopen
            clickTimer.Interval = 1000; //interval clicktimer (1000ms = 1s)
            clickTimer.Tick += CLICKTIMER_TICK; // de clicktimer loopt gelijk aan de gametimer
            buttonStart.Enabled = false; //je kan niet meer op de startknop drukken
        }

        public void P1Score() //score p1 wordt geupdate
        {
            countP1++;
            score1.Text = countP1.ToString(); //update label met score p1
        }


        public void P2Score()// score p2 wordt geupdate
        {
            countP2++;
            score2.Text = countP2.ToString(); //update label met score p2

        }


        public void ToTurn() // wisselt beurt
        {
            if (x1.Text == "x") //als p1 aan de beurt was
            {
                x1.Text = "...";
                x2.Text = "x";
                Turn = 2;
            }
            else if (x2.Text == "x") //als p2 aan de beurt was
            {
                x1.Text = "x";
                x2.Text = "...";
                Turn = 1;
            }
            



        }

        public void ResetScore() //zet de score weer op 0 en updatet de labels
        {
            x1.Text = "x"; //p1 is standaard eerst aan de beurt, dus we resetten de labels weer
            x2.Text = "...";
            score1.Text = "0";
            score2.Text = "0";
            countP1 = 0;
            countP2 = 0;
            omgedraaid1 = 0;
            omgedraaid2 = 0;

        }




        private void buttonReset_Click(object sender, EventArgs e) //als op de reset knop wordt gedrukt
        {
            timer.Stop(); // stopt gametimer
            DialogResult dialog = MessageBox.Show("Wilt u het spel opslaan voordat het gereset wordt?", "Reset", MessageBoxButtons.YesNoCancel); // messagebox met knoppen erin , "reset:" is de titel
            if (dialog == DialogResult.Yes) //als Yes wordt gekozen
            {
                SaveXML.button_click(); //slaat op
                Player_import killme = new Player_import();
                killme.Show();
                this.Dispose(); //gooit form instance uit het geheugen

            }
            else if (dialog == DialogResult.No) // als No wordt gekozen
            {
                Player_import killme = new Player_import();
                killme.Show();
                this.Dispose();
            }
            else if (dialog == DialogResult.Cancel)
            {
                timer.Start(); //start de timer weer op vanaf waar hij gebleven was
                return;
                
            }
        }

        private void buttonOptions_Click(object sender, EventArgs e) //als op de opties knop wordt gedrukt
        {
            Options opties = new Options(); //opent nieuw opties form
            opties.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e) // op laden form 2
        {
            Sounds.Stopmuziek(); //stops alle lopende achtergrond muziek
            Sounds.Groonty();
            if (Options.CheckboxBGMstate == false) //als in het opties menu muziek is uitgezet

            {
                Sounds.Grunty(); //achtergrond muziek

            }
                                                   
        }

        private void buttonQuitSave_Click(object sender, EventArgs e) //als de save knop wordt ingedrukt
        {
            timer.Stop();
            DialogResult dialog = MessageBox.Show("Wilt u het spel opslaan voordat het wordt afgesloten?", "Afsluiten", MessageBoxButtons.YesNoCancel);
            if (dialog == DialogResult.Yes) //als Yes wordt gekozen
            {
                SaveXML.button_click();
                // Application.Exit();
            }
            else if (dialog == DialogResult.No) //als No wordt gekozen
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.Cancel) //als cancel wordt gekozen
            {
                timer.Start();
                return;
            }
        }
        
    } 
}
