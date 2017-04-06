using FluentNHibernate.Mapping;

namespace Entities.FluentMappings
{
    public class UserAttributeMap : ClassMap<Entities.UserAttribute>
    {
        public UserAttributeMap()
        {
            Schema("Cp");
            Table("UserAttributes");
            Id(x => x.Id);
            Map(x => x.Value);
            References(x => x.AttributeType, "AttributeTypeId");
            References(x => x.User, "UserId");
        }
    }
}
