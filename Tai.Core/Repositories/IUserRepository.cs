using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tai.Core.Domain;

namespace Tai.Core.Repositories
{
    public interface IUserRepository
    {
        User Get(Guid id);
        IEnumerable<User> GetAll();
        User Add (User user);
    }
}
