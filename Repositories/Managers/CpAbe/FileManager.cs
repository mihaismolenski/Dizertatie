using DTOs.FileAccessTrees;
using Entities.Entities;
using Mappers.Files;

namespace Repositories.Managers.CpAbe
{
    public class FileManager : BaseManager
    {
        public FileAccessTreeDto GetAccessTreeByFileId(int fileId)
        {
            var accessTree = Session.QueryOver<FileAccessTree>()
                .Where(x => x.File.FileId == fileId)
                .SingleOrDefault();
            return FileAccessTreeMapper.MapToDto(accessTree);
        }
    }
}
