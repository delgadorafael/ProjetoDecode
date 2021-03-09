using ProjetoDecode.Application.DTO;
using System.Collections.Generic;

namespace ProjetoDecode.Application.Interfaces
{
    interface IApplicationServiceProfession
    {
        void Add(ProfessionDTO obj);
        void Update(ProfessionDTO obj);
        void Remove(ProfessionDTO obj);
        IEnumerable<ProfessionDTO> GetAll();
        ProfessionDTO GetById(int id);
    }
}
