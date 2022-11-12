using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsSolution
{
    public interface IUserRepository
    {
        User GetUserByID(Guid UserID);
        void CreateUser(User user);
        void DeleteUser(Guid UserID);
        void UpdateUser(User user);
        void Save();
    }

    public class UserRepository : IUserRepository
    {
        private List<User> UserList;

        public UserRepository(List<User> _UserList)
        {
            this.UserList = _UserList;
        }

        public IEnumerable<User> GetUsers()
        {

            throw new NotImplementedException();
        }

        public void CreateUser(User user)
        {
            UserList.Add(user);
        }

        public void DeleteUser(Guid UserID)
        {
            foreach(User u in UserList)
                if(u.OwnerKey==UserID)UserList.Remove(u);
        }

        public User GetUserByID(Guid UserID)
        {
            foreach (User u in UserList)
                if (u.OwnerKey == UserID) return u;
            return null;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
