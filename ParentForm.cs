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
        
        public ParentForm()
        {
            InitializeComponent();
            UDB = new UserDatabaseJSON();
            U = UDB.LoadUser();
        }

        private void NewAdBtn_Click(object sender, EventArgs e)
        {
            NewAdForm AdForm = new NewAdForm();
            AdForm.Show();
        }
    }
}
