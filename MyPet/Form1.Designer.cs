namespace MyPet
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
            this.labelAge = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEnterData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(16, 90);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 13;
            this.labelAge.Text = "Age:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(11, 52);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Type:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(51, 87);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 10;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(51, 49);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // btnEnterData
            // 
            this.btnEnterData.Location = new System.Drawing.Point(64, 120);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(75, 23);
            this.btnEnterData.TabIndex = 7;
            this.btnEnterData.Text = "Enter Data!";
            this.btnEnterData.UseVisualStyleBackColor = true;
            this.btnEnterData.Click += new System.EventHandler(this.btnEnterData_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 154);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnEnterData);
            this.Name = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnEnterData;
    }
}

