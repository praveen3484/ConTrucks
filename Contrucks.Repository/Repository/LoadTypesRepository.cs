using Contrucks.model;
using Contrucks.Repository.Infrastructure;
using System.Collections.Generic;

namespace Contrucks.Repository.Repository
{
    public class LoadTypeRepository : RepositoryBase<LoadTypes>, ILoadTypesRepository
    {
        public LoadTypeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {

        }
    }

    public interface ILoadTypesRepository : IRepositoryBase<LoadTypes>
    {
        IEnumerable<LoadTypes> GetLoadType();
    }
}