using System.Collections.Generic;
using DTOs.FileAccessTrees;
using DTOs.Files;
using DTOs.Gates;
using DTOs.Users;
using Repositories.Managers;

namespace CloudWrappers.CpAbeCloud
{
    public static class CpAbeCloud
    {
        public static IList<UserDto> GetCpAbeUsers()
        {
            var manager = new UserManager();
            return manager.GetAllUsers();
        }

        public static UserDto GetUserById(int userId)
        {
            var manager = new UserManager();
            return manager.GetUserById(userId);
        }

        public static void DeleteUserAttribute(int userId, int attributeId)
        {
            var manager = new UserManager();
            manager.DeleteUserAttribute(userId, attributeId);
        }

        public static void AddUserAttribute(int userId, int attributeTypeId, string value)
        {
            var manager = new UserManager();
            manager.AddUserAttribute(userId, attributeTypeId, value);
        }

        public static UserDto SaveUser(UserDto dto)
        {
            var manager = new UserManager();
            return manager.Save(dto);
        }

        public static void DeleteUser(int userId)
        {
            var manager = new UserManager();
            manager.Delete(userId);
        }

        public static IList<FileDto> GetAllFiles()
        {
            var manager = new FileManager();
            return manager.GetAllFiles();
        }

        public static FileDto GetFileById(int fileId)
        {
            var manager = new FileManager();
            return manager.GetFileById(fileId);
        }

        public static FileDto SaveFile(FileDto fileDto)
        {
            var manager = new FileManager();
            return manager.Save(fileDto);
        }

        public static void DeleteFile(int fileId)
        {
            var manager = new FileManager();
            manager.Delete(fileId);
        }

        public static FileAccessTreeDto GetAccessTree(int fileId)
        {
            var manager = new FileManager();
            return manager.GetAccessTree(fileId);
        }

        public static IList<GateDto> GetAllGates()
        {
            var manager = new GateManager();
            return manager.GetAllGates();
        }

        public static FileAccessTreeDto AddGate(int fileId, int parentId, int gateId)
        {
            var manager = new FileManager();
            manager.AddGate(parentId, gateId);
            return GetAccessTree(fileId);
        }

        public static FileAccessTreeDto AddAttribute(int fileId, int parentId, int attributeTypeId, string value)
        {
            var manager = new FileManager();
            manager.AddAttribute(parentId, attributeTypeId, value);
            return GetAccessTree(fileId);
        }

        public static FileAccessTreeDto AddRoot(int fileId, int gateId)
        {
            var manager = new FileManager();
            manager.AddRoot(fileId, gateId);
            return GetAccessTree(fileId);
        }
    }
}
