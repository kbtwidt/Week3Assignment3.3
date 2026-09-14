namespace Week3Assignment3._3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Admin" && txtPassword.Text == "P@ssw0rd")
            {
                MessageBox.Show("Login Successful");
                StudentDatabase studentDatabase = new StudentDatabase();
                studentDatabase.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }
    }
}
