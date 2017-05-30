using Entities.Entities;
using FluentNHibernate.Mapping;

namespace Entities.FluentMappings
{
    public class FileAttributeMap : ClassMap<FileAttribute>
    {
        public FileAttributeMap()
        {
            Schema("Cp");
            Table("FileAttributes");
            Id(x => x.AttributeId);
            Map(x => x.Value);
            References(x => x.AttributeType, "AttributeTypeId");
        }
    }
}
