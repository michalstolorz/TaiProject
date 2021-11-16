using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Tai.Core.Domain;
using Tai.Core.Repositories;

namespace Tai.Infrastructure.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private static readonly ISet<User> _users = new HashSet<User>()
        {
            new User(Guid.NewGuid(), "User 1", "Password 1"),
            new User(Guid.NewGuid(), "User 2", "Password 2"),
            new User(Guid.NewGuid(), "User 3", "Password 3")
        };

        public User Add(User user)
        {
            _users.Add(user);
            return user;
        }

        public User Get(Guid id)
        {
            return _users.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }
    }
}
