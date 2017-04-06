using AutoMapper;
using DTOs.Attributes;
using Entities.Entities;

namespace Mappers.Attributes
{
    public class AttributeTypeMapper
    {
        public static AttributeTypeDto MapTo(AttributeType attributeType)
        {
            var attributeDto = Mapper.Map<AttributeType, AttributeTypeDto>(attributeType);
            return attributeDto;
        }
    }
}
