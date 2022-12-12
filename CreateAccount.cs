using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void BackCreateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Login = new LoginForm();
            Login.Show();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void EmailCreateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecretPromptBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SecretAnswerBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void UsernameCreateBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void CreateAccButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=PasswordManager;user=root;password=password1";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();



            //adding secret from user creation
            string query = "insert into secret ( secretprompt, secretanswer ) values ( '" + SecretPromptBox.Text + "' , '" + SecretAnswerBox.Text + "' )";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cmd.ExecuteNonQuery();

            //finding secret id we just added
            query = "select secret_id from secret where secretprompt = '" + SecretPromptBox.Text + "' AND secretanswer = '" + SecretAnswerBox.Text + "' ";
            cmd = new MySqlCommand(query, cnn);
            var temp = cmd.ExecuteScalar();

            //adding user to table with their secret id
            query = "insert into user (SECRET_ID, U_USERNAME, U_PASSWORD, U_EMAIL  ) values ( " + temp + ", '" + UsernameCreateBox.Text + "' , '" + PasswordCreateBox.Text + "' , '" + EmailCreateBox.Text + "' )";  
            cmd = new MySqlCommand(query, cnn);
            cmd.ExecuteNonQuery();


        }

        private void PasswordCreateBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
