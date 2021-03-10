using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using ProjetoDecode.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDecode.Application.Mapper
{
    class MapperHobby : IMapperHobby
    {
        public Hobby MapperDTOEntity(HobbyDTO hobbyDTO)
        {
            return new Hobby()
            {
                Id = hobbyDTO.Id,
                Name = hobbyDTO.Name
            };
        }

        public HobbyDTO MapperEntityDTO(Hobby hobby)
        {
            return new HobbyDTO()
            {
                Id = hobby.Id,
                Name = hobby.Name
            };
        }

        public IEnumerable<HobbyDTO> MapperListEntityDTO(IEnumerable<Hobby> hobbies)
        {
            return hobbies.Select(x => new HobbyDTO
            {
                Id = x.Id,
                Name = x.Name
            });
        }
    }
}
