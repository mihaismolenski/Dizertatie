using System.Collections.Generic;
using System.Linq;
using DTOs.Attributes;
using Entities.Entities;
using Mappers.Attributes;

namespace Repositories.Managers
{
    public class AttributeManager : BaseManager
    {
        public IList<AttributeTypeDto> GetAttributeTypes()
        {
            Session.Clear();
            var attributes = Session.QueryOver<AttributeType>().List();
            return attributes.Select(AttributeTypeMapper.MapTo).ToList();
        }
    }
}
