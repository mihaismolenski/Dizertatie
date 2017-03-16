using AutoMapper;
using Mappers;

namespace Repositories.Integration.Tests
{
    public class BaseSpecs
    {
        public BaseSpecs()
        {
            Mapper.Initialize(c => c.AddProfile<AutoMapperConfig>());
        }
    }
}
