namespace Week3Assignment3._3
{
    partial class StudentDatabase
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
            studentGrid = new DataGridView();
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)studentGrid).BeginInit();
            SuspendLayout();
            // 
            // studentGrid
            // 
            studentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGrid.Location = new Point(62, 12);
            studentGrid.Name = "studentGrid";
            studentGrid.RowHeadersWidth = 62;
            studentGrid.Size = new Size(1075, 250);
            studentGrid.TabIndex = 0;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(62, 291);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(191, 34);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Location = new Point(62, 355);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(191, 34);
            btnRemoveStudent.TabIndex = 2;
            btnRemoveStudent.Text = "Remove Student";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(946, 291);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(191, 34);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh View";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // StudentDatabase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 476);
            Controls.Add(btnRefresh);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(studentGrid);
            Name = "StudentDatabase";
            Text = "StudentDatabase";
            Load += StudentDatabase_Load;
            ((System.ComponentModel.ISupportInitialize)studentGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentGrid;
        private Button btnAddStudent;
        private Button btnRemoveStudent;
        private Button btnRefresh;
    }
}