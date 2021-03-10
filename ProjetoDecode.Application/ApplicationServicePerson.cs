using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using ProjetoDecode.Domain.Interfaces.Servicies;
using System.Collections.Generic;

namespace ProjetoDecode.Application
{
    public class ApplicationServicePerson : IApplicationServicePerson
    {
        private readonly IServicePerson _servicePerson;
        private readonly IMapperPerson _mapperPerson;

        public ApplicationServicePerson(IServicePerson servicePerson, IMapperPerson mapperPerson)
        {
            _servicePerson = servicePerson;
            _mapperPerson = mapperPerson;
        }

        public void Add(PersonDTO obj)
        {
            var person = _mapperPerson.MapperDTOEntity(obj);
            _servicePerson.Add(person);
        }

        public IEnumerable<PersonDTO> GetAll()
        {
            var person = _servicePerson.GetAll();
            return _mapperPerson.MapperListEntityDTO(person);
        }

        public PersonDTO GetById(int id)
        {
            var person = _servicePerson.GetById(id);
            return _mapperPerson.MapperEntityDTO(person);
        }

        public void Remove(PersonDTO obj)
        {
            var person = _mapperPerson.MapperDTOEntity(obj);
            _servicePerson.Remove(person);
        }

        public void Update(PersonDTO obj)
        {
            var person = _mapperPerson.MapperDTOEntity(obj);
            _servicePerson.Update(person);
        }
    }
}
