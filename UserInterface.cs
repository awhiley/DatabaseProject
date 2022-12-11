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
        public UserInterface()
        {
            InitializeComponent();


            string connetionString;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=PasswordManager;user=root;password=password1";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");



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



        }
    }
}
