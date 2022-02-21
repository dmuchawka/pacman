namespace gierka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playbutton.Location = new System.Drawing.Point(443, 222);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(180, 116);
            this.playbutton.TabIndex = 0;
            this.playbutton.Text = "kliknij aby zagrac w pacman";
            this.playbutton.UseVisualStyleBackColor = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1104, 548);
            this.Controls.Add(this.playbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button playbutton;
    }
}