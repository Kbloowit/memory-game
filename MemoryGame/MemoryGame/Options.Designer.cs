namespace MemoryGame
{
    partial class Options
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
            this.Label_soundeffects = new System.Windows.Forms.Label();
            this.label_backgroundmusic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox_soundeffects = new System.Windows.Forms.CheckBox();
            this.checkbox_backgroundmusic = new System.Windows.Forms.CheckBox();
            this.checkbox_mute = new System.Windows.Forms.CheckBox();
            this.labelOptions = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_soundeffects
            // 
            this.Label_soundeffects.AutoSize = true;
            this.Label_soundeffects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_soundeffects.Location = new System.Drawing.Point(46, 95);
            this.Label_soundeffects.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_soundeffects.Name = "Label_soundeffects";
            this.Label_soundeffects.Size = new System.Drawing.Size(135, 20);
            this.Label_soundeffects.TabIndex = 0;
            this.Label_soundeffects.Text = "Sound effects Off";
            // 
            // label_backgroundmusic
            // 
            this.label_backgroundmusic.AutoSize = true;
            this.label_backgroundmusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backgroundmusic.Location = new System.Drawing.Point(46, 140);
            this.label_backgroundmusic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_backgroundmusic.Name = "label_backgroundmusic";
            this.label_backgroundmusic.Size = new System.Drawing.Size(166, 20);
            this.label_backgroundmusic.TabIndex = 1;
            this.label_backgroundmusic.Text = "Background music Off";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mute all sounds";
            // 
            // checkbox_soundeffects
            // 
            this.checkbox_soundeffects.AutoSize = true;
            this.checkbox_soundeffects.Location = new System.Drawing.Point(391, 95);
            this.checkbox_soundeffects.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_soundeffects.Name = "checkbox_soundeffects";
            this.checkbox_soundeffects.Size = new System.Drawing.Size(15, 14);
            this.checkbox_soundeffects.TabIndex = 3;
            this.checkbox_soundeffects.UseVisualStyleBackColor = true;
            
            // 
            // checkbox_backgroundmusic
            // 
            this.checkbox_backgroundmusic.AutoSize = true;
            this.checkbox_backgroundmusic.Location = new System.Drawing.Point(391, 145);
            this.checkbox_backgroundmusic.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_backgroundmusic.Name = "checkbox_backgroundmusic";
            this.checkbox_backgroundmusic.Size = new System.Drawing.Size(15, 14);
            this.checkbox_backgroundmusic.TabIndex = 4;
            this.checkbox_backgroundmusic.UseVisualStyleBackColor = true;
            this.checkbox_backgroundmusic.CheckedChanged += new System.EventHandler(this.checkbox_backgroundmusic_CheckedChanged);
            // 
            // checkbox_mute
            // 
            this.checkbox_mute.AutoSize = true;
            this.checkbox_mute.Location = new System.Drawing.Point(391, 197);
            this.checkbox_mute.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_mute.Name = "checkbox_mute";
            this.checkbox_mute.Size = new System.Drawing.Size(15, 14);
            this.checkbox_mute.TabIndex = 5;
            this.checkbox_mute.UseVisualStyleBackColor = true;
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptions.Location = new System.Drawing.Point(46, 43);
            this.labelOptions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(82, 24);
            this.labelOptions.TabIndex = 6;
            this.labelOptions.Text = "Options";
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(382, 297);
            this.button_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(64, 35);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Options
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 343);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.labelOptions);
            this.Controls.Add(this.checkbox_mute);
            this.Controls.Add(this.checkbox_backgroundmusic);
            this.Controls.Add(this.checkbox_soundeffects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_backgroundmusic);
            this.Controls.Add(this.Label_soundeffects);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Options";
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_soundeffects;
        private System.Windows.Forms.Label label_backgroundmusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkbox_soundeffects;
        private System.Windows.Forms.CheckBox checkbox_backgroundmusic;
        private System.Windows.Forms.CheckBox checkbox_mute;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Button button_back;
    }
}