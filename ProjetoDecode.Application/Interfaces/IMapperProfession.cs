using ProjetoDecode.Application.DTO;
using ProjetoDecode.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDecode.Application.Interfaces
{
    public interface IMapperProfession
    {
        Profession MapperDTOEntity(ProfessionDTO professionDTO);
        IEnumerable<ProfessionDTO> MapperListEntityDTO(IEnumerable<Profession> professions);
        ProfessionDTO MapperEntityDTO(Profession profession);
    }
}
