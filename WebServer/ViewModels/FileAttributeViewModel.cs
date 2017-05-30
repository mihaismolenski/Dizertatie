using System.Collections.Generic;

namespace WebServer.ViewModels
{
    public class FileAttributeViewModel
    {
        public int AttributeId { get; set; }
        public string Value { get; set; }
        public string AttributeTypeName { get; set; }
        public int AttributeTypeId { get; set; }
    }
}