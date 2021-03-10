using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using ProjetoDecode.Domain.Interfaces.Servicies;
using System.Collections.Generic;

namespace ProjetoDecode.Application
{
    public class ApplicationServiceProfession : IApplicationServiceProfession
    {
        private readonly IServiceProfession _serviceProfession;
        private readonly IMapperProfession _mapperProfession;

        public ApplicationServiceProfession(IServiceProfession serviceProfession, IMapperProfession mapperProfession)
        {
            _serviceProfession = serviceProfession;
            _mapperProfession = mapperProfession;
        }

        public void Add(ProfessionDTO obj)
        {
            var profession = _mapperProfession.MapperDTOEntity(obj);
            _serviceProfession.Add(profession);
        }

        public IEnumerable<ProfessionDTO> GetAll()
        {
            var profession = _serviceProfession.GetAll();
            return _mapperProfession.MapperListEntityDTO(profession);
        }

        public ProfessionDTO GetById(int id)
        {
            var profession = _serviceProfession.GetById(id);
            return _mapperProfession.MapperEntityDTO(profession);
        }

        public void Remove(ProfessionDTO obj)
        {
            var profession = _mapperProfession.MapperDTOEntity(obj);
            _serviceProfession.Remove(profession);
        }

        public void Update(ProfessionDTO obj)
        {
            var profession = _mapperProfession.MapperDTOEntity(obj);
            _serviceProfession.Update(profession);
        }
    }
}
