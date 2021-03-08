using ProjetoDecode.Domain.Entities;
using ProjetoDecode.Domain.Interfaces.Repositories;
using ProjetoDecode.Domain.Interfaces.Servicies;

namespace ProjetoDecode.Domain.Servicies
{
    class ServiceHobby : ServiceBase<Hobby>, IServiceHobby
    {
        private readonly IRepositoryHobby _repositoryHobby;

        public ServiceHobby(IRepositoryHobby repositoryHobby) : base(repositoryHobby)
        {
            _repositoryHobby = repositoryHobby;
        }
    }
}
