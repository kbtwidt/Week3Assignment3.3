namespace Week3Assignment3._3
{
    partial class AddForm
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
            txtStudentID = new TextBox();
            lblStudentID = new Label();
            lblStudentFName = new Label();
            lblStudentLName = new Label();
            lblAddress = new Label();
            lblAdmission = new Label();
            lblGrade = new Label();
            txtStudentFName = new TextBox();
            txtStudentLName = new TextBox();
            txtAddress = new TextBox();
            txtGrade = new TextBox();
            cmbAdmission = new ComboBox();
            btnAddStudent = new Button();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(297, 44);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(292, 31);
            txtStudentID.TabIndex = 0;
            txtStudentID.Validating += txtStudentID_Validating;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(191, 50);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(100, 25);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "Student ID:";
            // 
            // lblStudentFName
            // 
            lblStudentFName.AutoSize = true;
            lblStudentFName.Location = new Point(124, 100);
            lblStudentFName.Name = "lblStudentFName";
            lblStudentFName.Size = new Size(167, 25);
            lblStudentFName.TabIndex = 2;
            lblStudentFName.Text = "Student First Name:";
            // 
            // lblStudentLName
            // 
            lblStudentLName.AutoSize = true;
            lblStudentLName.Location = new Point(126, 150);
            lblStudentLName.Name = "lblStudentLName";
            lblStudentLName.Size = new Size(165, 25);
            lblStudentLName.TabIndex = 3;
            lblStudentLName.Text = "Student Last Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(94, 200);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(197, 25);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Student Street Address:";
            // 
            // lblAdmission
            // 
            lblAdmission.AutoSize = true;
            lblAdmission.Location = new Point(67, 250);
            lblAdmission.Name = "lblAdmission";
            lblAdmission.Size = new Size(224, 25);
            lblAdmission.TabIndex = 5;
            lblAdmission.Text = "Student Admission Month:";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(162, 300);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(129, 25);
            lblGrade.TabIndex = 6;
            lblGrade.Text = "Student Grade:";
            // 
            // txtStudentFName
            // 
            txtStudentFName.Location = new Point(297, 94);
            txtStudentFName.Name = "txtStudentFName";
            txtStudentFName.Size = new Size(292, 31);
            txtStudentFName.TabIndex = 7;
            // 
            // txtStudentLName
            // 
            txtStudentLName.Location = new Point(297, 144);
            txtStudentLName.Name = "txtStudentLName";
            txtStudentLName.Size = new Size(292, 31);
            txtStudentLName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(297, 194);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(292, 31);
            txtAddress.TabIndex = 9;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(297, 294);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(292, 31);
            txtGrade.TabIndex = 10;
            // 
            // cmbAdmission
            // 
            cmbAdmission.FormattingEnabled = true;
            cmbAdmission.Location = new Point(297, 242);
            cmbAdmission.Name = "cmbAdmission";
            cmbAdmission.Size = new Size(292, 33);
            cmbAdmission.TabIndex = 11;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(297, 350);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(205, 34);
            btnAddStudent.TabIndex = 12;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddStudent);
            Controls.Add(cmbAdmission);
            Controls.Add(txtGrade);
            Controls.Add(txtAddress);
            Controls.Add(txtStudentLName);
            Controls.Add(txtStudentFName);
            Controls.Add(lblGrade);
            Controls.Add(lblAdmission);
            Controls.Add(lblAddress);
            Controls.Add(lblStudentLName);
            Controls.Add(lblStudentFName);
            Controls.Add(lblStudentID);
            Controls.Add(txtStudentID);
            Name = "AddForm";
            Text = "Add Student";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private Label lblStudentID;
        private Label lblStudentFName;
        private Label lblStudentLName;
        private Label lblAddress;
        private Label lblAdmission;
        private Label lblGrade;
        private TextBox txtStudentFName;
        private TextBox txtStudentLName;
        private TextBox txtAddress;
        private TextBox txtGrade;
        private ComboBox cmbAdmission;
        private Button btnAddStudent;
    }
}