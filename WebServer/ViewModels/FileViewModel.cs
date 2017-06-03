using System;

namespace WebServer.ViewModels
{
    public class FileViewModel
    {
        public int FileId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AccessPolicy { get; set; }
    }
}