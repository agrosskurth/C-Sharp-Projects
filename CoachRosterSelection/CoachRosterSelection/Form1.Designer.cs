namespace CoachRosterSelection
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
            this.listPlayerRoster = new System.Windows.Forms.ListBox();
            this.txtPlayerInput = new System.Windows.Forms.TextBox();
            this.btnConfirmEntry = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelDirections = new System.Windows.Forms.Label();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.labelRosterCorrect = new System.Windows.Forms.Label();
            this.btnClearListbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPlayerRoster
            // 
            this.listPlayerRoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPlayerRoster.FormattingEnabled = true;
            this.listPlayerRoster.Location = new System.Drawing.Point(152, 12);
            this.listPlayerRoster.Name = "listPlayerRoster";
            this.listPlayerRoster.Size = new System.Drawing.Size(120, 158);
            this.listPlayerRoster.TabIndex = 0;
            this.listPlayerRoster.SelectedIndexChanged += new System.EventHandler(this.listPlayerRoster_SelectedIndexChanged);
            // 
            // txtPlayerInput
            // 
            this.txtPlayerInput.Location = new System.Drawing.Point(12, 25);
            this.txtPlayerInput.Name = "txtPlayerInput";
            this.txtPlayerInput.Size = new System.Drawing.Size(134, 20);
            this.txtPlayerInput.TabIndex = 1;
            // 
            // btnConfirmEntry
            // 
            this.btnConfirmEntry.Location = new System.Drawing.Point(36, 51);
            this.btnConfirmEntry.Name = "btnConfirmEntry";
            this.btnConfirmEntry.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmEntry.TabIndex = 2;
            this.btnConfirmEntry.Text = "Enter Player";
            this.btnConfirmEntry.UseVisualStyleBackColor = true;
            this.btnConfirmEntry.Click += new System.EventHandler(this.btnConfirmEntry_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(33, 146);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Roster";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.Location = new System.Drawing.Point(27, 9);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(103, 13);
            this.labelDirections.TabIndex = 4;
            this.labelDirections.Text = "Enter Player Names.";
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.Location = new System.Drawing.Point(26, 123);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(43, 17);
            this.radioBtnYes.TabIndex = 5;
            this.radioBtnYes.TabStop = true;
            this.radioBtnYes.Text = "Yes";
            this.radioBtnYes.UseVisualStyleBackColor = true;
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Location = new System.Drawing.Point(91, 123);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(39, 17);
            this.radioBtnNo.TabIndex = 6;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "No";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            // 
            // labelRosterCorrect
            // 
            this.labelRosterCorrect.AutoSize = true;
            this.labelRosterCorrect.Location = new System.Drawing.Point(23, 95);
            this.labelRosterCorrect.Name = "labelRosterCorrect";
            this.labelRosterCorrect.Size = new System.Drawing.Size(110, 13);
            this.labelRosterCorrect.TabIndex = 7;
            this.labelRosterCorrect.Text = "Is the Roster Correct?";
            // 
            // btnClearListbox
            // 
            this.btnClearListbox.Location = new System.Drawing.Point(103, 176);
            this.btnClearListbox.Name = "btnClearListbox";
            this.btnClearListbox.Size = new System.Drawing.Size(75, 23);
            this.btnClearListbox.TabIndex = 8;
            this.btnClearListbox.Text = "Clear Roster";
            this.btnClearListbox.UseVisualStyleBackColor = true;
            this.btnClearListbox.Click += new System.EventHandler(this.btnClearListbox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.btnClearListbox);
            this.Controls.Add(this.labelRosterCorrect);
            this.Controls.Add(this.radioBtnNo);
            this.Controls.Add(this.radioBtnYes);
            this.Controls.Add(this.labelDirections);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnConfirmEntry);
            this.Controls.Add(this.txtPlayerInput);
            this.Controls.Add(this.listPlayerRoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPlayerRoster;
        private System.Windows.Forms.TextBox txtPlayerInput;
        private System.Windows.Forms.Button btnConfirmEntry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelDirections;
        private System.Windows.Forms.RadioButton radioBtnYes;
        private System.Windows.Forms.RadioButton radioBtnNo;
        private System.Windows.Forms.Label labelRosterCorrect;
        private System.Windows.Forms.Button btnClearListbox;
    }
}

