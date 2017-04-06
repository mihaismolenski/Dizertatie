using System.Collections.Generic;
using AutoMapper;
using DTOs.Attributes;
using DTOs.Users;
using Entities.Entities;
using Mappers.Attributes;

namespace Mappers.Users
{
    public class UserMapper
    {
        public static UserDto MapTo(User user)
        {
            var userDto = Mapper.Map<User, UserDto>(user);
            userDto.UserAttributes = new List<UserAttributeDto>();

            foreach (var a in user.Attributes)
            {
                userDto.UserAttributes.Add(UserAttributeMapper.MapTo(a));
            }

            return userDto;
        }
    }
}
