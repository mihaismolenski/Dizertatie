using AutoMapper;
using DTOs.Attributes;
using DTOs.Users;
using Entities.Entities;

namespace Mappers
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserAttribute, UserAttributeDto>();
            CreateMap<AttributeType, AttributeTypeDto>();
        }
    }
}
