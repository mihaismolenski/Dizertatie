using AutoMapper;
using DTOs.Users;
using Entities.Entities;

namespace Mappers.Users
{
    public class UserMapper
    {
        public static UserDto MapTo(User user)
        {
            var userDto = Mapper.Map<User, UserDto>(user);
            return userDto;
        }
    }
}
