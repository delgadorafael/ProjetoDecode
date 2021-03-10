using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using ProjetoDecode.Domain.Interfaces.Servicies;
using System.Collections.Generic;

namespace ProjetoDecode.Application
{
    public class ApplicationServiceHobby : IApplicationServiceHobby
    {
        private readonly IServiceHobby _serviceHobby;
        private readonly IMapperHobby _mapperHobby;

        public ApplicationServiceHobby(IServiceHobby serviceHobby, IMapperHobby mapperHobby)
        {
            _serviceHobby = serviceHobby;
            _mapperHobby = mapperHobby;
        }

        public void Add(HobbyDTO obj)
        {
            var hobby = _mapperHobby.MapperDTOEntity(obj);
            _serviceHobby.Add(hobby);
        }

        public IEnumerable<HobbyDTO> GetAll()
        {
            var hobby = _serviceHobby.GetAll();
            return _mapperHobby.MapperListEntityDTO(hobby);
        }

        public HobbyDTO GetById(int id)
        {
            var hobby = _serviceHobby.GetById(id);
            return _mapperHobby.MapperEntityDTO(hobby);
        }

        public void Remove(HobbyDTO obj)
        {
            var hobby = _mapperHobby.MapperDTOEntity(obj);
            _serviceHobby.Remove(hobby);
        }

        public void Update(HobbyDTO obj)
        {
            var hobby = _mapperHobby.MapperDTOEntity(obj);
            _serviceHobby.Update(hobby);
        }
    }
}
