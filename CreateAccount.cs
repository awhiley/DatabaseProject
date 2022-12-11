using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
