using System;

namespace Entities.Entities
{
    public class File
    {
        public virtual int FileId { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreatedDate { get; set; }
    }
}
