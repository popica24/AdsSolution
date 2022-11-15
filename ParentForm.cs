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
        AdDatabaseJSON ADB;
        User U;

        public ParentForm(User PassedUser)
        {

            InitializeComponent();
            UDB = new UserDatabaseJSON();
            ADB = new AdDatabaseJSON();
            U = PassedUser;
            CurentUser.Text = U.ToString();
            
            foreach (var x in ADB.ListOfAds)
            {
                AdContainer.Controls.Add(CreateAdContainer(x.ToString()));
            }
        }

        private void NewAdBtn_Click(object sender, EventArgs e)
        {
            NewAdForm AdForm = new NewAdForm(U);
          
                AdForm.Show();
                AdForm.FormClosed += new FormClosedEventHandler(AdForm_FormClosed);
            
            void AdForm_FormClosed(object _sender, FormClosedEventArgs _e)
            {
                AdContainer.Controls.Clear();
                ADB.LoadAds();
                foreach(var x in ADB.ListOfAds)
                {
                    AdContainer.Controls.Add(CreateAdContainer(x.ToString()));
                }
            }
        }

        private GroupBox CreateAdContainer(string AdText)
        {
            Label L = new Label();
            L.Text = AdText;
            GroupBox G = new GroupBox();
            G.Text = "";
            G.Width = 670;
            G.Height = 100;
            G.BackColor = Color.White;
            G.Controls.Add(L);
            return G;
        }
    }
}