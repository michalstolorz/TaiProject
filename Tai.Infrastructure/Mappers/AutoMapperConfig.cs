using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tai.Core.Domain;
using Tai.Infrastructure.DTO;
using Tai.Infrastructure.DTO.Request;
using Tai.Infrastructure.DB.Models;
using Tai.Infrastructure.DTO.Response;

namespace Tai.Infrastructure.Mappers
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg=>
            {
                cfg.CreateMap<Core.Domain.User, UserDto>();
                cfg.CreateMap<RegisterRequest, DB.Models.User>()
                    .ForMember(dest => dest.UserName,
                    opt => opt.MapFrom(src => src.Email));
                cfg.CreateMap<DB.Models.User, LoginResponse>();
            })
            .CreateMapper();
    }
}
