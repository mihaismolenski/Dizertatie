using System.Collections.Generic;
using CloudWrappers.CpAbeCloud;
using DTOs.Attributes;
using DTOs.FileAccessTrees;
using DTOs.Files;
using DTOs.Gates;
using WebServer.ViewModels;

namespace WebServer.ModelBuilders
{
    public class FileDetailsModelBuilder
    {
        public FileViewModel GetFile(int fileId)
        {
            var dto = CpAbeCloud.GetFileById(fileId);
            var viewModel = new FileViewModel
            {
                FileId = dto.FileId,
                CreatedDate = dto.CreatedDate,
                Name = dto.Name
            };
            return viewModel;
        }

        public FileViewModel SaveFile(FileViewModel model)
        {
            var dto = new FileDto
            {
                FileId = model.FileId,
                Name = model.Name,
                CreatedDate = model.CreatedDate
            };
            var result = CpAbeCloud.SaveFile(dto);
            return new FileViewModel
            { 
                FileId = result.FileId,
                CreatedDate = result.CreatedDate,
                Name = result.Name
            };
        }

        public FileAccessTreeViewModel GetAccessTree(int fileId)
        {
            var dto = CpAbeCloud.GetAccessTree(fileId);
            var viewModel = MapAccessTreeToViewModel(dto);
            return viewModel;
        }

        private FileAccessTreeViewModel MapAccessTreeToViewModel(FileAccessTreeDto dto)
        {
            var viewModel = new FileAccessTreeViewModel
            {
                AccessTreeId = dto.AccessTreeId,
                File = MapFileToViewModel(dto.File),
                Gate = MapGateToViewModel(dto.Gate),
                FileAttribute = MapAttributeToViewModel(dto.FileAttribute),
                Children = new List<FileAccessTreeViewModel>()
            };
            foreach (var child in dto.Children)
            {
                viewModel.Children.Add(MapAccessTreeToViewModel(child));
            }
            return viewModel;
        }

        private FileAttributeViewModel MapAttributeToViewModel(FileAttributeDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            var fileAttributeDto = new FileAttributeViewModel
            {
                AttributeId = dto.AttributeId,
                Value = dto.Value,
                AttributeTypeId = dto.AttributeType.AttributeTypeId,
                AttributeTypeName = dto.AttributeType.Name
            };

            return fileAttributeDto;
        }

        private FileViewModel MapFileToViewModel(FileDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            var viewModel = new FileViewModel
            {
                FileId = dto.FileId,
                Name = dto.Name,
                CreatedDate = dto.CreatedDate
            };

            return viewModel;
        }

        private GateViewModel MapGateToViewModel(GateDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            var viewModel = new GateViewModel
            {
                GateId = dto.GateId,
                Name = dto.Name
            };

            return viewModel;
        }
    }
}