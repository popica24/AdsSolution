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
    public partial class SignUpForm : Form
    {
        User U;
        public SignUpForm()
        {
            InitializeComponent();
            U = new User();
            EmailBox.GotFocus += RemoveEmailTextOnFocus;
            PasswordBox.GotFocus += RemovePasswordTextOnFocus;
            PhoneBox.GotFocus += RemovePhoneTextOnFocus;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!U.EmailIsValid(EmailBox.Text)) { EmailStatus.Text = "Invalid Email !"; EmailStatus.ForeColor = Color.Red; }
            else EmailBox.Text = "";
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (!U.PaswordIsValid(PasswordBox.Text)) { PasswordStatus.Text = "Invalid Password !"; PasswordStatus.ForeColor = Color.Red; }
            else PasswordBox.Text = "";
        }
        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            if (!U.PhoneIsValid(PhoneBox.Text)) { PhoneStatus.Text = "Invalid Password !"; PhoneStatus.ForeColor = Color.Red; }
            else PhoneStatus.Text = "";
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
        private void RemoveNameTextOnFocus(object sender, EventArgs e)
        {
            if (NameBox.Text == "Name")
            {
                NameBox.Text = "";
            }
        }
        private void RemovePhoneTextOnFocus(object sender, EventArgs e)
            {
                if (PhoneBox.Text == "Phone")
                {
                PhoneBox.Text = "";
                }
            }

       
    }
}
