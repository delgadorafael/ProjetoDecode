using ProjetoDecode.Application.DTO;
using ProjetoDecode.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDecode.Application.Interfaces
{
    interface IMapperHobby
    {
        Hobby MapperDTOEntity(HobbyDTO hobbyDTO);
        IEnumerable<HobbyDTO> MapperListEntityDTO(IEnumerable<Hobby> hobbies);
        HobbyDTO MapperEntityDTO(Hobby hobby);
    }
}
