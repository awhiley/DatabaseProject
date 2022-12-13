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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();



           
        }

        private void BackResetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Login = new LoginForm();
            Login.Show();
        }

        private void SecretQuestion_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void WhatIsUserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WhatIsUser_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=PasswordManager;user=root;password=password1";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();


            //finding secret question based on username and email
            string query = "select secretprompt from ( secret inner join user on secret.secret_id = user.secret_Id ) where user.u_username = '" + WhatIsUserBox.Text + "' AND user.U_email = '" + textBox2.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            string temp = cmd.ExecuteScalar().ToString();

            label1.Text = temp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitNewPass_Click(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=PasswordManager;user=root;password=password1";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            //displaying appropriate secret prompt
            string query = "select secretprompt from ( secret inner join user on secret.secret_id = user.secret_Id ) where user.u_username like '%" + WhatIsUserBox.Text + "%' AND user.U_email like '%" + textBox2.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            string temp = cmd.ExecuteScalar().ToString();
            label1.Text = temp;



            //finding appropriate secret answer to compare with user entry
            query = "select secretanswer from ( secret inner join user on secret.secret_id = user.secret_Id ) where user.u_username like '%" + WhatIsUserBox.Text + "%' AND user.U_email like '%" + textBox2.Text + "%'";
             cmd = new MySqlCommand(query, cnn);
            temp = cmd.ExecuteScalar().ToString();
            if (textBox1.Text == temp)
            {
                query = "update User Set u_password = '" + NewPassBox.Text + "'  where user.u_username like '%" + WhatIsUserBox.Text + "%' AND user.U_email like '%" + textBox2.Text + "%'";
                cmd = new MySqlCommand(query, cnn);

                cmd.ExecuteNonQuery();

                //alter table user with new password
                MessageBox.Show("success! You dodged all the errors against all odds, and changed your password!");


            }
            else
            {
                MessageBox.Show("it didnt work, try again...who am I kidding, it probably crashed and no one will see this message...  ");

            }



        }

        private void NewPassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecretAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
