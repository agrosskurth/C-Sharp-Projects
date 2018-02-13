namespace Card_Identifier
{
    partial class Form1
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
            this.imgOne = new System.Windows.Forms.PictureBox();
            this.imgThree = new System.Windows.Forms.PictureBox();
            this.imgTwo = new System.Windows.Forms.PictureBox();
            this.imgFour = new System.Windows.Forms.PictureBox();
            this.imgFive = new System.Windows.Forms.PictureBox();
            this.labelCardName = new System.Windows.Forms.Label();
            this.labelInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFive)).BeginInit();
            this.SuspendLayout();
            // 
            // imgOne
            // 
            this.imgOne.Image = global::Card_Identifier.Properties.Resources._2_Clubs;
            this.imgOne.Location = new System.Drawing.Point(16, 12);
            this.imgOne.Name = "imgOne";
            this.imgOne.Size = new System.Drawing.Size(124, 180);
            this.imgOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOne.TabIndex = 0;
            this.imgOne.TabStop = false;
            this.imgOne.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgThree
            // 
            this.imgThree.Image = global::Card_Identifier.Properties.Resources._8_Hearts;
            this.imgThree.Location = new System.Drawing.Point(276, 12);
            this.imgThree.Name = "imgThree";
            this.imgThree.Size = new System.Drawing.Size(124, 180);
            this.imgThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgThree.TabIndex = 2;
            this.imgThree.TabStop = false;
            this.imgThree.Click += new System.EventHandler(this.imgThree_Click);
            // 
            // imgTwo
            // 
            this.imgTwo.Image = global::Card_Identifier.Properties.Resources._5_Clubs;
            this.imgTwo.Location = new System.Drawing.Point(146, 12);
            this.imgTwo.Name = "imgTwo";
            this.imgTwo.Size = new System.Drawing.Size(124, 180);
            this.imgTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTwo.TabIndex = 3;
            this.imgTwo.TabStop = false;
            this.imgTwo.Click += new System.EventHandler(this.imgTwo_Click);
            // 
            // imgFour
            // 
            this.imgFour.Image = global::Card_Identifier.Properties.Resources.Jack_Diamonds;
            this.imgFour.Location = new System.Drawing.Point(406, 12);
            this.imgFour.Name = "imgFour";
            this.imgFour.Size = new System.Drawing.Size(124, 180);
            this.imgFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFour.TabIndex = 4;
            this.imgFour.TabStop = false;
            this.imgFour.Click += new System.EventHandler(this.imgFour_Click);
            // 
            // imgFive
            // 
            this.imgFive.Image = global::Card_Identifier.Properties.Resources.Joker_Black;
            this.imgFive.Location = new System.Drawing.Point(536, 12);
            this.imgFive.Name = "imgFive";
            this.imgFive.Size = new System.Drawing.Size(124, 180);
            this.imgFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFive.TabIndex = 5;
            this.imgFive.TabStop = false;
            this.imgFive.Click += new System.EventHandler(this.imgFive_Click);
            // 
            // labelCardName
            // 
            this.labelCardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCardName.Location = new System.Drawing.Point(146, 221);
            this.labelCardName.Name = "labelCardName";
            this.labelCardName.Size = new System.Drawing.Size(384, 23);
            this.labelCardName.TabIndex = 6;
            this.labelCardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(256, 199);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(163, 13);
            this.labelInstruction.TabIndex = 7;
            this.labelInstruction.Text = "Click On a Card to See Its Name!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 260);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.labelCardName);
            this.Controls.Add(this.imgFive);
            this.Controls.Add(this.imgFour);
            this.Controls.Add(this.imgTwo);
            this.Controls.Add(this.imgThree);
            this.Controls.Add(this.imgOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOne;
        private System.Windows.Forms.PictureBox imgThree;
        private System.Windows.Forms.PictureBox imgTwo;
        private System.Windows.Forms.PictureBox imgFour;
        private System.Windows.Forms.PictureBox imgFive;
        private System.Windows.Forms.Label labelCardName;
        private System.Windows.Forms.Label labelInstruction;
    }
}

