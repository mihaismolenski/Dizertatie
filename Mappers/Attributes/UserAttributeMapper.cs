using AutoMapper;
using DTOs.Attributes;
using Entities.Entities;

namespace Mappers.Attributes
{
    public class UserAttributeMapper
    {
        public static UserAttributeDto MapTo(UserAttribute userAttribute)
        {
            var attributeDto = Mapper.Map<UserAttribute, UserAttributeDto>(userAttribute);
            attributeDto.Name = userAttribute.AttributeType.Name;
            attributeDto.AttributeTypeId = userAttribute.AttributeType.AttributeTypeId;
            return attributeDto;
        }
    }
}
