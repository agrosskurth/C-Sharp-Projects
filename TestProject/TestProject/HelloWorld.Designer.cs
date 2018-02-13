namespace TestProject
{
    partial class HelloWorld
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
            this.btnHello = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHello.Location = new System.Drawing.Point(85, 38);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(100, 23);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Display Name!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(85, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(82, 90);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Enter your first name.";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // picBackground
            // 
            this.picBackground.Image = global::TestProject.Properties.Resources._1968081;
            this.picBackground.Location = new System.Drawing.Point(85, 125);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(100, 50);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 4;
            this.picBackground.TabStop = false;
            this.picBackground.Click += new System.EventHandler(this.picBackground_Click);
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picBackground);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnHello);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "HelloWorld";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HelloWorld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.PictureBox picBackground;
    }
}

