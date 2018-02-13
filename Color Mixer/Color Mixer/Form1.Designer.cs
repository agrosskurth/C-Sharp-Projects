namespace Color_Mixer
{
    partial class formMain
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
            this.gBoxLeft = new System.Windows.Forms.GroupBox();
            this.gBoxRight = new System.Windows.Forms.GroupBox();
            this.btnMix = new System.Windows.Forms.Button();
            this.radioLeftRed = new System.Windows.Forms.RadioButton();
            this.radioLeftBlue = new System.Windows.Forms.RadioButton();
            this.radioLeftYellow = new System.Windows.Forms.RadioButton();
            this.radioRightRed = new System.Windows.Forms.RadioButton();
            this.radioRightBlue = new System.Windows.Forms.RadioButton();
            this.radioRightYellow = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.gBoxLeft.SuspendLayout();
            this.gBoxRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxLeft
            // 
            this.gBoxLeft.Controls.Add(this.radioLeftYellow);
            this.gBoxLeft.Controls.Add(this.radioLeftBlue);
            this.gBoxLeft.Controls.Add(this.radioLeftRed);
            this.gBoxLeft.Location = new System.Drawing.Point(12, 12);
            this.gBoxLeft.Name = "gBoxLeft";
            this.gBoxLeft.Size = new System.Drawing.Size(162, 90);
            this.gBoxLeft.TabIndex = 0;
            this.gBoxLeft.TabStop = false;
            this.gBoxLeft.Text = "Select a color to mix";
            // 
            // gBoxRight
            // 
            this.gBoxRight.Controls.Add(this.radioRightYellow);
            this.gBoxRight.Controls.Add(this.radioRightBlue);
            this.gBoxRight.Controls.Add(this.radioRightRed);
            this.gBoxRight.Location = new System.Drawing.Point(193, 12);
            this.gBoxRight.Name = "gBoxRight";
            this.gBoxRight.Size = new System.Drawing.Size(162, 90);
            this.gBoxRight.TabIndex = 1;
            this.gBoxRight.TabStop = false;
            this.gBoxRight.Text = "Select another color to mix";
            // 
            // btnMix
            // 
            this.btnMix.Location = new System.Drawing.Point(99, 108);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(75, 23);
            this.btnMix.TabIndex = 2;
            this.btnMix.Text = "Mix it!";
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // radioLeftRed
            // 
            this.radioLeftRed.AutoSize = true;
            this.radioLeftRed.Location = new System.Drawing.Point(34, 19);
            this.radioLeftRed.Name = "radioLeftRed";
            this.radioLeftRed.Size = new System.Drawing.Size(45, 17);
            this.radioLeftRed.TabIndex = 0;
            this.radioLeftRed.TabStop = true;
            this.radioLeftRed.Text = "Red";
            this.radioLeftRed.UseVisualStyleBackColor = true;
            // 
            // radioLeftBlue
            // 
            this.radioLeftBlue.AutoSize = true;
            this.radioLeftBlue.Location = new System.Drawing.Point(34, 42);
            this.radioLeftBlue.Name = "radioLeftBlue";
            this.radioLeftBlue.Size = new System.Drawing.Size(46, 17);
            this.radioLeftBlue.TabIndex = 1;
            this.radioLeftBlue.TabStop = true;
            this.radioLeftBlue.Text = "Blue";
            this.radioLeftBlue.UseVisualStyleBackColor = true;
            // 
            // radioLeftYellow
            // 
            this.radioLeftYellow.AutoSize = true;
            this.radioLeftYellow.Location = new System.Drawing.Point(34, 65);
            this.radioLeftYellow.Name = "radioLeftYellow";
            this.radioLeftYellow.Size = new System.Drawing.Size(56, 17);
            this.radioLeftYellow.TabIndex = 2;
            this.radioLeftYellow.TabStop = true;
            this.radioLeftYellow.Text = "Yellow";
            this.radioLeftYellow.UseVisualStyleBackColor = true;
            // 
            // radioRightRed
            // 
            this.radioRightRed.AutoSize = true;
            this.radioRightRed.Location = new System.Drawing.Point(47, 19);
            this.radioRightRed.Name = "radioRightRed";
            this.radioRightRed.Size = new System.Drawing.Size(45, 17);
            this.radioRightRed.TabIndex = 1;
            this.radioRightRed.TabStop = true;
            this.radioRightRed.Text = "Red";
            this.radioRightRed.UseVisualStyleBackColor = true;
            // 
            // radioRightBlue
            // 
            this.radioRightBlue.AutoSize = true;
            this.radioRightBlue.Location = new System.Drawing.Point(47, 42);
            this.radioRightBlue.Name = "radioRightBlue";
            this.radioRightBlue.Size = new System.Drawing.Size(46, 17);
            this.radioRightBlue.TabIndex = 2;
            this.radioRightBlue.TabStop = true;
            this.radioRightBlue.Text = "Blue";
            this.radioRightBlue.UseVisualStyleBackColor = true;
            // 
            // radioRightYellow
            // 
            this.radioRightYellow.AutoSize = true;
            this.radioRightYellow.Location = new System.Drawing.Point(47, 65);
            this.radioRightYellow.Name = "radioRightYellow";
            this.radioRightYellow.Size = new System.Drawing.Size(56, 17);
            this.radioRightYellow.TabIndex = 3;
            this.radioRightYellow.TabStop = true;
            this.radioRightYellow.Text = "Yellow";
            this.radioRightYellow.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(193, 108);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 137);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.gBoxRight);
            this.Controls.Add(this.gBoxLeft);
            this.Name = "formMain";
            this.Text = "Color Mixer";
            this.gBoxLeft.ResumeLayout(false);
            this.gBoxLeft.PerformLayout();
            this.gBoxRight.ResumeLayout(false);
            this.gBoxRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxLeft;
        private System.Windows.Forms.GroupBox gBoxRight;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.RadioButton radioLeftYellow;
        private System.Windows.Forms.RadioButton radioLeftBlue;
        private System.Windows.Forms.RadioButton radioLeftRed;
        private System.Windows.Forms.RadioButton radioRightYellow;
        private System.Windows.Forms.RadioButton radioRightBlue;
        private System.Windows.Forms.RadioButton radioRightRed;
        private System.Windows.Forms.Button btnExit;
    }
}

