using System.Collections.Generic;
using System.Linq;
using DTOs.Users;
using Entities.Entities;
using Mappers.Users;
using NHibernate;

namespace Repositories.Managers
{
    public class UserManager : BaseManager
    {
        public UserDto GetUserById(int userId)
        {
            Session.Clear();
            var user = Session.QueryOver<User>()
                .Where(a => a.UserId == userId)
                .SingleOrDefault();
            return UserMapper.MapTo(user);
        }

        public IList<UserDto> GetAllUsers()
        {
            var query = Session.QueryOver<User>()
                .List();

            return query.Select(UserMapper.MapTo).ToList();
        }

        public void AddUserAttribute(int userId, int attributeTypeId, string value)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                var user = Session.Load<User>(userId);
                var attributeType = Session.Load<AttributeType>(attributeTypeId);

                var userAttribute = new UserAttribute {AttributeType = attributeType, User = user, Value = value};
                Session.Save(userAttribute);

                tx.Commit();
            }
        }

        public void DeleteUserAttribute(int userId, int attributeId)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                var attribute = Session.Load<UserAttribute>(attributeId);

                Session.Delete(attribute);
                tx.Commit();
            }
        }
    }
}
