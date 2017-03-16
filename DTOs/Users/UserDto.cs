using System.Collections.Generic;
using DTOs.UserAttributes;

namespace DTOs.Users
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<IUserAttribute> UserAttributes;
    }
}
