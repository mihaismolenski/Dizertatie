using System;
using ABE.Models.BaseModels;

namespace ABE.Models
{
    public class File : BaseFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
    }
}
