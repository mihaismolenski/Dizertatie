using System.Collections.Generic;
using CloudWrappers.CpAbeCloud;
using WebServer.ViewModels;

namespace WebServer.ModelBuilders
{
    public class FilesModelBuilder
    {
        public FileListViewModel GetAllFiles()
        {
            var fileDtos = CpAbeCloud.GetAllFiles();
            var viewModel = new FileListViewModel
            {
                Files = new List<FileViewModel>()
            };
            foreach (var dto in fileDtos)
            {
                viewModel.Files.Add(new FileViewModel
                {
                    FileId = dto.FileId,
                    Name = dto.Name,
                    CreatedDate = dto.CreatedDate
                });
            }
            return viewModel;
        }

        public void Delete(int fileId)
        {
            CpAbeCloud.DeleteFile(fileId);
        }
    }
}