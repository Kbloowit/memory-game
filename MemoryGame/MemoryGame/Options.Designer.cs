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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.LabelSoundeffects = new System.Windows.Forms.Label();
            this.labelBackgroundmusic = new System.Windows.Forms.Label();
            this.labelMute = new System.Windows.Forms.Label();
            this.checkbox_soundeffects = new System.Windows.Forms.CheckBox();
            this.checkbox_backgroundmusic = new System.Windows.Forms.CheckBox();
            this.checkbox_mute = new System.Windows.Forms.CheckBox();
            this.labelOptions = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelSoundeffects
            // 
            this.LabelSoundeffects.AutoSize = true;
            this.LabelSoundeffects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSoundeffects.Location = new System.Drawing.Point(92, 183);
            this.LabelSoundeffects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSoundeffects.Name = "LabelSoundeffects";
            this.LabelSoundeffects.Size = new System.Drawing.Size(264, 37);
            this.LabelSoundeffects.TabIndex = 0;
            this.LabelSoundeffects.Text = "Sound effects Off";
            // 
            // labelBackgroundmusic
            // 
            this.labelBackgroundmusic.AutoSize = true;
            this.labelBackgroundmusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackgroundmusic.Location = new System.Drawing.Point(92, 269);
            this.labelBackgroundmusic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBackgroundmusic.Name = "labelBackgroundmusic";
            this.labelBackgroundmusic.Size = new System.Drawing.Size(334, 37);
            this.labelBackgroundmusic.TabIndex = 1;
            this.labelBackgroundmusic.Text = "Background music Off";
            // 
            // labelMute
            // 
            this.labelMute.AutoSize = true;
            this.labelMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMute.Location = new System.Drawing.Point(92, 367);
            this.labelMute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMute.Name = "labelMute";
            this.labelMute.Size = new System.Drawing.Size(241, 37);
            this.labelMute.TabIndex = 2;
            this.labelMute.Text = "Mute all sounds";
            // 
            // checkbox_soundeffects
            // 
            this.checkbox_soundeffects.AutoSize = true;
            this.checkbox_soundeffects.Location = new System.Drawing.Point(782, 183);
            this.checkbox_soundeffects.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox_soundeffects.Name = "checkbox_soundeffects";
            this.checkbox_soundeffects.Size = new System.Drawing.Size(28, 27);
            this.checkbox_soundeffects.TabIndex = 3;
            this.checkbox_soundeffects.UseVisualStyleBackColor = true;
            // 
            // checkbox_backgroundmusic
            // 
            this.checkbox_backgroundmusic.AutoSize = true;
            this.checkbox_backgroundmusic.Location = new System.Drawing.Point(782, 279);
            this.checkbox_backgroundmusic.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox_backgroundmusic.Name = "checkbox_backgroundmusic";
            this.checkbox_backgroundmusic.Size = new System.Drawing.Size(28, 27);
            this.checkbox_backgroundmusic.TabIndex = 4;
            this.checkbox_backgroundmusic.UseVisualStyleBackColor = true;
            this.checkbox_backgroundmusic.CheckedChanged += new System.EventHandler(this.checkbox_backgroundmusic_CheckedChanged);
            // 
            // checkbox_mute
            // 
            this.checkbox_mute.AutoSize = true;
            this.checkbox_mute.Location = new System.Drawing.Point(782, 379);
            this.checkbox_mute.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox_mute.Name = "checkbox_mute";
            this.checkbox_mute.Size = new System.Drawing.Size(28, 27);
            this.checkbox_mute.TabIndex = 5;
            this.checkbox_mute.UseVisualStyleBackColor = true;
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptions.Location = new System.Drawing.Point(92, 83);
            this.labelOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(154, 42);
            this.labelOptions.TabIndex = 6;
            this.labelOptions.Text = "Options";
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(764, 571);
            this.button_back.Margin = new System.Windows.Forms.Padding(4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(128, 67);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Options
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 660);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.labelOptions);
            this.Controls.Add(this.checkbox_mute);
            this.Controls.Add(this.checkbox_backgroundmusic);
            this.Controls.Add(this.checkbox_soundeffects);
            this.Controls.Add(this.labelMute);
            this.Controls.Add(this.labelBackgroundmusic);
            this.Controls.Add(this.LabelSoundeffects);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSoundeffects;
        private System.Windows.Forms.Label labelBackgroundmusic;
        private System.Windows.Forms.Label labelMute;
        private System.Windows.Forms.CheckBox checkbox_soundeffects;
        private System.Windows.Forms.CheckBox checkbox_backgroundmusic;
        private System.Windows.Forms.CheckBox checkbox_mute;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Button button_back;
    }
}