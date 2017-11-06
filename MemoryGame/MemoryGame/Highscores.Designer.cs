namespace MemoryGame
{
    partial class Highscores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Highscores));
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.listBoxScores = new System.Windows.Forms.ListBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 25;
            this.listBoxPlayers.Location = new System.Drawing.Point(64, 67);
            this.listBoxPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(258, 454);
            this.listBoxPlayers.TabIndex = 0;
            // 
            // listBoxScores
            // 
            this.listBoxScores.FormattingEnabled = true;
            this.listBoxScores.ItemHeight = 25;
            this.listBoxScores.Location = new System.Drawing.Point(356, 67);
            this.listBoxScores.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxScores.Name = "listBoxScores";
            this.listBoxScores.Size = new System.Drawing.Size(258, 454);
            this.listBoxScores.TabIndex = 1;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(712, 473);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(150, 52);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // Highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 558);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.listBoxScores);
            this.Controls.Add(this.listBoxPlayers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Highscores";
            this.Text = "Memory Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.ListBox listBoxScores;
        private System.Windows.Forms.Button buttonMenu;
    }
}