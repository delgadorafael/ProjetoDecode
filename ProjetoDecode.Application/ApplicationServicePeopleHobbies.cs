using AutoMapper;
using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using ProjetoDecode.Domain.Interfaces.Servicies;
using System;
using System.Collections.Generic;

namespace ProjetoDecode.Application
{
    public class ApplicationServicePeopleHobbies : IApplicationServicePeopleHobbies
    {
        private readonly IServicePeopleHobbies _servicePeopleHobbies;
        private readonly IMapper _mapper;

        public ApplicationServicePeopleHobbies(IServicePeopleHobbies servicePeopleHobbies, IMapper mapper)
        {
            _servicePeopleHobbies = servicePeopleHobbies;
            _mapper = mapper;
        }

        public void Add(PeopleHobbiesDTO obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PeopleHobbiesDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public PeopleHobbiesDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(PeopleHobbiesDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Update(PeopleHobbiesDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
