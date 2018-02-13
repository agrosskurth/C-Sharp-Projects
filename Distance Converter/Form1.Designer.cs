namespace Distance_Converter
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
            this.gBoxFrom = new System.Windows.Forms.GroupBox();
            this.radioButtonFromYards = new System.Windows.Forms.RadioButton();
            this.radioButtonFromFeet = new System.Windows.Forms.RadioButton();
            this.radioButtonFromInches = new System.Windows.Forms.RadioButton();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.Directions = new System.Windows.Forms.Label();
            this.gBoxTo = new System.Windows.Forms.GroupBox();
            this.radioButtonToYards = new System.Windows.Forms.RadioButton();
            this.radioButtonToFeet = new System.Windows.Forms.RadioButton();
            this.radioButtonToInches = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.gBoxFrom.SuspendLayout();
            this.gBoxTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxFrom
            // 
            this.gBoxFrom.Controls.Add(this.radioButtonFromYards);
            this.gBoxFrom.Controls.Add(this.radioButtonFromFeet);
            this.gBoxFrom.Controls.Add(this.radioButtonFromInches);
            this.gBoxFrom.Location = new System.Drawing.Point(12, 63);
            this.gBoxFrom.Name = "gBoxFrom";
            this.gBoxFrom.Size = new System.Drawing.Size(100, 100);
            this.gBoxFrom.TabIndex = 0;
            this.gBoxFrom.TabStop = false;
            this.gBoxFrom.Text = "groupBox1";
            // 
            // radioButtonFromYards
            // 
            this.radioButtonFromYards.AutoSize = true;
            this.radioButtonFromYards.Location = new System.Drawing.Point(6, 65);
            this.radioButtonFromYards.Name = "radioButtonFromYards";
            this.radioButtonFromYards.Size = new System.Drawing.Size(52, 17);
            this.radioButtonFromYards.TabIndex = 3;
            this.radioButtonFromYards.TabStop = true;
            this.radioButtonFromYards.Text = "Yards";
            this.radioButtonFromYards.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromFeet
            // 
            this.radioButtonFromFeet.AutoSize = true;
            this.radioButtonFromFeet.Location = new System.Drawing.Point(6, 42);
            this.radioButtonFromFeet.Name = "radioButtonFromFeet";
            this.radioButtonFromFeet.Size = new System.Drawing.Size(46, 17);
            this.radioButtonFromFeet.TabIndex = 2;
            this.radioButtonFromFeet.TabStop = true;
            this.radioButtonFromFeet.Text = "Feet";
            this.radioButtonFromFeet.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromInches
            // 
            this.radioButtonFromInches.AutoSize = true;
            this.radioButtonFromInches.Location = new System.Drawing.Point(6, 19);
            this.radioButtonFromInches.Name = "radioButtonFromInches";
            this.radioButtonFromInches.Size = new System.Drawing.Size(57, 17);
            this.radioButtonFromInches.TabIndex = 1;
            this.radioButtonFromInches.TabStop = true;
            this.radioButtonFromInches.Text = "Inches";
            this.radioButtonFromInches.UseVisualStyleBackColor = true;
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(150, 16);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(100, 20);
            this.txtUserInput.TabIndex = 0;
            // 
            // Directions
            // 
            this.Directions.AutoSize = true;
            this.Directions.Location = new System.Drawing.Point(12, 19);
            this.Directions.Name = "Directions";
            this.Directions.Size = new System.Drawing.Size(138, 13);
            this.Directions.TabIndex = 1;
            this.Directions.Text = "Enter a distance to convert:";
            // 
            // gBoxTo
            // 
            this.gBoxTo.Controls.Add(this.radioButtonToYards);
            this.gBoxTo.Controls.Add(this.radioButtonToFeet);
            this.gBoxTo.Controls.Add(this.radioButtonToInches);
            this.gBoxTo.Location = new System.Drawing.Point(150, 63);
            this.gBoxTo.Name = "gBoxTo";
            this.gBoxTo.Size = new System.Drawing.Size(100, 100);
            this.gBoxTo.TabIndex = 4;
            this.gBoxTo.TabStop = false;
            this.gBoxTo.Text = "To:";
            // 
            // radioButtonToYards
            // 
            this.radioButtonToYards.AutoSize = true;
            this.radioButtonToYards.Location = new System.Drawing.Point(6, 65);
            this.radioButtonToYards.Name = "radioButtonToYards";
            this.radioButtonToYards.Size = new System.Drawing.Size(52, 17);
            this.radioButtonToYards.TabIndex = 3;
            this.radioButtonToYards.TabStop = true;
            this.radioButtonToYards.Text = "Yards";
            this.radioButtonToYards.UseVisualStyleBackColor = true;
            // 
            // radioButtonToFeet
            // 
            this.radioButtonToFeet.AutoSize = true;
            this.radioButtonToFeet.Location = new System.Drawing.Point(6, 42);
            this.radioButtonToFeet.Name = "radioButtonToFeet";
            this.radioButtonToFeet.Size = new System.Drawing.Size(46, 17);
            this.radioButtonToFeet.TabIndex = 2;
            this.radioButtonToFeet.TabStop = true;
            this.radioButtonToFeet.Text = "Feet";
            this.radioButtonToFeet.UseVisualStyleBackColor = true;
            // 
            // radioButtonToInches
            // 
            this.radioButtonToInches.AutoSize = true;
            this.radioButtonToInches.Location = new System.Drawing.Point(6, 19);
            this.radioButtonToInches.Name = "radioButtonToInches";
            this.radioButtonToInches.Size = new System.Drawing.Size(57, 17);
            this.radioButtonToInches.TabIndex = 1;
            this.radioButtonToInches.TabStop = true;
            this.radioButtonToInches.Text = "Inches";
            this.radioButtonToInches.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(37, 221);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(150, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutput.Location = new System.Drawing.Point(96, 166);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(70, 40);
            this.labelOutput.TabIndex = 7;
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 256);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.gBoxTo);
            this.Controls.Add(this.Directions);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.gBoxFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBoxFrom.ResumeLayout(false);
            this.gBoxFrom.PerformLayout();
            this.gBoxTo.ResumeLayout(false);
            this.gBoxTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxFrom;
        private System.Windows.Forms.RadioButton radioButtonFromYards;
        private System.Windows.Forms.RadioButton radioButtonFromFeet;
        private System.Windows.Forms.RadioButton radioButtonFromInches;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Label Directions;
        private System.Windows.Forms.GroupBox gBoxTo;
        private System.Windows.Forms.RadioButton radioButtonToYards;
        private System.Windows.Forms.RadioButton radioButtonToFeet;
        private System.Windows.Forms.RadioButton radioButtonToInches;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelOutput;
    }
}

