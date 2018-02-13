namespace WindowsFormsApplication2
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
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.labelDirections = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(41, 25);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(100, 20);
            this.txtUserInput.TabIndex = 0;
            // 
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.Location = new System.Drawing.Point(12, 9);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(161, 13);
            this.labelDirections.TabIndex = 1;
            this.labelDirections.Text = "Enter how many you want to buy";
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotal.Location = new System.Drawing.Point(207, 92);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(70, 40);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(53, 106);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelDiscount
            // 
            this.labelDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDiscount.Location = new System.Drawing.Point(207, 25);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(70, 40);
            this.labelDiscount.TabIndex = 4;
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(217, 9);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(49, 13);
            this.Discount.TabIndex = 5;
            this.Discount.Text = "Discount";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(225, 79);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDirections);
            this.Controls.Add(this.txtUserInput);
            this.Name = "formMain";
            this.Text = "Software Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Label labelDirections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label Total;
    }
}

