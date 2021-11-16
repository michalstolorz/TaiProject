using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tai.Core.Domain;
using Tai.Infrastructure.DTO;

namespace Tai.Infrastructure.Mappers
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg=>
            {
                cfg.CreateMap<User, UserDto>();
            })
            .CreateMapper();
    }
}
