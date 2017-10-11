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
            this.button1 = new System.Windows.Forms.Button();
            this.button_options = new System.Windows.Forms.Button();
            this.button_highscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(435, 106);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(342, 55);
            this.titel.TabIndex = 0;
            this.titel.Text = "Memory Game";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 104);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_options
            // 
            this.button_options.Location = new System.Drawing.Point(457, 372);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(271, 104);
            this.button_options.TabIndex = 2;
            this.button_options.Text = "Options";
            this.button_options.UseVisualStyleBackColor = true;
            // 
            // button_highscore
            // 
            this.button_highscore.Location = new System.Drawing.Point(457, 514);
            this.button_highscore.Name = "button_highscore";
            this.button_highscore.Size = new System.Drawing.Size(271, 104);
            this.button_highscore.TabIndex = 3;
            this.button_highscore.Text = "Highscores";
            this.button_highscore.UseVisualStyleBackColor = true;
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 887);
            this.Controls.Add(this.button_highscore);
            this.Controls.Add(this.button_options);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titel);
            this.Name = "Hoofdmenu";
            this.Text = "Hoofdmenu";
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