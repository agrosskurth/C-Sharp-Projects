namespace Joe_s_Automotive
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
            this.groupOilAndLube = new System.Windows.Forms.GroupBox();
            this.chkBoxLube = new System.Windows.Forms.CheckBox();
            this.chkBoxOil = new System.Windows.Forms.CheckBox();
            this.groupMisc = new System.Windows.Forms.GroupBox();
            this.chkBoxTireRotation = new System.Windows.Forms.CheckBox();
            this.chkBoxMuffler = new System.Windows.Forms.CheckBox();
            this.chkBoxInspection = new System.Windows.Forms.CheckBox();
            this.groupPartsAndLabor = new System.Windows.Forms.GroupBox();
            this.Labor = new System.Windows.Forms.Label();
            this.Parts1 = new System.Windows.Forms.Label();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.groupFlushes = new System.Windows.Forms.GroupBox();
            this.chkBoxTransmission = new System.Windows.Forms.CheckBox();
            this.chkBoxRadiator = new System.Windows.Forms.CheckBox();
            this.groupSummary = new System.Windows.Forms.GroupBox();
            this.labelTotalFees = new System.Windows.Forms.Label();
            this.labelTaxOnParts = new System.Windows.Forms.Label();
            this.labelParts = new System.Windows.Forms.Label();
            this.labelServicesAndLabor = new System.Windows.Forms.Label();
            this.TotalFees = new System.Windows.Forms.Label();
            this.TaxOnParts = new System.Windows.Forms.Label();
            this.Parts2 = new System.Windows.Forms.Label();
            this.ServicesAndLabor = new System.Windows.Forms.Label();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupOilAndLube.SuspendLayout();
            this.groupMisc.SuspendLayout();
            this.groupPartsAndLabor.SuspendLayout();
            this.groupFlushes.SuspendLayout();
            this.groupSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupOilAndLube
            // 
            this.groupOilAndLube.Controls.Add(this.chkBoxLube);
            this.groupOilAndLube.Controls.Add(this.chkBoxOil);
            this.groupOilAndLube.Location = new System.Drawing.Point(12, 12);
            this.groupOilAndLube.Name = "groupOilAndLube";
            this.groupOilAndLube.Size = new System.Drawing.Size(200, 81);
            this.groupOilAndLube.TabIndex = 0;
            this.groupOilAndLube.TabStop = false;
            this.groupOilAndLube.Text = "Oil and Lube";
            // 
            // chkBoxLube
            // 
            this.chkBoxLube.AutoSize = true;
            this.chkBoxLube.Location = new System.Drawing.Point(14, 47);
            this.chkBoxLube.Name = "chkBoxLube";
            this.chkBoxLube.Size = new System.Drawing.Size(112, 17);
            this.chkBoxLube.TabIndex = 1;
            this.chkBoxLube.Text = "Lube Job ($18.00)";
            this.chkBoxLube.UseVisualStyleBackColor = true;
            // 
            // chkBoxOil
            // 
            this.chkBoxOil.AutoSize = true;
            this.chkBoxOil.Location = new System.Drawing.Point(14, 19);
            this.chkBoxOil.Name = "chkBoxOil";
            this.chkBoxOil.Size = new System.Drawing.Size(119, 17);
            this.chkBoxOil.TabIndex = 0;
            this.chkBoxOil.Text = "Oil change ($26.00)";
            this.chkBoxOil.UseVisualStyleBackColor = true;
            // 
            // groupMisc
            // 
            this.groupMisc.Controls.Add(this.chkBoxTireRotation);
            this.groupMisc.Controls.Add(this.chkBoxMuffler);
            this.groupMisc.Controls.Add(this.chkBoxInspection);
            this.groupMisc.Location = new System.Drawing.Point(12, 99);
            this.groupMisc.Name = "groupMisc";
            this.groupMisc.Size = new System.Drawing.Size(200, 158);
            this.groupMisc.TabIndex = 1;
            this.groupMisc.TabStop = false;
            this.groupMisc.Text = "Misc";
            // 
            // chkBoxTireRotation
            // 
            this.chkBoxTireRotation.AutoSize = true;
            this.chkBoxTireRotation.Location = new System.Drawing.Point(14, 107);
            this.chkBoxTireRotation.Name = "chkBoxTireRotation";
            this.chkBoxTireRotation.Size = new System.Drawing.Size(87, 30);
            this.chkBoxTireRotation.TabIndex = 6;
            this.chkBoxTireRotation.Text = "Tire Rotation\r\n($20.00)";
            this.chkBoxTireRotation.UseVisualStyleBackColor = true;
            // 
            // chkBoxMuffler
            // 
            this.chkBoxMuffler.AutoSize = true;
            this.chkBoxMuffler.Location = new System.Drawing.Point(14, 56);
            this.chkBoxMuffler.Name = "chkBoxMuffler";
            this.chkBoxMuffler.Size = new System.Drawing.Size(101, 30);
            this.chkBoxMuffler.TabIndex = 5;
            this.chkBoxMuffler.Text = "Replace Muffler\r\n($100.00)";
            this.chkBoxMuffler.UseVisualStyleBackColor = true;
            // 
            // chkBoxInspection
            // 
            this.chkBoxInspection.AutoSize = true;
            this.chkBoxInspection.Location = new System.Drawing.Point(14, 19);
            this.chkBoxInspection.Name = "chkBoxInspection";
            this.chkBoxInspection.Size = new System.Drawing.Size(117, 17);
            this.chkBoxInspection.TabIndex = 4;
            this.chkBoxInspection.Text = "Inspection ($15.00)";
            this.chkBoxInspection.UseVisualStyleBackColor = true;
            // 
            // groupPartsAndLabor
            // 
            this.groupPartsAndLabor.Controls.Add(this.label1);
            this.groupPartsAndLabor.Controls.Add(this.Labor);
            this.groupPartsAndLabor.Controls.Add(this.Parts1);
            this.groupPartsAndLabor.Controls.Add(this.txtLabor);
            this.groupPartsAndLabor.Controls.Add(this.txtParts);
            this.groupPartsAndLabor.Location = new System.Drawing.Point(218, 99);
            this.groupPartsAndLabor.Name = "groupPartsAndLabor";
            this.groupPartsAndLabor.Size = new System.Drawing.Size(200, 158);
            this.groupPartsAndLabor.TabIndex = 1;
            this.groupPartsAndLabor.TabStop = false;
            this.groupPartsAndLabor.Text = "Parts and Labor";
            // 
            // Labor
            // 
            this.Labor.AutoSize = true;
            this.Labor.Location = new System.Drawing.Point(31, 107);
            this.Labor.Name = "Labor";
            this.Labor.Size = new System.Drawing.Size(49, 13);
            this.Labor.TabIndex = 10;
            this.Labor.Text = "Labor($):";
            // 
            // Parts1
            // 
            this.Parts1.AutoSize = true;
            this.Parts1.Location = new System.Drawing.Point(46, 69);
            this.Parts1.Name = "Parts1";
            this.Parts1.Size = new System.Drawing.Size(34, 13);
            this.Parts1.TabIndex = 9;
            this.Parts1.Text = "Parts:";
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(86, 104);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(64, 20);
            this.txtLabor.TabIndex = 8;
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(86, 66);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(64, 20);
            this.txtParts.TabIndex = 7;
            // 
            // groupFlushes
            // 
            this.groupFlushes.Controls.Add(this.chkBoxTransmission);
            this.groupFlushes.Controls.Add(this.chkBoxRadiator);
            this.groupFlushes.Location = new System.Drawing.Point(218, 12);
            this.groupFlushes.Name = "groupFlushes";
            this.groupFlushes.Size = new System.Drawing.Size(200, 81);
            this.groupFlushes.TabIndex = 1;
            this.groupFlushes.TabStop = false;
            this.groupFlushes.Text = "Flushes";
            // 
            // chkBoxTransmission
            // 
            this.chkBoxTransmission.AutoSize = true;
            this.chkBoxTransmission.Location = new System.Drawing.Point(15, 47);
            this.chkBoxTransmission.Name = "chkBoxTransmission";
            this.chkBoxTransmission.Size = new System.Drawing.Size(154, 17);
            this.chkBoxTransmission.TabIndex = 3;
            this.chkBoxTransmission.Text = "Transmission flush ($80.00)";
            this.chkBoxTransmission.UseVisualStyleBackColor = true;
            // 
            // chkBoxRadiator
            // 
            this.chkBoxRadiator.AutoSize = true;
            this.chkBoxRadiator.Location = new System.Drawing.Point(15, 19);
            this.chkBoxRadiator.Name = "chkBoxRadiator";
            this.chkBoxRadiator.Size = new System.Drawing.Size(136, 17);
            this.chkBoxRadiator.TabIndex = 2;
            this.chkBoxRadiator.Text = "Radiator Flush ($30.00)";
            this.chkBoxRadiator.UseVisualStyleBackColor = true;
            // 
            // groupSummary
            // 
            this.groupSummary.Controls.Add(this.labelTotalFees);
            this.groupSummary.Controls.Add(this.labelTaxOnParts);
            this.groupSummary.Controls.Add(this.labelParts);
            this.groupSummary.Controls.Add(this.labelServicesAndLabor);
            this.groupSummary.Controls.Add(this.TotalFees);
            this.groupSummary.Controls.Add(this.TaxOnParts);
            this.groupSummary.Controls.Add(this.Parts2);
            this.groupSummary.Controls.Add(this.ServicesAndLabor);
            this.groupSummary.Location = new System.Drawing.Point(12, 263);
            this.groupSummary.Name = "groupSummary";
            this.groupSummary.Size = new System.Drawing.Size(406, 145);
            this.groupSummary.TabIndex = 2;
            this.groupSummary.TabStop = false;
            this.groupSummary.Text = "Summary";
            // 
            // labelTotalFees
            // 
            this.labelTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalFees.Location = new System.Drawing.Point(146, 113);
            this.labelTotalFees.Name = "labelTotalFees";
            this.labelTotalFees.Size = new System.Drawing.Size(122, 15);
            this.labelTotalFees.TabIndex = 18;
            // 
            // labelTaxOnParts
            // 
            this.labelTaxOnParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTaxOnParts.Location = new System.Drawing.Point(146, 88);
            this.labelTaxOnParts.Name = "labelTaxOnParts";
            this.labelTaxOnParts.Size = new System.Drawing.Size(122, 15);
            this.labelTaxOnParts.TabIndex = 17;
            // 
            // labelParts
            // 
            this.labelParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelParts.Location = new System.Drawing.Point(146, 63);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(122, 15);
            this.labelParts.TabIndex = 16;
            // 
            // labelServicesAndLabor
            // 
            this.labelServicesAndLabor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelServicesAndLabor.Location = new System.Drawing.Point(146, 38);
            this.labelServicesAndLabor.Name = "labelServicesAndLabor";
            this.labelServicesAndLabor.Size = new System.Drawing.Size(122, 15);
            this.labelServicesAndLabor.TabIndex = 15;
            // 
            // TotalFees
            // 
            this.TotalFees.AutoSize = true;
            this.TotalFees.Location = new System.Drawing.Point(80, 113);
            this.TotalFees.Name = "TotalFees";
            this.TotalFees.Size = new System.Drawing.Size(60, 13);
            this.TotalFees.TabIndex = 14;
            this.TotalFees.Text = "Total Fees:";
            // 
            // TaxOnParts
            // 
            this.TaxOnParts.AutoSize = true;
            this.TaxOnParts.Location = new System.Drawing.Point(70, 88);
            this.TaxOnParts.Name = "TaxOnParts";
            this.TaxOnParts.Size = new System.Drawing.Size(70, 13);
            this.TaxOnParts.TabIndex = 13;
            this.TaxOnParts.Text = "Tax on Parts:";
            // 
            // Parts2
            // 
            this.Parts2.AutoSize = true;
            this.Parts2.Location = new System.Drawing.Point(106, 63);
            this.Parts2.Name = "Parts2";
            this.Parts2.Size = new System.Drawing.Size(34, 13);
            this.Parts2.TabIndex = 12;
            this.Parts2.Text = "Parts:";
            // 
            // ServicesAndLabor
            // 
            this.ServicesAndLabor.AutoSize = true;
            this.ServicesAndLabor.Location = new System.Drawing.Point(38, 38);
            this.ServicesAndLabor.Name = "ServicesAndLabor";
            this.ServicesAndLabor.Size = new System.Drawing.Size(102, 13);
            this.ServicesAndLabor.TabIndex = 11;
            this.ServicesAndLabor.Text = "Services and Labor:";
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Location = new System.Drawing.Point(12, 414);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(119, 28);
            this.btnCalculateTotal.TabIndex = 3;
            this.btnCalculateTotal.Text = "Calculate Total";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(156, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 28);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(299, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter 0 if nothing \r\nin these fields";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 454);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.groupSummary);
            this.Controls.Add(this.groupPartsAndLabor);
            this.Controls.Add(this.groupFlushes);
            this.Controls.Add(this.groupMisc);
            this.Controls.Add(this.groupOilAndLube);
            this.Name = "FormMain";
            this.Text = "Joe\'s Automotive";
            this.groupOilAndLube.ResumeLayout(false);
            this.groupOilAndLube.PerformLayout();
            this.groupMisc.ResumeLayout(false);
            this.groupMisc.PerformLayout();
            this.groupPartsAndLabor.ResumeLayout(false);
            this.groupPartsAndLabor.PerformLayout();
            this.groupFlushes.ResumeLayout(false);
            this.groupFlushes.PerformLayout();
            this.groupSummary.ResumeLayout(false);
            this.groupSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOilAndLube;
        private System.Windows.Forms.GroupBox groupMisc;
        private System.Windows.Forms.GroupBox groupPartsAndLabor;
        private System.Windows.Forms.GroupBox groupFlushes;
        private System.Windows.Forms.GroupBox groupSummary;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkBoxLube;
        private System.Windows.Forms.CheckBox chkBoxOil;
        private System.Windows.Forms.CheckBox chkBoxTireRotation;
        private System.Windows.Forms.CheckBox chkBoxMuffler;
        private System.Windows.Forms.CheckBox chkBoxInspection;
        private System.Windows.Forms.Label Labor;
        private System.Windows.Forms.Label Parts1;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.CheckBox chkBoxTransmission;
        private System.Windows.Forms.CheckBox chkBoxRadiator;
        private System.Windows.Forms.Label labelTotalFees;
        private System.Windows.Forms.Label labelTaxOnParts;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Label labelServicesAndLabor;
        private System.Windows.Forms.Label TotalFees;
        private System.Windows.Forms.Label TaxOnParts;
        private System.Windows.Forms.Label Parts2;
        private System.Windows.Forms.Label ServicesAndLabor;
        private System.Windows.Forms.Label label1;
    }
}

