using System.Collections.Generic;

namespace WebServer.ViewModels
{
    public class FileAccessTreeViewModel
    {
        public int AccessTreeId { get; set; }
        public GateViewModel Gate { get; set; }
        public virtual FileAttributeViewModel FileAttribute { get; set; }
        public FileViewModel File { get; set; }
        public virtual IList<FileAccessTreeViewModel> Children { get; set; }
    }
}