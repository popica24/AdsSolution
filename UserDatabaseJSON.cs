using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AdsSolution
{
    public class UserDatabaseJSON : IDatabaseJSON<User>
    {
        private string filePath
        {
            get;
            set;
        }
        public UserDatabaseJSON()
        {
            filePath = ConfigurationManager.AppSettings["FilePath"];
            if (!DatabaseExists()) DatabaseCreate();

        }
        public bool DatabaseExists()
        {

            return File.Exists(Path.Combine(filePath, "Users.json"));
        }
        public void DatabaseCreate()
        {
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);

            if (!File.Exists(Path.Combine(filePath, "Users.json")))
                File.Create(Path.Combine(filePath, "Users.json"));
        }
        public User LoadElement(int LoginToken)
        {
            var Text = File.ReadAllText(Path.Combine(filePath, "Users.json"));
            var UserList = JsonConvert.DeserializeObject<Dictionary<int,User>>(Text);
            return UserList[LoginToken];
        }
    
   
        public void AddElement(User U)
        {
            var UserList = new Dictionary<int, User>();
            var Text = File.ReadAllText(Path.Combine(filePath, "Users.json"));
            if (!string.IsNullOrEmpty(Text))
            {
                UserList = JsonConvert.DeserializeObject<Dictionary<int, User>>(Text);
            }
            UserList.Add(U.GetHashCode(), U);
            File.WriteAllText(Path.Combine(filePath, "Users.json"), JsonConvert.SerializeObject(UserList));
        }
        public int GetLoginToken(string email, string password)
        {
            
            var Text = File.ReadAllText(Path.Combine(filePath, "Users.json"));
            var UserList = JsonConvert.DeserializeObject<Dictionary<int, User>>(Text);
            var c = UserList.FirstOrDefault(x => (String.Equals(x.Value.Email, email) && String.Equals(x.Value.Password, password))).Key;
            return c;
        }
        
        public GroupBox CreateContainer(User U,bool IsOwned)
        {
            GroupBox G = new GroupBox();
            G.Text = "";
            G.Size = new Size(268, 100);
            G.Name = U.Username;
            Label L = new Label();
            L.Text = U.ToString();
            L.AutoSize = true;
            L.Location = new Point(6, 36);
            G.Controls.Add(L);

            return G;
        }

        public List<User> GetElements()
        {
            var _temp = new List<User>();
            var text = File.ReadAllText(Path.Combine(filePath, "Users.json"));
            var Users = JsonConvert.DeserializeObject<Dictionary<int, User>>(text);
            foreach(KeyValuePair<int,User> entry in Users)
            {

                _temp.Add(entry.Value);
            }
            return _temp;
        }
        public void LogOut(User U)
        {
            U = new User();
        }
     
    }
}