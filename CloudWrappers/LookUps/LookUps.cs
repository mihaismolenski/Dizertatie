using System.Collections.Generic;
using DTOs.Attributes;
using Repositories.Managers;

namespace CloudWrappers.LookUps
{
    public class LookUps
    {
        private static IList<AttributeTypeDto> _attributeTypes;

        public static IList<AttributeTypeDto> AttributeTypes
        {
            get
            {
                if (_attributeTypes == null)
                {
                    var manager = new AttributeManager();
                    _attributeTypes = manager.GetAttributeTypes();
                }
                return _attributeTypes;
            }
        }
    }
}
