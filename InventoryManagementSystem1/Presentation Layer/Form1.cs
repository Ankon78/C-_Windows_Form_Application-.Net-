using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using InventoryManagementSystem1.Data_Acess_Layer;
using InventoryManagementSystem1.Presentation_Layer;

namespace UserRegistration2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                submitButton1.Enabled = true;
            }
            else
                submitButton1.Enabled = false;
        }

        private void submitButton1_Click(object sender, EventArgs e)
        {
            if (nameTextBox1.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (usernameTextBox1.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (passwordTextBox2.Text == "")
            {
                MessageBox.Show("Give password");
            }
            else if (confirmPasswordTextBox3.Text == "")
            {
                MessageBox.Show("confirm password does not match");
            }
            else if (EmailTextBox4.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("select a date");
            }
            else if (maleRadioButton1.Checked == false && femaleRadioButton2.Checked == false)
            {
                MessageBox.Show("select a gender");

            }
            else if (bloodGroupComboBox1.Text == "")
            {
                MessageBox.Show("select blood group");
            }
            else
            {
                if (passwordTextBox2.Text != confirmPasswordTextBox3.Text)
                {
                    MessageBox.Show("password incorrect");
                }
                else
                {
                    //string name, username, password, mail, dateOfBirth, gender, bloodGroup;
                    User user = new User();
                    user.Name = nameTextBox1.Text;
                    user.Username = usernameTextBox1.Text;
                    user.Password = passwordTextBox2.Text;
                    user.Email = EmailTextBox4.Text;
                    user.DateOfBirth = dateTimePicker1.Text;
                    if(maleRadioButton1.Checked)
                    {
                        user.Gender = "Male";
                    }
                    else
                        user.Gender = "Female";

                    user.BloodGroup = bloodGroupComboBox1.Text;
                    //Output output = new Output(user);

                    UserDataAccess userDataAccess = new UserDataAccess();
                    if(userDataAccess.UserRegister(user))
                    {
                        MessageBox.Show("User added");


                        Login login = new Login();
                        login.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Error in adding");
                    }



                   

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
