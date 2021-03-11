using ProjetoDecode.Domain.Entities;
using ProjetoDecode.Domain.Interfaces.Repositories;
using ProjetoDecode.Infrastructure.Data.Context;

namespace ProjetoDecode.Infrastructure.Data.Repositories
{
    public class RepositoryPeopleHobbies : RepositoryBase<PeopleHobbies>, IRepositoryPeopleHobbies
    {
        private readonly DecodeContext _decodeContext;

        public RepositoryPeopleHobbies(DecodeContext decodeContext) : base(decodeContext)
        {
            _decodeContext = decodeContext;
        }
    }
}
