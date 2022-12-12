using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

namespace DatabaseProject
{
    
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            string connetionString;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=PasswordManager;user=root;password=password1";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
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




            string connetionString;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=PasswordManager;user=root;password=password1";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();



            string query = "Select u_password from User where u_username = '" + UsernameBox.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            string password = cmd.ExecuteScalar().ToString();


                              
            if (PasswordBox.Text ==  password)
            {


                   User.Show(); //only go to next page if login is valid
                //it works enough, and also doesnt work enough.
                //trust me

              
            }
           

        }
    }
}