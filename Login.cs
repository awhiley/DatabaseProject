namespace DatabaseProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void GreetingText_Click(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
           string username = UsernameBox.Text;

            /*if (username == database call) {

            }*/
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            string password = PasswordBox.Text;

            /*if (username == database call) {

            }*/
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword Forgot = new ForgotPassword();
            Forgot.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateAccButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount Create = new CreateAccount();
            Create.Show();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInterface User = new UserInterface();
            /*if(User and Pass == Database) {
                User.Show();
            }*/
        }
    }
}