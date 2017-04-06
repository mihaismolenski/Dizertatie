using System.Collections.Generic;
using DTOs.Users;
using Repositories.Managers;

namespace CloudWrappers.CpAbeCloud
{
    public static class CpAbeCloud
    {
        public static IList<UserDto> GetCpAbeUsers()
        {
            var manager = new UserManager();
            return manager.GetAllUsers();
        }

        public static UserDto GetUserById(int userId)
        {
            var manager = new UserManager();
            return manager.GetUserById(userId);
        }

        public static void DeleteUserAttribute(int userId, int attributeId)
        {
            var manager = new UserManager();
            manager.DeleteUserAttribute(userId, attributeId);
        }

        public static void AddUserAttribute(int userId, int attributeTypeId, string value)
        {
            var manager = new UserManager();
            manager.AddUserAttribute(userId, attributeTypeId, value);
        }
    }
}
