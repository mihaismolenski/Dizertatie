using System.Collections.Generic;
using System.Linq;
using DTOs.FileAccessTrees;
using DTOs.Files;
using DTOs.Gates;
using Entities.Entities;
using Mappers.Files;
using Mappers.Gates;
using NHibernate;

namespace Repositories.Managers
{
    public class GateManager : BaseManager
    {
        public IList<GateDto> GetAllGates()
        {
            var query = Session.QueryOver<Gate>().List();
            return query.Select(GateMapper.MapToDto).ToList();
        }
    }
}
