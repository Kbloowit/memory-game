﻿namespace MemoryGame
{
    partial class Gamepanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gamepanel));
            this.buttonStart = new System.Windows.Forms.Button();
            this.TimeLeft = new System.Windows.Forms.Label();
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
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.Label();
            this.labelPairs = new System.Windows.Forms.Label();
            this.labelTurn = new System.Windows.Forms.Label();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.Timername = new System.Windows.Forms.Label();
            this.buttonQuitSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(16, 33);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(270, 88);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.startGame);
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeft.Location = new System.Drawing.Point(1500, 417);
            this.TimeLeft.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(129, 48);
            this.TimeLeft.TabIndex = 1;
            this.TimeLeft.Text = "00:60";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.clickImage);
            // 
            // NameP1
            // 
            this.NameP1.AutoSize = true;
            this.NameP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameP1.Location = new System.Drawing.Point(1284, 121);
            this.NameP1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameP1.Name = "NameP1";
            this.NameP1.Size = new System.Drawing.Size(133, 37);
            this.NameP1.TabIndex = 18;
            this.NameP1.Text = "Speler 1";
            // 
            // NameP2
            // 
            this.NameP2.AutoSize = true;
            this.NameP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameP2.Location = new System.Drawing.Point(1284, 215);
            this.NameP2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameP2.Name = "NameP2";
            this.NameP2.Size = new System.Drawing.Size(135, 37);
            this.NameP2.TabIndex = 19;
            this.NameP2.Text = "Speler 2";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(311, 33);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(270, 88);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Location = new System.Drawing.Point(16, 144);
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(270, 88);
            this.buttonOptions.TabIndex = 21;
            this.buttonOptions.Text = "Opties";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(1608, 121);
            this.score1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(41, 44);
            this.score1.TabIndex = 22;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(1608, 215);
            this.score2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(41, 44);
            this.score2.TabIndex = 23;
            this.score2.Text = "0";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1.Location = new System.Drawing.Point(1772, 121);
            this.x1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(39, 44);
            this.x1.TabIndex = 24;
            this.x1.Text = "x";
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2.Location = new System.Drawing.Point(1772, 208);
            this.x2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(53, 44);
            this.x2.TabIndex = 26;
            this.x2.Text = "...";
            // 
            // labelPairs
            // 
            this.labelPairs.AutoSize = true;
            this.labelPairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPairs.Location = new System.Drawing.Point(1586, 38);
            this.labelPairs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPairs.Name = "labelPairs";
            this.labelPairs.Size = new System.Drawing.Size(97, 42);
            this.labelPairs.TabIndex = 27;
            this.labelPairs.Text = "Paar";
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.Location = new System.Drawing.Point(1742, 38);
            this.labelTurn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(107, 42);
            this.labelTurn.TabIndex = 28;
            this.labelTurn.Text = "Beurt";
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayers.Location = new System.Drawing.Point(1286, 38);
            this.labelPlayers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(145, 42);
            this.labelPlayers.TabIndex = 29;
            this.labelPlayers.Text = "Spelers";
            // 
            // Timername
            // 
            this.Timername.AutoSize = true;
            this.Timername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timername.Location = new System.Drawing.Point(1472, 344);
            this.Timername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Timername.Name = "Timername";
            this.Timername.Size = new System.Drawing.Size(191, 48);
            this.Timername.TabIndex = 30;
            this.Timername.Text = "Speeltijd";
            // 
            // buttonQuitSave
            // 
            this.buttonQuitSave.Location = new System.Drawing.Point(164, 256);
            this.buttonQuitSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonQuitSave.Name = "buttonQuitSave";
            this.buttonQuitSave.Size = new System.Drawing.Size(270, 88);
            this.buttonQuitSave.TabIndex = 31;
            this.buttonQuitSave.Text = "Afsluiten/Opslaan";
            this.buttonQuitSave.UseVisualStyleBackColor = true;
            this.buttonQuitSave.Click += new System.EventHandler(this.buttonQuitSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 88);
            this.button1.TabIndex = 32;
            this.button1.Text = "Ranglijst";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonQuitSave);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonOptions);
            this.groupBox1.Location = new System.Drawing.Point(1268, 581);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 363);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // Gamepanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1941, 1079);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Timername);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.labelPairs);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.NameP2);
            this.Controls.Add(this.NameP1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.TimeLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1967, 1150);
            this.Name = "Gamepanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memorie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gamepanel_FormClosed);
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
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label TimeLeft;
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
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label x2;
        private System.Windows.Forms.Label labelPairs;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.Label Timername;
        private System.Windows.Forms.Button buttonQuitSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}