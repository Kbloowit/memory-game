namespace MemoryGame
{
<<<<<<< HEAD
    partial class Gamepanel
=======
    partial class GamePanel
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NameP1 = new System.Windows.Forms.Label();
            this.NameP2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
=======
            this.buttonStart = new System.Windows.Forms.Button();
            this.Timertime = new System.Windows.Forms.Label();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card13 = new System.Windows.Forms.PictureBox();
            this.card14 = new System.Windows.Forms.PictureBox();
            this.card15 = new System.Windows.Forms.PictureBox();
            this.card16 = new System.Windows.Forms.PictureBox();
            this.card9 = new System.Windows.Forms.PictureBox();
            this.card10 = new System.Windows.Forms.PictureBox();
            this.card11 = new System.Windows.Forms.PictureBox();
            this.card12 = new System.Windows.Forms.PictureBox();
            this.card8 = new System.Windows.Forms.PictureBox();
            this.card7 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.NameP1 = new System.Windows.Forms.Label();
            this.NameP2 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Timername = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1442, 562);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1500, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:60";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(50, 800);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(250, 225);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 3;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(350, 800);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(250, 225);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 4;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(650, 800);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(250, 225);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 5;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(950, 800);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(250, 225);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 6;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(50, 550);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(250, 225);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(350, 550);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(250, 225);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(650, 550);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(250, 225);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 9;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(950, 550);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(250, 225);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 10;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(950, 300);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(250, 225);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(650, 300);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(250, 225);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(350, 300);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(250, 225);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(50, 300);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(250, 225);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(950, 50);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(250, 225);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(650, 50);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 225);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.clickImage);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(350, 50);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.clickImage);
=======
            this.buttonSaveQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(721, 292);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(135, 41);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.startGame);
            // 
            // Timertime
            // 
            this.Timertime.AutoSize = true;
            this.Timertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timertime.Location = new System.Drawing.Point(750, 217);
            this.Timertime.Name = "Timertime";
            this.Timertime.Size = new System.Drawing.Size(71, 25);
            this.Timertime.TabIndex = 1;
            this.Timertime.Text = "00:60";
            // 
            // card1
            // 
            this.card1.Location = new System.Drawing.Point(25, 26);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(125, 117);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1.TabIndex = 2;
            this.card1.TabStop = false;
            this.card1.Click += new System.EventHandler(this.clickImage);
            // 
            // card13
            // 
            this.card13.Location = new System.Drawing.Point(25, 416);
            this.card13.Name = "card13";
            this.card13.Size = new System.Drawing.Size(125, 117);
            this.card13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card13.TabIndex = 3;
            this.card13.TabStop = false;
            this.card13.Click += new System.EventHandler(this.clickImage);
            // 
            // card14
            // 
            this.card14.Location = new System.Drawing.Point(175, 416);
            this.card14.Name = "card14";
            this.card14.Size = new System.Drawing.Size(125, 117);
            this.card14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card14.TabIndex = 4;
            this.card14.TabStop = false;
            this.card14.Click += new System.EventHandler(this.clickImage);
            // 
            // card15
            // 
            this.card15.Location = new System.Drawing.Point(325, 416);
            this.card15.Name = "card15";
            this.card15.Size = new System.Drawing.Size(125, 117);
            this.card15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card15.TabIndex = 5;
            this.card15.TabStop = false;
            this.card15.Click += new System.EventHandler(this.clickImage);
            // 
            // card16
            // 
            this.card16.Location = new System.Drawing.Point(475, 416);
            this.card16.Name = "card16";
            this.card16.Size = new System.Drawing.Size(125, 117);
            this.card16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card16.TabIndex = 6;
            this.card16.TabStop = false;
            this.card16.Click += new System.EventHandler(this.clickImage);
            // 
            // card9
            // 
            this.card9.Location = new System.Drawing.Point(25, 286);
            this.card9.Name = "card9";
            this.card9.Size = new System.Drawing.Size(125, 117);
            this.card9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card9.TabIndex = 7;
            this.card9.TabStop = false;
            this.card9.Click += new System.EventHandler(this.clickImage);
            // 
            // card10
            // 
            this.card10.Location = new System.Drawing.Point(175, 286);
            this.card10.Name = "card10";
            this.card10.Size = new System.Drawing.Size(125, 117);
            this.card10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card10.TabIndex = 8;
            this.card10.TabStop = false;
            this.card10.Click += new System.EventHandler(this.clickImage);
            // 
            // card11
            // 
            this.card11.Location = new System.Drawing.Point(325, 286);
            this.card11.Name = "card11";
            this.card11.Size = new System.Drawing.Size(125, 117);
            this.card11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card11.TabIndex = 9;
            this.card11.TabStop = false;
            this.card11.Click += new System.EventHandler(this.clickImage);
            // 
            // card12
            // 
            this.card12.Location = new System.Drawing.Point(475, 286);
            this.card12.Name = "card12";
            this.card12.Size = new System.Drawing.Size(125, 117);
            this.card12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card12.TabIndex = 10;
            this.card12.TabStop = false;
            this.card12.Click += new System.EventHandler(this.clickImage);
            // 
            // card8
            // 
            this.card8.Location = new System.Drawing.Point(475, 156);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(125, 117);
            this.card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card8.TabIndex = 11;
            this.card8.TabStop = false;
            this.card8.Click += new System.EventHandler(this.clickImage);
            // 
            // card7
            // 
            this.card7.Location = new System.Drawing.Point(325, 156);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(125, 117);
            this.card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card7.TabIndex = 12;
            this.card7.TabStop = false;
            this.card7.Click += new System.EventHandler(this.clickImage);
            // 
            // card6
            // 
            this.card6.Location = new System.Drawing.Point(175, 156);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(125, 117);
            this.card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card6.TabIndex = 13;
            this.card6.TabStop = false;
            this.card6.Click += new System.EventHandler(this.clickImage);
            // 
            // card5
            // 
            this.card5.Location = new System.Drawing.Point(25, 156);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(125, 117);
            this.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card5.TabIndex = 14;
            this.card5.TabStop = false;
            this.card5.Click += new System.EventHandler(this.clickImage);
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(475, 26);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(125, 117);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card4.TabIndex = 15;
            this.card4.TabStop = false;
            this.card4.Click += new System.EventHandler(this.clickImage);
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(325, 26);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(125, 117);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card3.TabIndex = 16;
            this.card3.TabStop = false;
            this.card3.Click += new System.EventHandler(this.clickImage);
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(175, 26);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(125, 117);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card2.TabIndex = 17;
            this.card2.TabStop = false;
            this.card2.Click += new System.EventHandler(this.clickImage);
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            // 
            // NameP1
            // 
            this.NameP1.AutoSize = true;
            this.NameP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.NameP1.Location = new System.Drawing.Point(1285, 121);
            this.NameP1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameP1.Name = "NameP1";
            this.NameP1.Size = new System.Drawing.Size(102, 37);
            this.NameP1.TabIndex = 18;
            this.NameP1.Text = "label2";
=======
            this.NameP1.Location = new System.Drawing.Point(642, 63);
            this.NameP1.Name = "NameP1";
            this.NameP1.Size = new System.Drawing.Size(70, 20);
            this.NameP1.TabIndex = 18;
            this.NameP1.Text = "NameP1";
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            // 
            // NameP2
            // 
            this.NameP2.AutoSize = true;
            this.NameP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.NameP2.Location = new System.Drawing.Point(1285, 215);
            this.NameP2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameP2.Name = "NameP2";
            this.NameP2.Size = new System.Drawing.Size(102, 37);
            this.NameP2.TabIndex = 19;
            this.NameP2.Text = "label3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1438, 683);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 88);
            this.button2.TabIndex = 20;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1438, 813);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 88);
            this.button3.TabIndex = 21;
            this.button3.Text = "Opties";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
=======
            this.NameP2.Location = new System.Drawing.Point(642, 112);
            this.NameP2.Name = "NameP2";
            this.NameP2.Size = new System.Drawing.Size(74, 20);
            this.NameP2.TabIndex = 19;
            this.NameP2.Text = "Name P2";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(719, 355);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(135, 46);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Location = new System.Drawing.Point(719, 423);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(135, 46);
            this.buttonOptions.TabIndex = 3;
            this.buttonOptions.Text = "Opties";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.score1.Location = new System.Drawing.Point(1560, 121);
            this.score1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(41, 44);
=======
            this.score1.Location = new System.Drawing.Point(780, 63);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(20, 24);
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            this.score1.TabIndex = 22;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.score2.Location = new System.Drawing.Point(1560, 215);
            this.score2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(41, 44);
=======
            this.score2.Location = new System.Drawing.Point(780, 112);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(20, 24);
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            this.score2.TabIndex = 23;
            this.score2.Text = "0";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.x1.Location = new System.Drawing.Point(1734, 121);
            this.x1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(39, 44);
=======
            this.x1.Location = new System.Drawing.Point(867, 63);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(20, 24);
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            this.x1.TabIndex = 24;
            this.x1.Text = "x";
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.x2.Location = new System.Drawing.Point(1720, 208);
            this.x2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(53, 44);
=======
            this.x2.Location = new System.Drawing.Point(860, 108);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(25, 24);
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            this.x2.TabIndex = 26;
            this.x2.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(1538, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 42);
            this.label3.TabIndex = 27;
            this.label3.Text = "Paren";
=======
            this.label3.Location = new System.Drawing.Point(769, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pairs";
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label4.Location = new System.Drawing.Point(1704, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 42);
=======
            this.label4.Location = new System.Drawing.Point(852, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            this.label4.TabIndex = 28;
            this.label4.Text = "Turn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label5.Location = new System.Drawing.Point(1286, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 42);
=======
            this.label5.Location = new System.Drawing.Point(643, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            this.label5.TabIndex = 29;
            this.label5.Text = "Name";
            // 
            // Timername
            // 
            this.Timername.AutoSize = true;
            this.Timername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.Timername.Location = new System.Drawing.Point(1496, 345);
            this.Timername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Timername.Name = "Timername";
            this.Timername.Size = new System.Drawing.Size(133, 48);
            this.Timername.TabIndex = 30;
            this.Timername.Text = "Timer";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1438, 938);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 88);
            this.button4.TabIndex = 31;
            this.button4.Text = "Save/Quit";
            this.button4.UseVisualStyleBackColor = true;
            
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1864, 1118);
            this.Controls.Add(this.button4);
=======
            this.Timername.Location = new System.Drawing.Point(748, 179);
            this.Timername.Name = "Timername";
            this.Timername.Size = new System.Drawing.Size(71, 25);
            this.Timername.TabIndex = 30;
            this.Timername.Text = "Timer";
            // 
            // buttonSaveQuit
            // 
            this.buttonSaveQuit.Location = new System.Drawing.Point(719, 488);
            this.buttonSaveQuit.Name = "buttonSaveQuit";
            this.buttonSaveQuit.Size = new System.Drawing.Size(135, 46);
            this.buttonSaveQuit.TabIndex = 4;
            this.buttonSaveQuit.Text = "Save/Quit";
            this.buttonSaveQuit.UseVisualStyleBackColor = true;
            this.buttonSaveQuit.Click += new System.EventHandler(this.buttonSaveQuit_Click);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 581);
            this.Controls.Add(this.buttonSaveQuit);
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            this.Controls.Add(this.Timername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
<<<<<<< HEAD
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NameP2);
            this.Controls.Add(this.NameP1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
=======
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.NameP2);
            this.Controls.Add(this.NameP1);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card7);
            this.Controls.Add(this.card8);
            this.Controls.Add(this.card12);
            this.Controls.Add(this.card11);
            this.Controls.Add(this.card10);
            this.Controls.Add(this.card9);
            this.Controls.Add(this.card16);
            this.Controls.Add(this.card15);
            this.Controls.Add(this.card14);
            this.Controls.Add(this.card13);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.Timertime);
            this.Controls.Add(this.buttonStart);
            this.Name = "GamePanel";
            this.Text = "Memory Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label NameP1;
        private System.Windows.Forms.Label NameP2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
=======
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label Timertime;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card13;
        private System.Windows.Forms.PictureBox card14;
        private System.Windows.Forms.PictureBox card15;
        private System.Windows.Forms.PictureBox card16;
        private System.Windows.Forms.PictureBox card9;
        private System.Windows.Forms.PictureBox card10;
        private System.Windows.Forms.PictureBox card11;
        private System.Windows.Forms.PictureBox card12;
        private System.Windows.Forms.PictureBox card8;
        private System.Windows.Forms.PictureBox card7;
        private System.Windows.Forms.PictureBox card6;
        private System.Windows.Forms.PictureBox card5;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.Label NameP1;
        private System.Windows.Forms.Label NameP2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonOptions;
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label x2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Timername;
<<<<<<< HEAD
        private System.Windows.Forms.Button button4;
=======
        private System.Windows.Forms.Button buttonSaveQuit;
>>>>>>> fdc3ab5059109bda6008142f3851ebba851efdcd
    }
}