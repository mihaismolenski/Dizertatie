using Entities;
using NHibernate;

namespace Repositories.Managers
{
    public class BaseManager
    {
        private ISession _session;

        public ISession Session => _session ?? (_session = NHibernateHelper.OpenSession());
    }
}
