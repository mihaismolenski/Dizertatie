using System.Collections.Generic;
using AutoMapper;
using DTOs.FileAccessTrees;
using DTOs.Files;
using Entities.Entities;
using Mappers.Attributes;
using Mappers.Gates;

namespace Mappers.Files
{
    public class FileAccessTreeMapper
    {
        public static FileAccessTreeDto MapToDto(FileAccessTree fileAccessTree)
        {
            if (fileAccessTree == null)
            {
                return new FileAccessTreeDto
                {
                    Children = new List<FileAccessTreeDto>()
                };
            }
            var fileAccessTreeDto = new FileAccessTreeDto
            {
                AccessTreeId = fileAccessTree.AccessTreeId,
                Gate = GateMapper.MapToDto(fileAccessTree.Gate),
                File = FileMapper.MapToDto(fileAccessTree.File),
                FileAttribute = FileAttributeMapper.MapToDto(fileAccessTree.FileAttribute),
                Children = new List<FileAccessTreeDto>()
            };
            foreach (var child in fileAccessTree.Children)
            {
                fileAccessTreeDto.Children.Add(MapToDto(child));
            }

            return fileAccessTreeDto;
        }

        public static File MapToEntity(FileDto fileDto)
        {
            var file = Mapper.Map<FileDto, File>(fileDto);

            return file;
        }
    }
}
