using Entities.Entities;
using FluentNHibernate.Mapping;

namespace Entities.FluentMappings
{
    public class GateMap : ClassMap<Gate>
    {
        public GateMap()
        {
            Table("Gates");
            Id(x => x.GateId);
            Map(x => x.Name);
        }
    }
}
