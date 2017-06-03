using System.Collections.Generic;
using DTOs.Attributes;
using DTOs.Gates;
using Repositories.Managers;

namespace CloudWrappers.LookUps
{
    public class LookUps
    {
        private static IList<AttributeTypeDto> _attributeTypes;
        private static IList<GateDto> _gates;

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

        public static IList<GateDto> Gates
        {
            get
            {
                if (_gates == null)
                {
                    var manager = new GateManager();
                    _gates = manager.GetAllGates();
                }
                return _gates;
            }
        }
    }
}
