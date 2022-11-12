using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsSolution
{
    public class UserDatabaseJSON 
    {
        private string filePath { get; set; }
        public UserDatabaseJSON()
        {
            if (!DatabaseExists()) DatabaseCreate();
            filePath = ConfigurationManager.AppSettings["FilePath"];
        }
        private bool DatabaseExists()
        {
           
            return Directory.Exists(filePath);
        }
        private void DatabaseCreate()
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
        }
        public User LoadUser(User U)
        {
            var Text = File.ReadAllText(Path.Combine(filePath, "Users.json"));
            var UserList = JsonConvert.DeserializeObject<List<User>>(Text);
            foreach(User _U in UserList)
            {
                if (_U.Equals(U)) return _U;
         
            }
            return null;
        }
        public List<User> LoadUsers()
        {
            var Text = File.ReadAllText(Path.Combine(filePath, "Users.json"));
            return JsonConvert.DeserializeObject<List<User>>(Text);
        }
        public void CreateNewUser(User U)
        {
            var _newlist = LoadUsers();
            _newlist.Add(U);
            File.WriteAllText(Path.Combine(filePath, "Users.json"), JsonConvert.SerializeObject(_newlist));
        }
        public void LoginUser(Guid UserID)
        {
            throw new NotImplementedException();
        }
    }
}
