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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserInterface UI = new UserInterface();
            UI.Show();
        }
    }
}