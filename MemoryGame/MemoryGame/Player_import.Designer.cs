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
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.importP2 = new System.Windows.Forms.TextBox();
            this.importP1 = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.Location = new System.Drawing.Point(30, 100);
            this.labelP1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(69, 20);
            this.labelP1.TabIndex = 0;
            this.labelP1.Text = "Player 1:";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.Location = new System.Drawing.Point(30, 155);
            this.labelP2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(69, 20);
            this.labelP2.TabIndex = 1;
            this.labelP2.Text = "Player 2:";
            // 
            // importP2
            // 
            this.importP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importP2.Location = new System.Drawing.Point(146, 155);
            this.importP2.Margin = new System.Windows.Forms.Padding(2);
            this.importP2.Name = "importP2";
            this.importP2.Size = new System.Drawing.Size(127, 26);
            this.importP2.TabIndex = 4;

            // 
            // importP1
            // 
            this.importP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importP1.Location = new System.Drawing.Point(146, 100);
            this.importP1.Margin = new System.Windows.Forms.Padding(2);
            this.importP1.Name = "importP1";
            this.importP1.Size = new System.Drawing.Size(127, 26);
            this.importP1.TabIndex = 3;
            // 
            // buttonStart
            // 

           

            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(337, 119);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(102, 42);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player import";
            // 
            // Player_import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.importP1);
            this.Controls.Add(this.importP2);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Player_import";
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
        private System.Windows.Forms.Label label1;
    }

}