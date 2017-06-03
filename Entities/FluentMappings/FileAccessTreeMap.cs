using Entities.Entities;
using FluentNHibernate.Mapping;

namespace Entities.FluentMappings
{
    public class FileAccessTreeMap : ClassMap<FileAccessTree>
    {
        public FileAccessTreeMap()
        {
            Schema("Cp");
            Table("FileAccessTree");
            Id(x => x.AccessTreeId);
            References(x => x.File, "FileId");
            References(x => x.Gate, "GateId");
            References(x => x.FileAttribute, "FileAttributeId");
            HasMany(x => x.Children).KeyColumn("ParentId").Inverse().Cascade.AllDeleteOrphan();
            References(x => x.Parent, "ParentId");
        }
    }
}
