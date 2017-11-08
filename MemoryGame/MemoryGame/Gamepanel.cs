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
        public static List<int> plaatjenummer = new List<int>();
        public static Dictionary<int, Image> frontImage = new Dictionary<int, Image>();
        


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
            BackColor = Themez.Achtergrond;// ophalen van de in thema bepaalde achtergrondskleur
           
        }
        /* maakt een picturebox array*/
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        public static int[] pictures = new int[16]; // Hier worden alle random cijfers in opgeslagen, zodat deze worden onthouden voor de save-game.
        public static bool[] visible = new bool[16];
        /*maakt een array met images, IEnumerable zorgt ervoor dat de Image class gebruikt kan worden voor een Foreach loop(ggrks)*/
        public static IEnumerable<Image> images
        {
            get
            {
                // Cars
                if (Themez.Themepicked == 1)
                {
                    return new Image[]
                        {
                    /*  onze image files voor Cars*/
                    Properties.Resources.cars1,
                    Properties.Resources.cars2,
                    Properties.Resources.cars3,
                    Properties.Resources.cars4,
                    Properties.Resources.cars5,
                    Properties.Resources.cars6,
                    Properties.Resources.cars7,
                    Properties.Resources.cars8
                        };
                }
                // Avengers 
                if (Themez.Themepicked == 2)
                {
                    return new Image[]
                        {
                    /*  onze image files voor Avengers*/
                    Properties.Resources.america,
                    Properties.Resources.fury,
                    Properties.Resources.hawkeyes,
                    Properties.Resources.hulk,
                    Properties.Resources.meme,
                    Properties.Resources.stark,
                    Properties.Resources.thor,
                    Properties.Resources.widow
                        };
                }
                // Royality
                if (Themez.Themepicked == 3)
                {
                    return new Image[]
                        {
                    /*  onze image files voor de Royals*/
                    Properties.Resources.koningshuis1,
                    Properties.Resources.koningshuis2,
                    Properties.Resources.koningshuis3,
                    Properties.Resources.koningshuis4,
                    Properties.Resources.koningshuis5,
                    Properties.Resources.koningshuis6,
                    Properties.Resources.koningshuis7,
                    Properties.Resources.koningshuis8
                        };
                }
                // Winx
                if (Themez.Themepicked == 4)
                {
                    return new Image[]
                        {
                    /*  onze image files voor de Winx*/
                    Properties.Resources.Winx1,
                    Properties.Resources.Winx2,
                    Properties.Resources.Winx3,
                    Properties.Resources.Winx4,
                    Properties.Resources.Winx5,
                    Properties.Resources.Winx6,
                    Properties.Resources.Winx7,
                    Properties.Resources.Winx8
                        };
                }
                // GTA 5
                if (Themez.Themepicked == 5)
                {
                    return new Image[]
                        {
                    /*  onze image files voor het GTA 5 thema*/
                    Properties.Resources.gtav1,
                    Properties.Resources.gtav2,
                    Properties.Resources.gtav3,
                    Properties.Resources.gtav4,
                    Properties.Resources.gtav5,
                    Properties.Resources.gtav6,
                    Properties.Resources.gtav7,
                    Properties.Resources.gtav8
                        };
                }
                // Formule1
                if (Themez.Themepicked == 6)
                {
                    return new Image[]
                        {
                    /*  onze image files voor het Formule 1 thema*/
                    Properties.Resources.Formule1,
                    Properties.Resources.Formule2,
                    Properties.Resources.formule3,
                    Properties.Resources.formule4,
                    Properties.Resources.formule5,
                    Properties.Resources.formule6,
                    Properties.Resources.formule7,
                    Properties.Resources.formule8
                        };
                }
                // Social
                if (Themez.Themepicked == 7)
                {
                    return new Image[]
                        {
                    /*  onze image files voor het Social Media thema*/
                    Properties.Resources.social1,
                    Properties.Resources.social2,
                    Properties.Resources.social3,
                    Properties.Resources.social4,
                    Properties.Resources.social5,
                    Properties.Resources.social6,
                    Properties.Resources.social7,
                    Properties.Resources.social8
                        };
                }
                // Disney
                if (Themez.Themepicked == 8)
                {
                    return new Image[]
                        {
                    /*  onze image files voor het Disney Prinsessen thema*/
                    Properties.Resources.Disney1,
                    Properties.Resources.Disney2,
                    Properties.Resources.Disney3,
                    Properties.Resources.Disney4,
                    Properties.Resources.Disney5,
                    Properties.Resources.Disney6,
                    Properties.Resources.Disney7,
                    Properties.Resources.Disney8
                        };
                }
                // Regrats
                if (Themez.Themepicked == 9)
                {
                    return new Image[]
                        {
                    /*  onze image files voor het Rugrats thema*/
                    Properties.Resources.Rugrats1,
                    Properties.Resources.Rugrats2,
                    Properties.Resources.Rugrats3,
                    Properties.Resources.Rugrats4,
                    Properties.Resources.Rugrats5,
                    Properties.Resources.Rugrats6,
                    Properties.Resources.Rugrats7,
                    Properties.Resources.Rugrats8
                        };
                }
                // Storage
                if (Themez.Themepicked == 10)
                {
                    return new Image[]
                        {
                    /*  onze image files voor het Rugrats thema*/
                    Properties.Resources.StorageCD,
                    Properties.Resources.StorageCloud,
                    Properties.Resources.StorageDVD,
                    Properties.Resources.StorageFloppy,
                    Properties.Resources.StorageHDD,
                    Properties.Resources.StorageRAM,
                    Properties.Resources.StorageSD,
                    Properties.Resources.StorageUSB
                        };
                }

                else
                {
                    return new Image[]
                    {
                        Properties.Resources.BackImage
                    };


                }
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
            
            frontImage.Clear(); //gooit de frontImage dictionary leeg, anders werkt de reset knop niet goed
            setRandomImages();
            time = 60; //zet de int time naar 60
            timer.Start(); //start de timer
            
        }
        
        private void getFreeSlot(int plaatjenummer)
        {
            
            int num; // maakt een getal aan voor de random functie
            
            do
            {
                num = rnd.Next(0, pictureBoxes.Count()); //random getal tussen 0(niet genomen) en het aantal pictureboxes (hier 16, en wel megenomen)
            }
            while (pictureBoxes[num].Tag != null); //het bovenste doet hij totdat pictures[num](array om de getallen van de plaatjes in op te slaan) niet meer 0 is.
            pictureBoxes[num].Image = Properties.Resources.BackImage; // Verstopt het plaatje
            pictureBoxes[num].Tag = plaatjenummer;
            pictures[num] = plaatjenummer;
            
        }

        public void setRandomImages()
        {
           
            int plaatje = 0;
            foreach (var image in images)
            {
                getFreeSlot(plaatje);// zoekt 2 lege PB op en zet een image erin
                getFreeSlot(plaatje);
                frontImage.Add(plaatje, image);
                plaatje++;
            }
                      
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {

            
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
            int ID = Convert.ToInt32(pic.Tag);

            if (firstGuess == null) // als dit het eerste plaatje is
            {
                firstGuess = pic;
                pic.Image = frontImage[ID];
                return;
            }

            pic.Image = frontImage[ID]; //tweede plaatje

            #region
            /// <summary>
            /// hier wordt even een pauze gedaan voordat de kaarten weer worden omgedraaid
            /// </summary>
            DateTime pauze = DateTime.Now; //tijd van omdraaien kaart
            do
            {
                Application.DoEvents();

            } while (pauze.AddMilliseconds(500) > DateTime.Now);
            #endregion


            if (pic == firstGuess)// als first guess en pic hetzelfde zijn (er is 2 keer op dezelfde pic box geklikt)
            {
                return;// het programma doet niks
            }
            if (ID == Convert.ToInt32(firstGuess.Tag)) //als plaatje 1 gelijk is aan plaatje 2 en niet hetzelfde plaatjes is (eg zelfde pic box)
            {
                pic.Visible = firstGuess.Visible = false; // de afbeeldingen worden onzicht baar en onklikbaar
                int vischeck = 0;
                foreach (var i in pictureBoxes)
                {
                    if (i.Visible == false)
                    {
                        visible[vischeck] = false;
                        vischeck++;
                    }
                    else
                    {
                        vischeck++;
                    }
                        
            

                    

                }
                

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
            else  // als first guess en pic niet hetzelfde zijn (er is 2 keer op dezelfde pic box geklikt)
            {
                pic.Visible = firstGuess.Visible = true; //zet hem weer op zichtbaar
                pic.Image = firstGuess.Image = Properties.Resources.BackImage;
                firstGuess = null;
                if (Options.Soundeffectsstate == false) //speelt correct geluidseffect
                {
                    Sounds.Incorrect(); // tu-du.
                }
                ToTurn();



            }

            



            firstGuess = null; //firstguess is weer niks
            if (pictureBoxes.Any(p => p.Visible)) return; //als er geen pictureboxes meer visible zijn (dus alles is geraden)
            timer.Stop(); //stopt gametimer
            countP1 = countP1 * ((100 - (60 - time) * -100)); //(slechte) score formule
            countP2 = countP2 * ((100 - (60 - time) * -100));

            if (countP1 > countP2) //speler 1 heeft de meeste punten
            {
                MessageBox.Show(NameP1.Text + " heeft gewonnen met " + countP1 + " punten!" + NameP2.Text + " had " + countP2 + " punten");

            }

            else if (countP2 > countP1) //speler 2 heeft de meeste punten
            {
                MessageBox.Show(NameP2.Text + " heeft gewonnen met " + countP2 + " punten! " + NameP1.Text + " had " + countP1 + " punten");

            }
            else if (countP1 == countP2)// puntenaantal is gelijk
            {
                MessageBox.Show("Gelijkspel!");

            }

            Highscores meme = new Highscores();
            meme.ShowDialog();

            ResetScore(); //scores worden weer 0
            ResetImages(); //pic boxes worden visible etc




        }
        private void startGame(object sender, EventArgs e)//als op de startknop gedrukt wordt
        {
            allowClick = true; //je kan op plaatjes klikken
            setRandomImages(); //random image verdelen
            startGameTimer(); //gametimer gaat lopen
            clickTimer.Interval = 1000; //interval clicktimer (1000ms = 1s)
            clickTimer.Tick += CLICKTIMER_TICK; // de clicktimer loopt gelijk aan de gametimer
            buttonStart.Enabled = false; //je kan niet meer op de startknop drukken
            Setnumberwang(); // zet alle nummers in de visible array op true
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
            if (Turn == 1) //als p1 aan de beurt was
            {
                x1.Text = "...";
                x2.Text = "x";
                Turn = 2;
            }
            else if (Turn == 2) //als p2 aan de beurt was
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
                Thema theme = new Thema();
                time = 60;
                frontImage.Clear();
                ResetScore();
                theme.Show();
                Sounds.Stopmuziek();
               
                Sounds.Startmuziek();
                this.Dispose(); //gooit form instance uit het geheugen

            }
            else if (dialog == DialogResult.No) // als No wordt gekozen
            {
                Thema theme = new Thema();
                frontImage.Clear();
                time = 60;
                ResetScore();
                theme.Show();
                Sounds.Stopmuziek();
                Sounds.Startmuziek();
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
            timer.Stop();
            opties.ShowDialog();
            timer.Start();

        }

        private void Form2_Load(object sender, EventArgs e) // op laden form 2
        {
            Sounds.Stopmuziek(); //stops alle lopende achtergrond muziek
            // Overzicht achtergrond muziek
            switch (Themez.Themepicked)
            {
                case 1:
                    Sounds.Cars();
                    break;
                case 2:
                    Sounds.Avengers();
                    break;
                case 3:
                    Sounds.Royalty();
                    break;
                case 4:
                    Sounds.Winx();
                    break;
                case 5:
                    Sounds.Gta5();
                    break;
                case 6:
                    Sounds.Formule1();
                    break;
                case 7:
                    Sounds.Social();
                    break;
                case 8:
                    Sounds.Disney();
                    break;
                case 9: //rugrats heeft nog geen muziek dus nu deze placeholder
                    Sounds.Siivagunner();
                    break;
                case 10:
                    Sounds.Storage();
                    break;
            }


            if (Options.CheckboxBGMstate == false) //als in het opties menu muziek is uitgezet

            {
                Sounds.Grunty(); //achtergrond muziek

            }

            if (Hoofdmenu.Savegameused == true)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("Memory.sav");

                score1.Text = Convert.ToString(xDoc.SelectSingleNode("Game/Score/ScoreP1").InnerText);
                countP1 = Convert.ToInt32(xDoc.SelectSingleNode("Game/Score/ScoreP1").InnerText);

                score2.Text = Convert.ToString(xDoc.SelectSingleNode("Game/Score/ScoreP2").InnerText);
                countP2 = Convert.ToInt32(xDoc.SelectSingleNode("Game/Score/ScoreP2").InnerText);

                time = Convert.ToInt32(xDoc.SelectSingleNode("Game/Timer").InnerText);
                TimeLeft.Text = "00:" + Convert.ToString(xDoc.SelectSingleNode("Game/Timer").InnerText);

                Turn = Convert.ToInt32(xDoc.SelectSingleNode("Game/Turn").InnerText);
                ToTurn();

                Themez.Themepicked = Convert.ToInt32(xDoc.SelectSingleNode("Game/Thema").InnerText);

                switch (Themez.Themepicked)
                {
                    case 1:
                        {
                            BackColor = Color.Crimson;
                            break;
                        }
                    case 2:
                        {

                            BackColor = Color.Blue;
                            break;
                        }
                    case 3:
                        {
                            BackColor = Color.RoyalBlue;
                            break;
                        }
                    case 4:
                        {
                            BackColor = Color.BlueViolet;
                            break;
                        }
                    case 5:
                        {
                            BackColor = Color.YellowGreen;
                            break;
                        }
                    case 6:
                        {
                            BackColor = Color.DarkOrange;
                            break;
                        }
                    case 7:
                        {
                            BackColor = Color.PaleTurquoise;
                            break;
                        }
                    case 8:
                        {
                            BackColor = Color.LightPink;
                            break;
                        }
                    case 9:
                        {
                            BackColor = Color.Beige;
                            break;
                        }
                    case 10:
                        {
                            BackColor = Color.White;
                            break;
                        }

                }
                int plaatje = 0;
                foreach (var image in images)
                {

                    frontImage.Add(plaatje, image);
                    plaatje++;
                }

                int[] picboxid = new int[16];
                picboxid[0] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox1").InnerText);
                picboxid[1] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox2").InnerText);
                picboxid[2] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox3").InnerText);
                picboxid[3] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox4").InnerText);
                picboxid[4] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox5").InnerText);
                picboxid[5] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox6").InnerText);
                picboxid[6] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox7").InnerText);
                picboxid[7] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox8").InnerText);
                picboxid[8] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox9").InnerText);
                picboxid[9] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox10").InnerText);
                picboxid[10] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox11").InnerText);
                picboxid[11] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox12").InnerText);
                picboxid[12] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox13").InnerText);
                picboxid[13] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox14").InnerText);
                picboxid[14] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox15").InnerText);
                picboxid[15] = Convert.ToInt32(xDoc.SelectSingleNode("Game/PictureBoxes/Picturebox16").InnerText);
                

                int ugh = 0;
                foreach (var num in pictureBoxes)
                {
                    num.Tag = picboxid[ugh];
                    num.Visible = true;
                    pictureBoxes[ugh].Image = Properties.Resources.BackImage; // Verstopt het plaatje
                    pictures[ugh] = picboxid[ugh];
                    ugh++;
                }
                visible[0] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox1").InnerText);
                visible[1] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox2").InnerText);
                visible[2] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox3").InnerText);
                visible[3] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox4").InnerText);
                visible[4] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox5").InnerText);
                visible[5] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox6").InnerText);
                visible[6] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox7").InnerText);
                visible[7] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox8").InnerText);
                visible[8] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox9").InnerText);
                visible[9] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox10").InnerText);
                visible[10] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox11").InnerText);
                visible[11] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox12").InnerText);
                visible[12] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox13").InnerText);
                visible[13] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox14").InnerText);
                visible[14] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox15").InnerText);
                visible[15] = Convert.ToBoolean(xDoc.SelectSingleNode("Game/Visible/Picbox16").InnerText);
                int uuu = 0;
                foreach (var pic in pictureBoxes)
                {
                    pic.Visible = visible[uuu];
                    uuu++;
                   
                }
                

                allowClick = true;
                startGameTimer();
                clickTimer.Interval = 1000; //interval clicktimer (1000ms = 1s)
                clickTimer.Tick += CLICKTIMER_TICK; // de clicktimer loopt gelijk aan de gametimer
                buttonStart.Enabled = false; //je kan niet meer op de startknop drukken

                


            }



        }

        private void buttonQuitSave_Click(object sender, EventArgs e) //als de save knop wordt ingedrukt
        {
            timer.Stop();
            DialogResult dialog = MessageBox.Show("Wilt u het spel opslaan voordat het wordt afgesloten?", "Afsluiten", MessageBoxButtons.YesNoCancel);
            if (dialog == DialogResult.Yes) //als Yes wordt gekozen
            {
                SaveXML.button_click();
                Application.Exit();
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

        private void Gamepanel_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Gamepanel_FormClosed(object sender, FormClosedEventArgs e)
        {
             Application.Exit();
        }

        private void Setnumberwang()
        {
            int foreachinvisible = 0;
            foreach (bool item in visible)
            {
                visible[foreachinvisible] = true;
                foreachinvisible++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Highscores meme = new Highscores();
            meme.ShowDialog();
            this.Hide();
        }
    } 
}
