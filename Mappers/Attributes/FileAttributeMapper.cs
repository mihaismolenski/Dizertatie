using AutoMapper;
using DTOs.Attributes;
using Entities.Entities;

namespace Mappers.Attributes
{
    public class FileAttributeMapper
    {
        public static FileAttributeDto MapToDto(FileAttribute fileAttribute)
        {
            if (fileAttribute == null)
            {
                return null;
            }

            var fileAttributeDto = Mapper.Map<FileAttribute, FileAttributeDto>(fileAttribute);

            return fileAttributeDto;
        }
    }
}
