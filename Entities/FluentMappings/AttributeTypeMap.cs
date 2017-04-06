using Entities.Entities;
using FluentNHibernate.Mapping;

namespace Entities.FluentMappings
{
    public class AttributeTypeMap : ClassMap<AttributeType>
    {
        public AttributeTypeMap()
        {
            Table("AttributeTypes");
            Id(x => x.AttributeTypeId);
            Map(x => x.Name);
        }
    }
}
