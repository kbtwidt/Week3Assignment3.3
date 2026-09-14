namespace Week3Assignment3._3
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeading = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Century Schoolbook", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(168, 14);
            lblHeading.Margin = new Padding(4, 0, 4, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(869, 71);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Student Administration Login";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Century Schoolbook", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(334, 135);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(180, 35);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Schoolbook", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(358, 195);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(156, 35);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(531, 138);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(353, 32);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(531, 198);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(353, 32);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Century Schoolbook", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(626, 250);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 59);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 394);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblHeading);
            Font = new Font("Century Schoolbook", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
