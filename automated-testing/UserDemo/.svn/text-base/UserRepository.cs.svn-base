using System.Collections.Generic;
using System.Linq;

namespace UserDemo
{
    public interface IUserRepository
    {
        User GetByUserName(string username);
    }

    public class UserRepository : IUserRepository
    {
        private IEnumerable<User> _users;

        public UserRepository()
        {
            _users = PopulateUsers();
        }

        public User GetByUserName(string username)
        {
            return _users.SingleOrDefault(u=>u.UserName == username);
        }

        #region User Setup
        private IEnumerable<User> PopulateUsers()
        {
            return new List<User>()
                       {
                           new User(){UserName = "user",Password = "Password",IsInActive = false, IsLockedOut = false, IsPasswordExpired = false},
                           new User(){UserName = "inactive",Password = "Password",IsInActive = true, IsLockedOut = false, IsPasswordExpired = false},
                           new User(){UserName = "lockedout",Password = "Password",IsInActive = false, IsLockedOut = true, IsPasswordExpired = false},
                           new User(){UserName = "passwordexpired",Password = "Password",IsInActive = false, IsLockedOut = false, IsPasswordExpired = true}
                       };
        }
        #endregion
    }
}