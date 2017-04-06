using System.Collections.Generic;
using DTOs.Attributes;

namespace DTOs.Users
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<UserAttributeDto> UserAttributes;
    }
}
