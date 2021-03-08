using ProjetoDecode.Domain.Entities;
using ProjetoDecode.Domain.Interfaces.Repositories;
using ProjetoDecode.Infrastructure.Data.Context;

namespace ProjetoDecode.Infrastructure.Data.Repositories
{
    class RepositoryProfession : RepositoryBase<Profession>, IRepositoryProfession
    {
        private readonly DecodeContext _decodeContext;

        public RepositoryProfession(DecodeContext decodeContext) : base(decodeContext)
        {
            _decodeContext = decodeContext;
        }
    }
}
