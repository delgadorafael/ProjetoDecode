using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using ProjetoDecode.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDecode.Application.Mapper
{
    public class MapperPerson : IMapperPerson
    {
        public Person MapperDTOEntity(PersonDTO personDTO)
        {
            return new Person()
            {
                Id = personDTO.Id,
                FirstName = personDTO.FirstName,
                LastName = personDTO.LastName,
                BirthDate = personDTO.BirthDate,
                Email = personDTO.Email,
                Status = personDTO.Status,
                //Profession = personDTO.Profession,
                //Hobbies = personDTO.Hobbies


                /*
                 public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }
        public ProfessionDTO Profession { get; set; }
        public List<HobbyDTO> Hobbies { get; set; }
                */
            };
        }

        public PersonDTO MapperEntityDTO(Person person)
        {
            return new PersonDTO()
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                BirthDate = person.BirthDate,
                Email = person.Email,
                Status = person.Status
                //Profession = personDTO.Profession,
                //Hobbies = personDTO.Hobbies
            };
        }

        public IEnumerable<PersonDTO> MapperListEntityDTO(IEnumerable<Person> people)
        {
            return people.Select(x => new PersonDTO {
                                                        Id = x.Id,
                                                        FirstName = x.FirstName,
                                                        LastName = x.LastName,
                                                        BirthDate = x.BirthDate,
                                                        Email = x.Email,
                                                        Status = x.Status
                                                    });
        }
    }
}
