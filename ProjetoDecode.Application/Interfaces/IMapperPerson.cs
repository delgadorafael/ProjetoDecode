using ProjetoDecode.Application.DTO;
using ProjetoDecode.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDecode.Application.Interfaces
{
    public interface IMapperPerson
    {
        Person MapperDTOEntity(PersonDTO personDTO);
        IEnumerable<PersonDTO> MapperListEntityDTO(IEnumerable<Person> people);
        PersonDTO MapperEntityDTO(Person person);
    }
}
