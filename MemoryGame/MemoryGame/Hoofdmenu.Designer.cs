﻿namespace MemoryGame
{
    partial class Hoofdmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoofdmenu));
            this.titel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_options = new System.Windows.Forms.Button();
            this.button_highscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(436, 106);
            this.titel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(342, 55);
            this.titel.TabIndex = 0;
            this.titel.Text = "Memory Game";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(456, 227);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 104);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_options
            // 
            this.button_options.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_options.Location = new System.Drawing.Point(456, 371);
            this.button_options.Margin = new System.Windows.Forms.Padding(4);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(272, 104);
            this.button_options.TabIndex = 2;
            this.button_options.Text = "Options";
            this.button_options.UseVisualStyleBackColor = false;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            // 
            // button_highscore
            // 
            this.button_highscore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_highscore.Location = new System.Drawing.Point(456, 513);
            this.button_highscore.Margin = new System.Windows.Forms.Padding(4);
            this.button_highscore.Name = "button_highscore";
            this.button_highscore.Size = new System.Drawing.Size(272, 104);
            this.button_highscore.TabIndex = 3;
            this.button_highscore.Text = "Highscores";
            this.button_highscore.UseVisualStyleBackColor = false;
            this.button_highscore.Click += new System.EventHandler(this.button_highscore_Click);
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 733);
            this.Controls.Add(this.button_highscore);
            this.Controls.Add(this.button_options);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hoofdmenu";
            this.Text = "Hoofdmenu";
            this.Load += new System.EventHandler(this.Hoofdmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_options;
        private System.Windows.Forms.Button button_highscore;
    }
    

}