using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tai.Infrastructure.DTO;

namespace Tai.Infrastructure.Services
{
    public interface IUserService
    {
        public UserDto Get(Guid id);

        public IEnumerable<UserDto> GetAll();
    }
}
