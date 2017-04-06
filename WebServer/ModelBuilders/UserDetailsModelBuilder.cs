using CloudWrappers.CpAbeCloud;
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
    }
}