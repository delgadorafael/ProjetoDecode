using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using ProjetoDecode.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDecode.Application.Mapper
{
    class MapperProfession : IMapperProfession
    {
        public Profession MapperDTOEntity(ProfessionDTO professionDTO)
        {
            return new Profession()
            {
                Id = professionDTO.Id,
                Role = professionDTO.Role
            };
        }

        public ProfessionDTO MapperEntityDTO(Profession profession)
        {
            return new ProfessionDTO()
            {
                Id = profession.Id,
                Role = profession.Role
            };
        }

        public IEnumerable<ProfessionDTO> MapperListEntityDTO(IEnumerable<Profession> professions)
        {
            return professions.Select(x => new ProfessionDTO
            {
                Id = x.Id,
                Role = x.Role
            });
        }
    }
}
