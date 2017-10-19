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
        //variabelen
        bool allowClick = false;
        PictureBox firstGuess; //We creëren een voorbeeld van een picturebox in een variabele en noemen het first guess
        Random rnd = new Random(); //dit creëert een voorbeeld van de willekeurige nummer generator die we nodig hebben voor de memory plaatjes
        Timer clickTimer = new Timer(); //timer variabele
        int time = 60; //tijd variabele
        Timer timer = new Timer { Interval = 1000 };//tijd variabele
        Hoofdmenu meme;

        public Form2(String P1, String P2)
        {
            InitializeComponent();

            NameP1.Text = P1;
            NameP2.Text = P2;

        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); } //Dit is de PictureBox-functie, we gaan alle pictureboxes toevoegen aan een array.
        }

        private static IEnumerable<Image> images  //Dit functionele doel is om de images die we eerder importeerde naar de bronnen te koppelen. Merk op dat we een statische IEnumerable <image> gebruiken in de titel van deze functie. Wat dit betekent, zullen we een scala van Image klasse creëren en we moeten toegang hebben tot die bestanden. Door het gebruik van IEnumerable maakt het ons makkelijker een toegang te creëren om die bestanden te vragen.
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

        private void startGameTimer() //Dit functionele doel is om de timer te starten en de resterende tijd weer te geven op het label dat we eerder hebben toegevoegd
        {
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("You are Retarded");
                    ResetImages();
                }
                var ssTime = TimeSpan.FromSeconds(time);
                label1.Text = "00:" + time.ToString();
            };
        }

        private void ResetImages() //Met deze functie worden de pictureboxes opnieuw ingesteld. Deze functie wordt gebruikt wanneer we de gebruiker toestaan ​​het spel na hun eerste ronde opnieuw te spelen
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
        private void HideImages() //Deze functie loopt een foreach loop door het formulier op zoek naar pictureboxes en het zal ze maskeren met de cover van de memoryplaatjes die we al eerder hadden geimporteerd 
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.gay;
            }
        }

        private PictureBox getFreeSlot() //deze functie heeft een data return die door alle pictureboxes loopt zodat we een aantal willekeurige pictureboxes kunnen selecteren door het controleren van tags
        {
            int num;

            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];

        }

        private void setRandomImages() //In deze functie hierboven draaien we nog een lus, deze keer in plaats van een DO WHILE-lus te doen, doen we een voor elke lus. Deze lus kijkt naar afbeeldingen en probeert een paar slots te vinden waar beide met dezelfde naam kunnen worden getagd , waardoor we paren bij elkaar kunnen zoeken
        {
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }
        private void CLICKTIMER_TICK(object sender, EventArgs e) //deze functie is simpel, deze functie verbergt eerst alle beelden door de functie HideImages () te gebruiken vervolgens verandert ie de allow click boolean naar true en daarna stopt ie de timer.
        {
            HideImages();

            allowClick = true;
            clickTimer.Stop();
        }

        private void clickImage(object sender, EventArgs e) //eerst voeren we een if statement uit, is isClicked false dan gaat ie terug naar het programma zonder iets anders te doen.
        {
            if (!allowClick) return;

            var pic = (PictureBox)sender; //In deze lijn maken we een lokale variabele, die alleen in deze functie genaamd pic wordt gebruikt. Deze variabele zal identificeren op welke picturebox geklikt is of waar de gebeurtenis vandaan kwam.

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;  //Als de eerste guess leeg is, dan laten we de pic-variabele onze eerste gok maken, omdat de pic-variabele een soort picturebox is, die dezelfde eigenschappen heeft als eentje  kunnen we de pic.Image gebruiken eigenschap om eventuele afbeeldingen op te stellen.
                return;
            }

            pic.Image = (Image)pic.Tag; // wanneer de afbeeldingen worden gevonden, plaatst  de juiste tag in de picturebox


            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                HideImages(); //afbeeldingen verbergen

            }

            else
            {
                allowClick = false;
                clickTimer.Start();
            }

            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return; //controleert of er nog zichtbare pictureboxes op het scherm zo niet dan laat ie het bericht hieronder zien
            MessageBox.Show("Congrats you aren't retarded"); //het bericht
            ResetImages(); //vervolgens de images resetten

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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
       
}
