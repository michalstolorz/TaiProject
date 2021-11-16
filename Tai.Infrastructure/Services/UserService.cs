using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tai.Core.Repositories;
using Tai.Infrastructure.DTO;

namespace Tai.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserDto Get(Guid id)
        {
            var user = _userRepository.Get(id);
            return _mapper.Map<UserDto>(user);
        }

        public IEnumerable<UserDto> GetAll()
        {
            var users = _userRepository.GetAll();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }
    }
}
