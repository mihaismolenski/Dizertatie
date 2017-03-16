using System.Collections.Generic;
using DTOs.Users;

namespace WebServer.ViewModels
{
    public class UsersListViewModel
    {
        public IList<UserDto> Users { get; set; }
    }
}