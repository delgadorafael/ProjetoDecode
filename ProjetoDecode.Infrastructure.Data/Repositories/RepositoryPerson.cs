using ProjetoDecode.Domain.Entities;
using ProjetoDecode.Domain.Interfaces.Repositories;
using ProjetoDecode.Infrastructure.Data.Context;

namespace ProjetoDecode.Infrastructure.Data.Repositories
{
    public class RepositoryPerson : RepositoryBase<Person>, IRepositoryPerson
    {
        private readonly DecodeContext _decodeContext;

        public RepositoryPerson(DecodeContext decodeContext) : base(decodeContext)
        {
            _decodeContext = decodeContext;
        }
    }
}
