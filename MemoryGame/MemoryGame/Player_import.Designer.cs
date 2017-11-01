namespace MemoryGame
{
    partial class Player_import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player_import));
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.importP2 = new System.Windows.Forms.TextBox();
            this.importP1 = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelPlayerImport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.Location = new System.Drawing.Point(60, 192);
            this.labelP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(140, 37);
            this.labelP1.TabIndex = 0;
            this.labelP1.Text = "Player 1:";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.Location = new System.Drawing.Point(60, 298);
            this.labelP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(142, 37);
            this.labelP2.TabIndex = 1;
            this.labelP2.Text = "Player 2:";
            // 
            // importP2
            // 
            this.importP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importP2.Location = new System.Drawing.Point(292, 298);
            this.importP2.Margin = new System.Windows.Forms.Padding(4);
            this.importP2.Name = "importP2";
            this.importP2.Size = new System.Drawing.Size(250, 44);
            this.importP2.TabIndex = 4;
            // 
            // importP1
            // 
            this.importP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importP1.Location = new System.Drawing.Point(292, 192);
            this.importP1.Margin = new System.Windows.Forms.Padding(4);
            this.importP1.Name = "importP1";
            this.importP1.Size = new System.Drawing.Size(250, 44);
            this.importP1.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(674, 229);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(204, 81);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelPlayerImport
            // 
            this.labelPlayerImport.AutoSize = true;
            this.labelPlayerImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerImport.Location = new System.Drawing.Point(60, 71);
            this.labelPlayerImport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerImport.Name = "labelPlayerImport";
            this.labelPlayerImport.Size = new System.Drawing.Size(249, 42);
            this.labelPlayerImport.TabIndex = 6;
            this.labelPlayerImport.Text = "Player import";
            // 
            // Player_import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 579);
            this.Controls.Add(this.labelPlayerImport);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.importP1);
            this.Controls.Add(this.importP2);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Player_import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.TextBox importP2;
        private System.Windows.Forms.TextBox importP1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelPlayerImport;
    }

}