using Entities.Entities;
using FluentNHibernate.Mapping;

namespace Entities.FluentMappings
{
    public class FileMap : ClassMap<File>
    {
        public FileMap()
        {
            Table("Files");
            Id(x => x.FileId);
            Map(x => x.Name);
            Map(x => x.CreatedDate);
        }
    }
}
