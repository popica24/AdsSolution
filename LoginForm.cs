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
        User U;
       
        public LoginForm()
        {
            InitializeComponent();
            U = new User();
            EmailBox.GotFocus +=RemoveEmailTextOnFocus;
            PasswordBox.GotFocus += RemovePasswordTextOnFocus;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm S = new SignUpForm();
            S.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!U.EmailIsValid(EmailBox.Text)) { EmailStatus.Text = "Invalid Email !"; EmailStatus.ForeColor = Color.Red; }
            else EmailStatus.Text = "";
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (!U.PaswordIsValid(PasswordBox.Text)) { PasswordStatus.Text = "Invalid Password !"; PasswordStatus.ForeColor = Color.Red; }
            else PasswordStatus.Text = "";
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
    }
}
