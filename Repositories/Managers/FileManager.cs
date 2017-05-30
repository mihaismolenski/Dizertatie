using System.Collections.Generic;
using System.Linq;
using DTOs.FileAccessTrees;
using DTOs.Files;
using Entities.Entities;
using Mappers.Files;
using NHibernate;

namespace Repositories.Managers
{
    public class FileManager : BaseManager
    {
        public IList<FileDto> GetAllFiles()
        {
            var query = Session.QueryOver<File>().List();
            return query.Select(FileMapper.MapToDto).ToList();
        }

        public FileDto GetFileById(int fileId)
        {
            var file = Session.QueryOver<File>()
                .Where(x => x.FileId == fileId)
                .SingleOrDefault();
            return FileMapper.MapToDto(file);
        }

        public FileDto Save(FileDto dto)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                var file = dto.FileId != 0 ? Session.Load<File>(dto.FileId) : new File();
                file.Name = dto.Name;
                file.CreatedDate = dto.CreatedDate;
                Session.SaveOrUpdate(file);
                tx.Commit();
                return GetFileById(file.FileId);
            }
        }

        public void Delete(int fileId)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                var file = Session.Load<File>(fileId);
                Session.Delete(file);
                tx.Commit();
            }
        }

        public FileAccessTreeDto GetAccessTree(int fileId)
        {
            var accessTree = Session.QueryOver<FileAccessTree>()
                .Where(x => x.File.FileId == fileId)
                .SingleOrDefault();
            return FileAccessTreeMapper.MapToDto(accessTree);
        }
    }
}
