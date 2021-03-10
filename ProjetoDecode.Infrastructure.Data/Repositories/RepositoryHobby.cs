using ProjetoDecode.Domain.Entities;
using ProjetoDecode.Domain.Interfaces.Repositories;
using ProjetoDecode.Infrastructure.Data.Context;

namespace ProjetoDecode.Infrastructure.Data.Repositories
{
    public class RepositoryHobby : RepositoryBase<Hobby>, IRepositoryHobby
    {
        private readonly DecodeContext _decodeContext;

        public RepositoryHobby(DecodeContext decodeContext) : base(decodeContext)
        {
            _decodeContext = decodeContext;
        }
    }
}
