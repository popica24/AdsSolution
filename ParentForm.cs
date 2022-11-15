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
            AdContainer = ReloadAds();
      
        }

        private void NewAdBtn_Click(object sender, EventArgs e)
        {
            NewAdForm N = new NewAdForm(U);
            N.Show();
        }

        private GroupBox CreateAdContainer(string AdText)
        {
            Label L = new Label();
            L.Text = AdText;
            GroupBox G = new GroupBox();
            G.Text = "AD";
            L.AutoSize = true;
            G.Size = new Size(670, 100);
            L.Location = new Point(300, 50);
            G.Name = U.OwnerKey.ToString();
           // G.BackColor = Color.White;
            G.Controls.Add(L);
            
            return G;
        }
        private FlowLayoutPanel ReloadAds()
        {
            var _tempContainer = new FlowLayoutPanel();
            var _temp = new List<Ad>();
            foreach (var x in ADB.ListOfAds)
            {
                _temp.Add(x);
                _tempContainer.Controls.Add(CreateAdContainer(x.ToString()));
            }

            return _tempContainer;

        }
    }
}