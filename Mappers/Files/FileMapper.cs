using AutoMapper;
using DTOs.Files;
using Entities.Entities;

namespace Mappers.Files
{
    public class FileMapper
    {
        public static FileDto MapToDto(File file)
        {
            if (file == null)
            {
                return null;
            }
            var fileDto = Mapper.Map<File, FileDto>(file);

            return fileDto;
        }

        public static File MapToEntity(FileDto fileDto)
        {
            var file = Mapper.Map<FileDto, File>(fileDto);

            return file;
        }
    }
}
