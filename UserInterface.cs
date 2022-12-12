using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient; /// this
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DatabaseProject
{
    public partial class UserInterface : Form
    {
        int CurrentUserId = 0;



        public UserInterface()
        {
            InitializeComponent();


            string connetionString;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=PasswordManager;user=root;password=password1";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");

            

            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void WebsiteSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IDInputDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void WebsiteInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsernameChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEntry_Click(object sender, EventArgs e)
        {

            string connetionString;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=PasswordManager;user=root;password=password1";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            if (CurrentUserId != 0)
            {

                //add entry
            }
            else
            {
                //get id based on entries and then add entry
                string query = "Select u_password from User where u_username = '" + textBox2.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                string password = cmd.ExecuteScalar().ToString();

                if (textBox1.Text == password)
                {

                    query = "Select u_Id from User where u_username = '" + textBox2.Text + "'";
                    cmd = new MySqlCommand(query, cnn);
                    CurrentUserId = Convert.ToInt32(cmd.ExecuteScalar());

                }

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {




            string connetionString;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=PasswordManager;user=root;password=password1";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            if (CurrentUserId != 0)
            {

                //delete entry
            }
            else
            {
                //get id based on entries and then delete entries
                string query = "Select u_password from User where u_username = '" + textBox2.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                string password = cmd.ExecuteScalar().ToString();

                if (textBox1.Text == password)
                {

                    query = "Select u_Id from User where u_username = '" + textBox2.Text + "'";
                    cmd = new MySqlCommand(query, cnn);
                    CurrentUserId = Convert.ToInt32(cmd.ExecuteScalar());

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connetionString;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=PasswordManager;user=root;password=password1";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            if (CurrentUserId != 0)
            {

                //modify entry
            }
            else
            {
                //get id based on entries and then modify entries
                



                string query = "Select u_password from User where u_username = '" + textBox2.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                string password = cmd.ExecuteScalar().ToString();

                if (textBox1.Text == password)
                {

                    query =  "Select u_Id from User where u_username = '" + textBox2.Text + "'";
                    cmd = new MySqlCommand(query, cnn);
                    CurrentUserId = Convert.ToInt32( cmd.ExecuteScalar() );
                    
                }



            }
        }
    }
}
