using System.Collections.Generic;
using DTOs.Users;
using Repositories.Managers;

namespace CloudWrappers.KpAbeCloud
{
    public static class KpAbeCloud
    {
        public static IList<UserDto> GetKpAbeUsers()
        {
            var manager = new UserManager();
            return manager.GetAllUsers();
        }
    }
}
