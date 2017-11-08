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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoofdmenu));
            this.LabelTitel = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonHighscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitel
            // 
            this.LabelTitel.AutoSize = true;
            this.LabelTitel.BackColor = System.Drawing.Color.White;
            this.LabelTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitel.Location = new System.Drawing.Point(252, 55);
            this.LabelTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitel.Name = "LabelTitel";
            this.LabelTitel.Size = new System.Drawing.Size(109, 29);
            this.LabelTitel.TabIndex = 0;
            this.LabelTitel.Text = "Memorie";
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPlay.Location = new System.Drawing.Point(236, 115);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(136, 54);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Start";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOptions.Location = new System.Drawing.Point(236, 190);
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(136, 54);
            this.buttonOptions.TabIndex = 2;
            this.buttonOptions.Text = "Opties";
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonHighscore
            // 
            this.buttonHighscore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHighscore.Location = new System.Drawing.Point(236, 264);
            this.buttonHighscore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHighscore.Name = "buttonHighscore";
            this.buttonHighscore.Size = new System.Drawing.Size(136, 54);
            this.buttonHighscore.TabIndex = 3;
            this.buttonHighscore.Text = "Ranglijst";
            this.buttonHighscore.UseVisualStyleBackColor = false;
            this.buttonHighscore.Click += new System.EventHandler(this.buttonHighscore_Click);
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 381);
            this.Controls.Add(this.buttonHighscore);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.LabelTitel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(607, 420);
            this.Name = "Hoofdmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memorie";
            this.Load += new System.EventHandler(this.Hoofdmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitel;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonHighscore;
    }
    

}