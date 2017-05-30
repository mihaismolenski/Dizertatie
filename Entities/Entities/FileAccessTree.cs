using System.Collections.Generic;

namespace Entities.Entities
{
    public class FileAccessTree
    {
        public virtual int AccessTreeId { get; set; }
        public virtual Gate Gate { get; set; }
        public virtual FileAttribute FileAttribute { get; set; }
        public virtual File File { get; set; }
        public virtual IList<FileAccessTree> Children { get; set; }
    }
}
