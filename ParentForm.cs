using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdsSolution
{
    public partial class ParentForm : Form
    {
        UserDatabaseJSON UDB;
        AdDatabaseJSON ADB;
        User U;
        FileSystemWatcher W;
        public ParentForm(User PassedUser)
        {

            InitializeComponent();
            var filePath = ConfigurationManager.AppSettings["FilePath"];

            UDB = new UserDatabaseJSON();
            ADB = new AdDatabaseJSON();
            U = PassedUser;

            W = new FileSystemWatcher();
            W.Path = filePath;
            W.NotifyFilter = NotifyFilters.LastWrite;
            W.Filter = "Ads.json";
            W.Changed += new FileSystemEventHandler(Reload);
            W.EnableRaisingEvents = true;

            CurentUser.Text = U.ToString();

            foreach (User u in UDB.GetElementsAsList())
            {
                if (u.Equals(PassedUser)) continue;
                else
                    SocialPanel.Controls.Add(UDB.CreateContainer(u));
            }
            foreach (Ad a in ADB.GetElementsAsList())
            {
                AdPanel.Controls.Add(ADB.CreateContainer(a, Owns(U, a)));
            }
        }

        private bool Owns(User _U, Ad _A)
        {
            return (_U.OwnerKey == _A.OwnedBy);
        }
        private void NewAdBtn_Click(object sender, EventArgs e)
        {
            using (NewAdForm N = new NewAdForm(U, ADB))
            {
                N.ShowDialog();
            }
        }

        public void Reload(object sender, FileSystemEventArgs e)
        {
            AdPanel.Invoke(new MethodInvoker(delegate ()
            {
                // var list1 = ADB.AdList; CEA CARE SE MODIFICA LA EDIT !!!!!!!
                // var list2 = ADB.GetListOfGroupBoxRoot(AdPanel.Controls);
                if (ADB.AdList.Count == ADB.GetListOfGroupBoxRoot(AdPanel.Controls).Count)
                {
                    //DE IMPLEMENTAT
                }
                else if (ADB.AdList.Count < ADB.GetListOfGroupBoxRoot(AdPanel.Controls).Count)
                {
                    var RemovedItem = ADB.GetListOfGroupBoxRoot(AdPanel.Controls).Except(ADB.AdList);
                    foreach (var a in RemovedItem)
                    {
                        AdPanel.Controls.Remove(ADB.GetGroupBoxByRoot(a, AdPanel.Controls));
                    }
                    
                }
                else if (ADB.AdList.Count > ADB.GetListOfGroupBoxRoot(AdPanel.Controls).Count)
                {
                    var AddedItem = (ADB.AdList).Except(ADB.GetListOfGroupBoxRoot(AdPanel.Controls));
                    foreach (var a in AddedItem)
                    {
                        AdPanel.Controls.Add(ADB.CreateContainer(a, Owns(U, a)));
                    }
                    
                }
            
            }));

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UDB.LogOut(this.U);
            LoginForm P = new LoginForm();
            P.FormClosed += (s, args) => this.Close();
            P.Show();
        }

    }
}