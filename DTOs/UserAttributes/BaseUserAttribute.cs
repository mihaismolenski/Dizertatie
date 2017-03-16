namespace DTOs.UserAttributes
{
    public interface IUserAttribute
    {
        object GetValue { get; }
    }

    public class BaseUserAttribute<T> : IUserAttribute
    {
        public string Name { get; set; }
        public T Value { get; set; }

        public object GetValue => Value;
    }
}
