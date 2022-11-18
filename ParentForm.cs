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
    public partial class ParentForm : Form
    {
        UserDatabaseJSON UDB;
        User U;
        
        public ParentForm(User PassedUser)
        {
           
            InitializeComponent();
            UDB = new UserDatabaseJSON();
            U = PassedUser;
            CurentUser.Text = U.ToString();
             foreach(User u in UDB.GetElements())
            {
                if (u.Equals(PassedUser)) continue;
                SocialPanel.Controls.Add(UDB.CreateContainer(u));
            }
        }

        private void NewAdBtn_Click(object sender, EventArgs e)
        {
            //NewAdForm AdForm = new NewAdForm(U);
            //AdForm.Show();
            using(NewAdForm AdForm = new NewAdForm(U)){
            AdForm.ShowDialog();
            }
        }
    }
}
