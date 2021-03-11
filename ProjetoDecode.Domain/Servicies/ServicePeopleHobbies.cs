using ProjetoDecode.Domain.Entities;
using ProjetoDecode.Domain.Interfaces.Repositories;
using ProjetoDecode.Domain.Interfaces.Servicies;

namespace ProjetoDecode.Domain.Servicies
{
    public class ServicePeopleHobbies : ServiceBase<PeopleHobbies>, IServicePeopleHobbies
    {
        private readonly IRepositoryPeopleHobbies _repositoryPeopleHobbies;

        public ServicePeopleHobbies(IRepositoryPeopleHobbies repositoryPeopleHobbies) : base(repositoryPeopleHobbies)
        {
            _repositoryPeopleHobbies = repositoryPeopleHobbies;
        }
    }
}
