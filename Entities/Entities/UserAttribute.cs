namespace Entities.Entities
{
    public class UserAttribute
    {
        public virtual int Id { get; set; }
        public virtual string Value { get; set; }
        public virtual AttributeType AttributeType { get; set; }
        public virtual User User { get; set; }
    }
}
