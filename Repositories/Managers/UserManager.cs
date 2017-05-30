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

        public UserDto Save(UserDto dto)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                var user = dto.UserId != 0 ? Session.Load<User>(dto.UserId) : new User();
                user.FirstName = dto.FirstName;
                user.LastName = dto.LastName;
                Session.SaveOrUpdate(user);
                tx.Commit();
                return GetUserById(user.UserId);
            }
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

        public void Delete(int userId)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                var user = Session.Load<User>(userId);

                Session.Delete(user);
                tx.Commit();
            }
        }
    }
}
