using Entities.Entities;
using FluentNHibernate.Mapping;

namespace Entities.FluentMappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");
            Id(x => x.UserId);
            Map(x => x.FirstName);
            Map(x => x.LastName);
        }
    }
}
