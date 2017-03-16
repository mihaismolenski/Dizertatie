using DTOs.Users;
using Entities.Entities;
using Mappers.Users;

namespace Repositories.Managers
{
    public class UserManager : BaseManager
    {
        public UserDto GetUserById(int userId)
        {
            var user = Session.QueryOver<User>()
                .Where(a => a.UserId == userId)
                .SingleOrDefault();
            return UserMapper.MapTo(user);
        }
    }
}
