using ProjetoDecode.Domain.Entities;
using ProjetoDecode.Domain.Interfaces.Repositories;
using ProjetoDecode.Domain.Interfaces.Servicies;

namespace ProjetoDecode.Domain.Servicies
{
    class ServiceProfession : ServiceBase<Profession>, IServiceProfession
    {
        private readonly IRepositoryProfession _repositoryProfession;

        public ServiceProfession(IRepositoryProfession repositoryProfession) : base(repositoryProfession)
        {
            _repositoryProfession = repositoryProfession;
        }
    }
}
