namespace Clickable_Number_Images
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
            this.imgFive = new System.Windows.Forms.PictureBox();
            this.imgFour = new System.Windows.Forms.PictureBox();
            this.imgThree = new System.Windows.Forms.PictureBox();
            this.imgOne = new System.Windows.Forms.PictureBox();
            this.imgTwo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFive
            // 
            this.imgFive.Image = global::Clickable_Number_Images.Properties.Resources.Five;
            this.imgFive.Location = new System.Drawing.Point(356, 12);
            this.imgFive.Name = "imgFive";
            this.imgFive.Size = new System.Drawing.Size(80, 144);
            this.imgFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgFive.TabIndex = 4;
            this.imgFive.TabStop = false;
            this.imgFive.Click += new System.EventHandler(this.imgFive_Click);
            // 
            // imgFour
            // 
            this.imgFour.Image = global::Clickable_Number_Images.Properties.Resources.Four;
            this.imgFour.Location = new System.Drawing.Point(270, 12);
            this.imgFour.Name = "imgFour";
            this.imgFour.Size = new System.Drawing.Size(80, 144);
            this.imgFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgFour.TabIndex = 3;
            this.imgFour.TabStop = false;
            this.imgFour.Click += new System.EventHandler(this.imgFour_Click);
            // 
            // imgThree
            // 
            this.imgThree.Image = global::Clickable_Number_Images.Properties.Resources.Three;
            this.imgThree.Location = new System.Drawing.Point(184, 12);
            this.imgThree.Name = "imgThree";
            this.imgThree.Size = new System.Drawing.Size(80, 144);
            this.imgThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgThree.TabIndex = 2;
            this.imgThree.TabStop = false;
            this.imgThree.Click += new System.EventHandler(this.imgThree_Click);
            // 
            // imgOne
            // 
            this.imgOne.Image = global::Clickable_Number_Images.Properties.Resources.One;
            this.imgOne.Location = new System.Drawing.Point(12, 12);
            this.imgOne.Name = "imgOne";
            this.imgOne.Size = new System.Drawing.Size(80, 144);
            this.imgOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgOne.TabIndex = 0;
            this.imgOne.TabStop = false;
            this.imgOne.Click += new System.EventHandler(this.imgOne_Click);
            // 
            // imgTwo
            // 
            this.imgTwo.Image = global::Clickable_Number_Images.Properties.Resources.Two;
            this.imgTwo.Location = new System.Drawing.Point(98, 12);
            this.imgTwo.Name = "imgTwo";
            this.imgTwo.Size = new System.Drawing.Size(80, 144);
            this.imgTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgTwo.TabIndex = 5;
            this.imgTwo.TabStop = false;
            this.imgTwo.Click += new System.EventHandler(this.imgTwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 173);
            this.Controls.Add(this.imgTwo);
            this.Controls.Add(this.imgFive);
            this.Controls.Add(this.imgFour);
            this.Controls.Add(this.imgThree);
            this.Controls.Add(this.imgOne);
            this.Name = "Form1";
            this.Text = "Clickable Number Images";
            ((System.ComponentModel.ISupportInitialize)(this.imgFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOne;
        private System.Windows.Forms.PictureBox imgThree;
        private System.Windows.Forms.PictureBox imgFour;
        private System.Windows.Forms.PictureBox imgFive;
        private System.Windows.Forms.PictureBox imgTwo;
    }
}

