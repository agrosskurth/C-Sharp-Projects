namespace labTwoCalculator
{
    partial class mainForm
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
            this.txtInputOne = new System.Windows.Forms.TextBox();
            this.txtInputTwo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputOne
            // 
            this.txtInputOne.Location = new System.Drawing.Point(12, 27);
            this.txtInputOne.MaxLength = 15;
            this.txtInputOne.Name = "txtInputOne";
            this.txtInputOne.Size = new System.Drawing.Size(100, 20);
            this.txtInputOne.TabIndex = 0;
            this.txtInputOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInputTwo
            // 
            this.txtInputTwo.Location = new System.Drawing.Point(172, 27);
            this.txtInputTwo.MaxLength = 15;
            this.txtInputTwo.Name = "txtInputTwo";
            this.txtInputTwo.Size = new System.Drawing.Size(100, 20);
            this.txtInputTwo.TabIndex = 1;
            this.txtInputTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(104, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAnswer.Location = new System.Drawing.Point(12, 9);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(260, 15);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(104, 82);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 4;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(104, 111);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.AutoSize = true;
            this.btnDivide.Location = new System.Drawing.Point(104, 140);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(125, 27);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(34, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInputTwo);
            this.Controls.Add(this.txtInputOne);
            this.Name = "mainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputOne;
        private System.Windows.Forms.TextBox txtInputTwo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnReset;
    }
}

