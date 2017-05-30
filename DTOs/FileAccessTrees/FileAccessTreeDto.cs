using System.Collections.Generic;
using DTOs.Attributes;
using DTOs.Files;
using DTOs.Gates;

namespace DTOs.FileAccessTrees
{
    public class FileAccessTreeDto
    {
        public int AccessTreeId { get; set; }
        public GateDto Gate { get; set; }
        public virtual FileAttributeDto FileAttribute { get; set; }
        public FileDto File { get; set; }
        public virtual IList<FileAccessTreeDto> Children { get; set; }
    }
}
