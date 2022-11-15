using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdsSolution
{
    public partial class LoginForm : Form
    {
        readonly User U;
        UserDatabaseJSON UDB;

        public LoginForm()
        {
            InitializeComponent();
            EmailBox.GotFocus += RemoveEmailTextOnFocus;
            PasswordBox.GotFocus += RemovePasswordTextOnFocus;
            UDB = new UserDatabaseJSON();
            U = new User();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm S = new SignUpForm();
            S.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!U.EmailIsValid(EmailBox.Text))
            {
                EmailStatus.Text = "Invalid Email !";
                EmailStatus.ForeColor = Color.Red;
                Login.Enabled = false;
            }
            else
            {
                EmailStatus.Text = "";
                Login.Enabled = true;
            }
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (!U.PaswordIsValid(PasswordBox.Text))
            {
                PasswordStatus.Text = "Invalid Password !";
                PasswordStatus.ForeColor = Color.Red;
                Login.Enabled = false;
            }
            {
                PasswordStatus.Text = "";
                Login.Enabled = true;
            }
        }

        private void RemoveEmailTextOnFocus(object sender, EventArgs e)
        {
            if (EmailBox.Text == "Email")
            {
                EmailBox.Text = "";
            }
        }
        private void RemovePasswordTextOnFocus(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Password")
            {
                PasswordBox.Text = "";
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {

            this.Hide();
            UDB.LoginUser(EmailBox.Text, PasswordBox.Text);
        }
    }
}