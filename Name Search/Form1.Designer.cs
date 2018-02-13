namespace Name_Search
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
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelOutputBoy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelOutputGirl = new System.Windows.Forms.Label();
            this.txtGirl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(12, 120);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(100, 20);
            this.txtBoy.TabIndex = 0;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(61, 9);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(145, 39);
            this.labelInstructions.TabIndex = 1;
            this.labelInstructions.Text = "Search for a name to see if it \r\nwas one of the most popular\r\nnames from 2000 to " +
    "2009";
            // 
            // labelOutputBoy
            // 
            this.labelOutputBoy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutputBoy.Location = new System.Drawing.Point(16, 62);
            this.labelOutputBoy.Name = "labelOutputBoy";
            this.labelOutputBoy.Size = new System.Drawing.Size(92, 33);
            this.labelOutputBoy.TabIndex = 2;
            this.labelOutputBoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(24, 149);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(176, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // labelOutputGirl
            // 
            this.labelOutputGirl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutputGirl.Location = new System.Drawing.Point(168, 62);
            this.labelOutputGirl.Name = "labelOutputGirl";
            this.labelOutputGirl.Size = new System.Drawing.Size(92, 33);
            this.labelOutputGirl.TabIndex = 5;
            this.labelOutputGirl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGirl
            // 
            this.txtGirl.Location = new System.Drawing.Point(163, 120);
            this.txtGirl.Name = "txtGirl";
            this.txtGirl.Size = new System.Drawing.Size(100, 20);
            this.txtGirl.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 189);
            this.Controls.Add(this.txtGirl);
            this.Controls.Add(this.labelOutputGirl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelOutputBoy);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.txtBoy);
            this.Name = "FormMain";
            this.Text = "Name Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelOutputBoy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelOutputGirl;
        private System.Windows.Forms.TextBox txtGirl;
    }
}

