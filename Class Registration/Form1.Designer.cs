namespace Class_Registration
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
            this.listBoxClasses = new System.Windows.Forms.ListBox();
            this.txtCRN = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtCampus = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.CRN = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.CourseName = new System.Windows.Forms.Label();
            this.Campus = new System.Windows.Forms.Label();
            this.Room = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Inatructor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxClasses
            // 
            this.listBoxClasses.FormattingEnabled = true;
            this.listBoxClasses.Location = new System.Drawing.Point(0, 0);
            this.listBoxClasses.Name = "listBoxClasses";
            this.listBoxClasses.Size = new System.Drawing.Size(971, 121);
            this.listBoxClasses.TabIndex = 0;
            // 
            // txtCRN
            // 
            this.txtCRN.Location = new System.Drawing.Point(12, 147);
            this.txtCRN.Name = "txtCRN";
            this.txtCRN.Size = new System.Drawing.Size(100, 20);
            this.txtCRN.TabIndex = 1;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(542, 147);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 20);
            this.txtRoom.TabIndex = 2;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(224, 147);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 3;
            // 
            // txtCampus
            // 
            this.txtCampus.Location = new System.Drawing.Point(436, 147);
            this.txtCampus.Name = "txtCampus";
            this.txtCampus.Size = new System.Drawing.Size(100, 20);
            this.txtCampus.TabIndex = 4;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(330, 147);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 20);
            this.txtCourseName.TabIndex = 5;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(754, 147);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 6;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(648, 147);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 7;
            // 
            // txtInstructor
            // 
            this.txtInstructor.Location = new System.Drawing.Point(860, 147);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(100, 20);
            this.txtInstructor.TabIndex = 8;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(118, 147);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.TabIndex = 9;
            // 
            // CRN
            // 
            this.CRN.AutoSize = true;
            this.CRN.Location = new System.Drawing.Point(43, 124);
            this.CRN.Name = "CRN";
            this.CRN.Size = new System.Drawing.Size(37, 13);
            this.CRN.TabIndex = 10;
            this.CRN.Text = "CRN#";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(138, 124);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(62, 13);
            this.Department.TabIndex = 11;
            this.Department.Text = "Department";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(253, 124);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(39, 13);
            this.Class.TabIndex = 12;
            this.Class.Text = "Class#";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(346, 124);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(71, 13);
            this.CourseName.TabIndex = 13;
            this.CourseName.Text = "Course Name";
            // 
            // Campus
            // 
            this.Campus.AutoSize = true;
            this.Campus.Location = new System.Drawing.Point(463, 124);
            this.Campus.Name = "Campus";
            this.Campus.Size = new System.Drawing.Size(45, 13);
            this.Campus.TabIndex = 14;
            this.Campus.Text = "Campus";
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Location = new System.Drawing.Point(571, 124);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(35, 13);
            this.Room.TabIndex = 15;
            this.Room.Text = "Room";
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Location = new System.Drawing.Point(679, 124);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(31, 13);
            this.Days.TabIndex = 16;
            this.Days.Text = "Days";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(788, 124);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 17;
            this.Time.Text = "Time";
            // 
            // Inatructor
            // 
            this.Inatructor.AutoSize = true;
            this.Inatructor.Location = new System.Drawing.Point(883, 124);
            this.Inatructor.Name = "Inatructor";
            this.Inatructor.Size = new System.Drawing.Size(51, 13);
            this.Inatructor.TabIndex = 18;
            this.Inatructor.Text = "Instructor";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(249, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(355, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(542, 191);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 21;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(648, 191);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 226);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Inatructor);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.Campus);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.CRN);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtInstructor);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCampus);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtCRN);
            this.Controls.Add(this.listBoxClasses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClasses;
        private System.Windows.Forms.TextBox txtCRN;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtCampus;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.Label Campus;
        private System.Windows.Forms.Label Room;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Inatructor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label CRN;
    }
}

