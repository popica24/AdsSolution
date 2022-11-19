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
        
        UserDatabaseJSON UDB;
        public LoginForm()
        {
            InitializeComponent();
            UDB = new UserDatabaseJSON();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            this.Hide();
            using (SignUpForm S = new SignUpForm(UDB))
            { S.ShowDialog();
                S.FormClosed += (s, a) => this.Show();
            }
           

        }

        private void Login_Click(object sender, EventArgs e)
        {

            var email = EmailBox.Text;
            var password = PasswordBox.Text;
            int token = UDB.GetLoginToken(email, password);
            {
                if (token != 0)
                {
                    this.Hide();
                    ParentForm P = new ParentForm(UDB.LoadElement(token));
                    P.FormClosed += (s, args) => this.Close();
                    P.Show();
                }
                else return;
            }
        }
    }
}
