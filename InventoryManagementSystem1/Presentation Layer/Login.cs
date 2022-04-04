using InventoryManagementSystem1.Data_Acess_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserRegistration2;

namespace InventoryManagementSystem1.Presentation_Layer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void userregistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginUserNameTextBox.Text=="" && loginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Username and Password can not be empty");
            }
            else if(loginUserNameTextBox.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if(loginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else
            {
                UserDataAccess userDataAccess = new UserDataAccess();
                if (userDataAccess.ValidateLogin(loginUserNameTextBox.Text, loginPasswordTextBox.Text))
                {
                    Dashboard2 dashboard2 = new Dashboard2();
                    dashboard2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void showPasswordbutton_Click(object sender, EventArgs e)
        {
            if (loginPasswordTextBox.PasswordChar == '*')
            {
                hidePasswordButton.BringToFront();
                loginPasswordTextBox.PasswordChar = '\0';
            }
        }

        private void hidePasswordButton_Click(object sender, EventArgs e)
        {
            if (loginPasswordTextBox.PasswordChar == '\0')
            {
                showPasswordbutton.BringToFront();
                loginPasswordTextBox.PasswordChar = '*';
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            loginUserNameTextBox.Text = string.Empty;
            loginPasswordTextBox.Text = string.Empty;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
