namespace MemoryGame
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
            this.titel = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonHighscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(218, 55);
            this.titel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(171, 29);
            this.titel.TabIndex = 0;
            this.titel.Text = "Memory Game";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(228, 118);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(136, 54);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Location = new System.Drawing.Point(228, 193);
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(136, 54);
            this.buttonOptions.TabIndex = 2;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.button_options_Click);
            // 
            // buttonHighscore
            // 
            this.buttonHighscore.Location = new System.Drawing.Point(228, 267);
            this.buttonHighscore.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHighscore.Name = "buttonHighscore";
            this.buttonHighscore.Size = new System.Drawing.Size(136, 54);
            this.buttonHighscore.TabIndex = 3;
            this.buttonHighscore.Text = "Highscores";
            this.buttonHighscore.UseVisualStyleBackColor = true;
            this.buttonHighscore.Click += new System.EventHandler(this.button_highscore_Click);
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 381);
            this.Controls.Add(this.buttonHighscore);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.titel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hoofdmenu";
            this.Text = "Hoofdmenu";
            this.Load += new System.EventHandler(this.Hoofdmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonHighscore;
    }
    

}