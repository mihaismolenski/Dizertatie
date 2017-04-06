using System.Collections.Generic;

namespace Entities.Entities
{
    public class User
    {
        public virtual int UserId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual IList<UserAttribute> Attributes { get; set; }
    }
}
