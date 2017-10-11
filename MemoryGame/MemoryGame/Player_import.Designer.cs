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
            this.button_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.Location = new System.Drawing.Point(61, 192);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(140, 37);
            this.labelP1.TabIndex = 0;
            this.labelP1.Text = "Player 1:";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.Location = new System.Drawing.Point(61, 299);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(142, 37);
            this.labelP2.TabIndex = 1;
            this.labelP2.Text = "Player 2:";
            // 
            // importP2
            // 
            this.importP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importP2.Location = new System.Drawing.Point(293, 299);
            this.importP2.Name = "importP2";
            this.importP2.Size = new System.Drawing.Size(250, 44);
            this.importP2.TabIndex = 3;
            // 
            // importP1
            // 
            this.importP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importP1.Location = new System.Drawing.Point(293, 192);
            this.importP1.Name = "importP1";
            this.importP1.Size = new System.Drawing.Size(250, 44);
            this.importP1.TabIndex = 4;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(673, 216);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(204, 80);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player import";
            // 
            // Player_import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.importP1);
            this.Controls.Add(this.importP2);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
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
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label1;
    }
}