using CloudWrappers.CpAbeCloud;
using DTOs.Users;
using WebServer.ViewModels;

namespace WebServer.ModelBuilders
{
    public class UserDetailsModelBuilder
    {
        public UserViewModel GetModel(int userId)
        {
            var userDto = CpAbeCloud.GetUserById(userId);
            return new UserViewModel
            {
                UserId = userDto.UserId,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                UserAttributes = userDto.UserAttributes
            };
        }

        public void DeleteUserAttribute(int userId, int attributeId)
        {
            CpAbeCloud.DeleteUserAttribute(userId, attributeId);
        }

        public void AddUserAttribute(int userId, int attributeTypeId, string value)
        {
            CpAbeCloud.AddUserAttribute(userId, attributeTypeId, value);
        }

        public UserViewModel SaveUser(UserViewModel model)
        {
            var dto = new UserDto
            {
                UserId = model.UserId,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
            var result = CpAbeCloud.SaveUser(dto);
            return new UserViewModel
            {
                UserId = result.UserId,
                FirstName = result.FirstName,
                LastName = result.LastName,
                UserAttributes = result.UserAttributes
            };
        }
    }
}