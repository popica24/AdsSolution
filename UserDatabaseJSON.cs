using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsSolution
{
    public class UserDatabaseJSON
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
        private bool DatabaseExists()
        {

            return File.Exists(Path.Combine(filePath, "Users.json"));
        }
        private void DatabaseCreate()
        {
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);

            if (!File.Exists(Path.Combine(filePath, "Users.json")))
                File.Create(Path.Combine(filePath, "Users.json"));
        }
        public User LoadUser(int LoginToken)
        {
            var Text = File.ReadAllText(Path.Combine(filePath, "Users.json"));
            var UserList = JsonConvert.DeserializeObject<Dictionary<int,User>>(Text);
            return UserList[LoginToken];
        }
    
        public void CreateNewUser(User U)
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
            return UserList.FirstOrDefault(x => (String.Equals(x.Value.Email, email) && String.Equals(x.Value.Password, password))).Key;
            
        }
        
    }
}