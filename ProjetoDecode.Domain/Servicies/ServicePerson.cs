using ProjetoDecode.Domain.Entities;
using ProjetoDecode.Domain.Interfaces.Repositories;
using ProjetoDecode.Domain.Interfaces.Servicies;

namespace ProjetoDecode.Domain.Servicies
{
    public class ServicePerson : ServiceBase<Person>, IServicePerson
    {
        private readonly IRepositoryPerson _repositoryPerson;

        public ServicePerson(IRepositoryPerson repositoryPerson) : base(repositoryPerson)
        {
            _repositoryPerson = repositoryPerson;
        }
    }
}