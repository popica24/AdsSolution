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
    public class UserDatabaseJSON
    {
        private string filePath
        {
            get;
            set;
        }
        public Dictionary<int, User> UserList = new Dictionary<int, User>();
        
        public UserDatabaseJSON()
        {
            filePath = ConfigurationManager.AppSettings["FilePath"];
            if (!DatabaseExists()) DatabaseCreate();
            UserList = GetElementsAsDictionary();

        }
       
        //Database Status
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
       
        //GroupBox function
        public GroupBox CreateContainer(User U)
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
        
        //Database Operations
        public void AddElement(User U)
        {
            
            UserList.Add(U.GetHashCode(), U);
            File.WriteAllText(Path.Combine(filePath, "Users.json"), JsonConvert.SerializeObject(UserList));
        }
        public int GetLoginToken(string email, string password)
        {
            return UserList.FirstOrDefault(x => (String.Equals(x.Value.Email, email) && String.Equals(x.Value.Password, password))).Key;
        }
       
        public User LoadElement(int LoginToken)
        {
            return UserList[LoginToken];
        }
        public Dictionary<int,User> GetElementsAsDictionary()
        {
            var TempDictionary = new Dictionary<int, User>();


            string RawText = File.ReadAllText(Path.Combine(filePath, "Users.json"));
            
                var DeserializedText = JsonConvert.DeserializeObject<Dictionary<int, User>>(RawText);

                foreach (var entry in DeserializedText)
                {
                    TempDictionary.Add(entry.Key, entry.Value);
                }
            
            return TempDictionary;
        }
        public List<User> GetElementsAsList() // Display Only
        {
            var TempList = new List<User>();
            foreach(var entry in UserList.Values)
            {
                TempList.Add(entry);
            }
            return TempList;
        }
        public void LogOut(User U)
        {
            U = new User();
        }
     
    }
}