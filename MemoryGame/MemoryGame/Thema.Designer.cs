namespace MemoryGame
{
    partial class Thema
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
            this.Pick = new System.Windows.Forms.Label();
            this.Avengers = new System.Windows.Forms.Button();
            this.Formule1 = new System.Windows.Forms.Button();
            this.Gta5 = new System.Windows.Forms.Button();
            this.Cars = new System.Windows.Forms.Button();
            this.Royalty = new System.Windows.Forms.Button();
            this.Winx = new System.Windows.Forms.Button();
            this.Social = new System.Windows.Forms.Button();
            this.Disney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pick
            // 
            this.Pick.AutoSize = true;
            this.Pick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pick.Location = new System.Drawing.Point(182, 32);
            this.Pick.Name = "Pick";
            this.Pick.Size = new System.Drawing.Size(148, 25);
            this.Pick.TabIndex = 0;
            this.Pick.Text = "Pick a theme";
            this.Pick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pick.Click += new System.EventHandler(this.Pick_Click);
            // 
            // Avengers
            // 
            this.Avengers.Location = new System.Drawing.Point(43, 99);
            this.Avengers.Name = "Avengers";
            this.Avengers.Size = new System.Drawing.Size(92, 38);
            this.Avengers.TabIndex = 1;
            this.Avengers.Text = "Avengers";
            this.Avengers.UseVisualStyleBackColor = true;
            this.Avengers.Click += new System.EventHandler(this.Avengers_Click);
            // 
            // Formule1
            // 
            this.Formule1.Location = new System.Drawing.Point(162, 158);
            this.Formule1.Name = "Formule1";
            this.Formule1.Size = new System.Drawing.Size(92, 38);
            this.Formule1.TabIndex = 3;
            this.Formule1.Text = "Formule 1";
            this.Formule1.UseVisualStyleBackColor = true;
            this.Formule1.Click += new System.EventHandler(this.Formule1_Click);
            // 
            // Gta5
            // 
            this.Gta5.Location = new System.Drawing.Point(43, 158);
            this.Gta5.Name = "Gta5";
            this.Gta5.Size = new System.Drawing.Size(92, 38);
            this.Gta5.TabIndex = 4;
            this.Gta5.Text = "GTA 5";
            this.Gta5.UseVisualStyleBackColor = true;
            this.Avengers.Click += new System.EventHandler(this.Avengers_Click);
            // 
            // Cars
            // 
            this.Cars.Location = new System.Drawing.Point(162, 99);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(92, 38);
            this.Cars.TabIndex = 4;
            this.Cars.Text = "Cars";
            this.Cars.UseVisualStyleBackColor = true;
            this.Cars.Click += new System.EventHandler(this.Cars_Click);
            // 
            // Royalty
            // 
            this.Royalty.Location = new System.Drawing.Point(401, 99);
            this.Royalty.Name = "Royalty";
            this.Royalty.Size = new System.Drawing.Size(92, 38);
            this.Royalty.TabIndex = 5;
            this.Royalty.Text = "Royalty";
            this.Royalty.UseVisualStyleBackColor = true;
            this.Royalty.Click += new System.EventHandler(this.Royalty_Click);
            // 
            // Winx
            // 
            this.Winx.Location = new System.Drawing.Point(283, 99);
            this.Winx.Name = "Winx";
            this.Winx.Size = new System.Drawing.Size(92, 38);
            this.Winx.TabIndex = 5;
            this.Winx.Text = "Winx";
            this.Winx.UseVisualStyleBackColor = true;
            this.Winx.Click += new System.EventHandler(this.Winx_Click);
            // 
            // Social
            // 
            this.Social.Location = new System.Drawing.Point(283, 158);
            this.Social.Name = "Social";
            this.Social.Size = new System.Drawing.Size(92, 38);
            this.Social.TabIndex = 6;
            this.Social.Text = "Social Media";
            this.Social.UseVisualStyleBackColor = true;
            this.Social.Click += new System.EventHandler(this.Social_Click);
            // 
            // Disney
            // 
            this.Disney.Location = new System.Drawing.Point(401, 158);
            this.Disney.Name = "Disney";
            this.Disney.Size = new System.Drawing.Size(92, 38);
            this.Disney.TabIndex = 7;
            this.Disney.Text = "Disney Princesses";
            this.Disney.UseVisualStyleBackColor = true;
            this.Disney.Click += new System.EventHandler(this.Disney_Click);
            // 
            // Thema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 248);
            this.Controls.Add(this.Disney);
            this.Controls.Add(this.Social);
            this.Controls.Add(this.Winx);
            this.Controls.Add(this.Royalty);
            this.Controls.Add(this.Cars);
            this.Controls.Add(this.Gta5);
            this.Controls.Add(this.Formule1);
            this.Controls.Add(this.Avengers);
            this.Controls.Add(this.Pick);
            this.Name = "Thema";
            this.Text = "Thema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pick;
        private System.Windows.Forms.Button Avengers;
        private System.Windows.Forms.Button Formule1;
        private System.Windows.Forms.Button Gta5;
        private System.Windows.Forms.Button Cars;
        private System.Windows.Forms.Button Royalty;
        private System.Windows.Forms.Button Winx;
        private System.Windows.Forms.Button Social;
        private System.Windows.Forms.Button Disney;
    }
}