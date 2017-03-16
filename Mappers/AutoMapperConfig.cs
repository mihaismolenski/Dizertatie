using AutoMapper;
using DTOs.Users;
using Entities.Entities;

namespace Mappers
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserDto>();
        }
    }
}
