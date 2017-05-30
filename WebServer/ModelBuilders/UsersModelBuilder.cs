using System.Collections.Generic;
using CloudWrappers.CpAbeCloud;
using WebServer.ViewModels;

namespace WebServer.ModelBuilders
{
    public class UsersModelBuilder
    {
        public UsersListViewModel GetViewModel()
        {
            var userDtos = CpAbeCloud.GetCpAbeUsers();

            var model = new UsersListViewModel
            {
                Users = new List<UserViewModel>()
            };

            foreach (var user in userDtos)
            {
                model.Users.Add(new UserViewModel
                {
                    UserId = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                });
            }

            return model;
        }

        public void DeleteUser(int userId)
        {
            CpAbeCloud.DeleteUser(userId);
        }
    }
}