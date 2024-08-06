using WebApplication1.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User>
    {
        new User { Id = 1, UserName = "client1", Email = "client1@example.com", Password = "password1", Role = "Client" },
        new User { Id = 2, UserName = "manager1", Email = "manager1@example.com", Password = "password2", Role = "Manager" },
        new User { Id = 3, UserName = "support1", Email = "support1@example.com", Password = "password3", Role = "Support" },
    };

        public User GetUserByEmailOrUserName(string emailOrUserName)
        {
            return _users.FirstOrDefault(u => u.Email == emailOrUserName || u.UserName == emailOrUserName);
        }
    }
}
