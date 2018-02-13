namespace Retail_Price_Calculator
{
    partial class FormMain
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtWholesale = new System.Windows.Forms.TextBox();
            this.txtMarkup = new System.Windows.Forms.TextBox();
            this.Wholesale = new System.Windows.Forms.Label();
            this.Markup = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 170);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(117, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtWholesale
            // 
            this.txtWholesale.Location = new System.Drawing.Point(92, 79);
            this.txtWholesale.Name = "txtWholesale";
            this.txtWholesale.Size = new System.Drawing.Size(100, 20);
            this.txtWholesale.TabIndex = 2;
            // 
            // txtMarkup
            // 
            this.txtMarkup.Location = new System.Drawing.Point(92, 120);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.Size = new System.Drawing.Size(100, 20);
            this.txtMarkup.TabIndex = 3;
            // 
            // Wholesale
            // 
            this.Wholesale.AutoSize = true;
            this.Wholesale.Location = new System.Drawing.Point(9, 82);
            this.Wholesale.Name = "Wholesale";
            this.Wholesale.Size = new System.Drawing.Size(60, 13);
            this.Wholesale.TabIndex = 4;
            this.Wholesale.Text = "Wholesale:";
            // 
            // Markup
            // 
            this.Markup.AutoSize = true;
            this.Markup.Location = new System.Drawing.Point(23, 123);
            this.Markup.Name = "Markup";
            this.Markup.Size = new System.Drawing.Size(46, 13);
            this.Markup.TabIndex = 5;
            this.Markup.Text = "Markup:";
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotal.Location = new System.Drawing.Point(12, 9);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(180, 47);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 204);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.Markup);
            this.Controls.Add(this.Wholesale);
            this.Controls.Add(this.txtMarkup);
            this.Controls.Add(this.txtWholesale);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "FormMain";
            this.Text = "Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtWholesale;
        private System.Windows.Forms.TextBox txtMarkup;
        private System.Windows.Forms.Label Wholesale;
        private System.Windows.Forms.Label Markup;
        private System.Windows.Forms.Label labelTotal;
    }
}

