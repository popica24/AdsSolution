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
        UserDatabaseJSON context;

        public SignUpForm()
        {
            InitializeComponent();
            U = new User();
            NameBox.GotFocus += RemoveNameTextOnFocus;
            EmailBox.GotFocus += RemoveEmailTextOnFocus;
            PasswordBox.GotFocus += RemovePasswordTextOnFocus;
            PhoneBox.GotFocus += RemovePhoneTextOnFocus;
            context = new UserDatabaseJSON();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!U.EmailIsValid(EmailBox.Text)) { EmailStatus.Text = "Invalid Email !"; EmailStatus.ForeColor = Color.Red; SignUp.Enabled = false; }
            else { EmailStatus.Text = ""; SignUp.Enabled = true; }
            }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (NameBox.Text == "Name" || NameBox.Text == "") { { NameStatus.Text = "Invalid Email !"; NameStatus.ForeColor = Color.Red; SignUp.Enabled = false; } }
            else { NameStatus.Text = ""; SignUp.Enabled = true; }
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (!U.PaswordIsValid(PasswordBox.Text)) { PasswordStatus.Text = "Invalid Password !"; PasswordStatus.ForeColor = Color.Red; SignUp.Enabled = false; }else 
            { PasswordStatus.Text = ""; SignUp.Enabled = true; }
        }
        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            if (!U.PhoneIsValid(PhoneBox.Text)) { PhoneStatus.Text = "Invalid Password !"; PhoneStatus.ForeColor = Color.Red; SignUp.Enabled = false; }
            else { PhoneStatus.Text = ""; SignUp.Enabled = true; }
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

        private void button1_Click(object sender, EventArgs e)
        {
            User U = new User(NameBox.Text,PasswordBox.Text,EmailBox.Text,PhoneBox.Text);
            context.CreateNewUser(U);
        }

       
    }
}
