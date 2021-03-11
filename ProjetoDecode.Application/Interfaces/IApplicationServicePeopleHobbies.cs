using ProjetoDecode.Application.DTO;
using System.Collections.Generic;

namespace ProjetoDecode.Application.Interfaces
{
    public interface IApplicationServicePeopleHobbies
    {
        void Add(PeopleHobbiesDTO obj);
        void Update(PeopleHobbiesDTO obj);
        void Remove(PeopleHobbiesDTO obj);
        IEnumerable<PeopleHobbiesDTO> GetAll();
        PeopleHobbiesDTO GetById(int id);
    }
}
