using AutoMapper;
using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using ProjetoDecode.Domain.Entities;
using ProjetoDecode.Domain.Interfaces.Servicies;
using System.Collections.Generic;

namespace ProjetoDecode.Application
{
    public class ApplicationServiceHobby : IApplicationServiceHobby
    {
        private readonly IServiceHobby _serviceHobby;
        private readonly IMapper _mapper;

        public ApplicationServiceHobby(IServiceHobby serviceHobby, IMapper mapper)
        {
            _serviceHobby = serviceHobby;
            _mapper = mapper;
        }

        public void Add(HobbyDTO obj)
        {
            var hobby = _mapper.Map<Hobby>(obj);
            _serviceHobby.Add(hobby);
        }

        public IEnumerable<HobbyDTO> GetAll()
        {
            var hobby = _serviceHobby.GetAll();
            return _mapper.Map<IEnumerable<HobbyDTO>>(hobby);
        }

        public HobbyDTO GetById(int id)
        {
            var hobby = _serviceHobby.GetById(id);
            return _mapper.Map<HobbyDTO>(hobby);
        }

        public void Remove(HobbyDTO obj)
        {
            var hobby = _mapper.Map<Hobby>(obj);
            _serviceHobby.Remove(hobby);
        }

        public void Update(HobbyDTO obj)
        {
            var hobby = _mapper.Map<Hobby>(obj);
            _serviceHobby.Update(hobby);
        }
    }
}
