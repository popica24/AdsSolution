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
    
        UserDatabaseJSON UDB;

        public SignUpForm(UserDatabaseJSON _UDB)
        {
            InitializeComponent();
            UDB = _UDB;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!UDB.UserList.Any
                 (a => a.Value.Email.Equals(EmailBox.Text, StringComparison.CurrentCultureIgnoreCase) ||
                 a.Value.Phone.Equals(PhoneBox.Text)))
            {
                User U = new User(NameBox.Text, PasswordBox.Text, EmailBox.Text, PhoneBox.Text);
                UDB.AddElement(U);
                
            }
            return;
        }
    }
}
