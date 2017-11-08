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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.highscorebox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(358, 246);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(89, 41);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Terug";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // highscorebox
            // 
            this.highscorebox.FormattingEnabled = true;
            this.highscorebox.Location = new System.Drawing.Point(123, 47);
            this.highscorebox.Name = "highscorebox";
            this.highscorebox.Size = new System.Drawing.Size(230, 264);
            this.highscorebox.TabIndex = 3;
            // 
            // Highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 329);
            this.Controls.Add(this.highscorebox);
            this.Controls.Add(this.buttonMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(486, 338);
            this.Name = "Highscores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memorie";
            this.Load += new System.EventHandler(this.Highscores_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ListBox highscorebox;
    }
}