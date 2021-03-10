using ProjetoDecode.Application.DTO;
using System.Collections.Generic;

namespace ProjetoDecode.Application.Interfaces
{
    public interface IApplicationServiceHobby
    {
        void Add(HobbyDTO obj);
        void Update(HobbyDTO obj);
        void Remove(HobbyDTO obj);
        IEnumerable<HobbyDTO> GetAll();
        HobbyDTO GetById(int id);
    }
}
