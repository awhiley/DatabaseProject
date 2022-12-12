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

            
            //try to display
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

            string query = "this text doesnt matter lol ";
            MySqlCommand cmd = new MySqlCommand(query, cnn);

            if (CurrentUserId != 0)
            {

                //add website first
                query = "insert into WEB_INFO (webdomain, webname ) values ( ' " + WebsiteInput.Text + "' , '" + textBox3.Text + "' ) ";
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();

                //get web id we just entered
                query = "select web_id from WEB_INFO where webdomain = '" + WebsiteInput.Text + "' AND webname = '" + textBox3.Text + "'";
                cmd = new MySqlCommand(query, cnn);
                var temp = cmd.ExecuteNonQuery();

                //add login info
                query = "insert into LOGIN_INFO (u_id, web_id, L_email, L_password, L_phone, l_username ) values ( ' " + CurrentUserId + "' , " + temp + ", '" + EmailInput.Text + "' , '" + PasswordInput.Text + "', '" + textBox4.Text + "' , '" + UsernameInput.Text + "' )";
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
            }
            else //does the same thing but gets user id first
            {
                //get id based on entries and then add entry
                query = "Select u_password from User where u_username = '" + textBox2.Text + "'";
                cmd = new MySqlCommand(query, cnn);
                string password = cmd.ExecuteScalar().ToString();

                if (textBox1.Text == password)
                {

                    query = "Select u_Id from User where u_username = '" + textBox2.Text + "'";
                    cmd = new MySqlCommand(query, cnn);
                    CurrentUserId = Convert.ToInt32(cmd.ExecuteScalar());



                    //add website first
                    query = "insert into WEB_INFO (webdomain, webname ) values ( ' " + WebsiteInput.Text + "' , '" + textBox3.Text + "' ) ";
                    cmd = new MySqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();

                    //get web id we just entered
                    query = "select web_id from WEB_INFO where webdomain = '" + WebsiteInput.Text + "' AND webname = '" + textBox3.Text + "'";
                    cmd = new MySqlCommand(query, cnn);
                    var temp = cmd.ExecuteNonQuery();

                    //add login info
                    query = "insert into LOGIN_INFO (u_id, web_id, L_email, L_password, L_phone, l_username ) values ( ' " + CurrentUserId + "' , " + temp + ", '" + EmailInput.Text + "' , '" + PasswordInput.Text + "', '" + textBox4.Text + "' , '" + UsernameInput.Text + "' )";
                    cmd = new MySqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();
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
            string query = "this text also does nothing, or at least should do nothing";
            MySqlCommand cmd = new MySqlCommand(query, cnn);


            if (CurrentUserId != 0)
            {

                //find web id to delete
                query = "select web_id from login_info inner join web_info on login_info.web_id = web_info.web_id where L_id = " + Convert.ToInt32(IDInputDelete.Text) + " AND u_id = " + CurrentUserId; 
                cmd = new MySqlCommand(query, cnn);
                var temp = cmd.ExecuteScalar();

                //delete entry from login info
                query = "delete from login_info where L_id = " + Convert.ToInt32(IDInputDelete.Text) + " AND u_id = " + CurrentUserId;
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();

                //delete entry from web info
                query = "delete from web_info where web_id = " + temp ;
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();





            }
            else //does the same thing but gets user id first
            {
                //get id based on entries and then delete entries
                query = "Select u_password from User where u_username = '" + textBox2.Text + "'";
                cmd = new MySqlCommand(query, cnn);
                string password = cmd.ExecuteScalar().ToString();

                if (textBox1.Text == password)
                {

                    query = "Select u_Id from User where u_username = '" + textBox2.Text + "'";
                    cmd = new MySqlCommand(query, cnn);
                    CurrentUserId = Convert.ToInt32(cmd.ExecuteScalar());




                    //find web id to delete
                    query = "select web_id from login_info inner join web_info on login_info.web_id = web_info.web_id where L_id = " + Convert.ToInt32(IDInputDelete.Text) + " AND u_id = " + CurrentUserId;
                    cmd = new MySqlCommand(query, cnn);
                    var temp = cmd.ExecuteScalar();

                    //delete entry from login info
                    query = "delete from login_info where L_id = " + Convert.ToInt32(IDInputDelete.Text) + " AND u_id = " + CurrentUserId;
                    cmd = new MySqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();

                    //delete entry from web info
                    query = "delete from web_info where web_id = " + temp;
                    cmd = new MySqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();

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


            string query = "lol bro im a terrible programmer";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            if (CurrentUserId != 0)
            {

                //modify entry


                query = "update login_info set L_EMAIL = '" + EmailChange.Text + "',  L_PASSWORD = '" + PasswordChange.Text + "',  L_PHONE = '" + textBox5.Text + "',  L_USERNAME = '" + UsernameChange.Text + "' where L_ID = " + Convert.ToInt32(IDInputModify.Text) + "AND u_id = " + CurrentUserId;
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();




            }
            else //does smae thing but gets current user id first
            {
                //get id based on entries and then modify entries
                



                query = "Select u_password from User where u_username = '" + textBox2.Text + "'";
                cmd = new MySqlCommand(query, cnn);
                string password = cmd.ExecuteScalar().ToString();

                if (textBox1.Text == password)
                {

                    query =  "Select u_Id from User where u_username = '" + textBox2.Text + "'";
                    cmd = new MySqlCommand(query, cnn);
                    CurrentUserId = Convert.ToInt32( cmd.ExecuteScalar() );




                    query = "update login_info set L_EMAIL = '" + EmailChange.Text + "',  L_PASSWORD = '" + PasswordChange.Text + "',  L_PHONE = '" + textBox5.Text + "',  L_USERNAME = '" + UsernameChange.Text + "' where L_ID = " + Convert.ToInt32(IDInputModify.Text) + "AND u_id = " + CurrentUserId;
                    cmd = new MySqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();

                }



            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDInputModify_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
