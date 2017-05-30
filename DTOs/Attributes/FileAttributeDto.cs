namespace DTOs.Attributes
{
    public class FileAttributeDto
    {
        public int AttributeId { get; set; }
        public string Value { get; set; }
        public AttributeTypeDto AttributeType { get; set; }
    }
}
