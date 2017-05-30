using AutoMapper;
using DTOs.Attributes;
using DTOs.FileAccessTrees;
using DTOs.Files;
using DTOs.Gates;
using DTOs.Users;
using Entities.Entities;

namespace Mappers
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<UserAttribute, UserAttributeDto>();
            CreateMap<AttributeType, AttributeTypeDto>();
            CreateMap<File, FileDto>();
            CreateMap<FileDto, File>();
            CreateMap<FileAttribute, FileAttributeDto>();
            CreateMap<FileAttributeDto, FileAttribute>();
            CreateMap<FileAccessTree, FileAccessTreeDto>();
            CreateMap<FileAccessTreeDto, FileAccessTree>();
            CreateMap<Gate, GateDto>();
            CreateMap<GateDto, Gate>();
        }
    }
}
