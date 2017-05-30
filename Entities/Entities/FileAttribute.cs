namespace Entities.Entities
{
    public class FileAttribute
    {
        public virtual int AttributeId { get; set; }
        public virtual string Value { get; set; }
        public virtual AttributeType AttributeType { get; set; }
    }
}
