using AutoMapper;
using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using ProjetoDecode.Domain.Entities;
using ProjetoDecode.Domain.Interfaces.Servicies;
using System.Collections.Generic;

namespace ProjetoDecode.Application
{
    public class ApplicationServiceProfession : IApplicationServiceProfession
    {
        private readonly IServiceProfession _serviceProfession;
        private readonly IMapper _mapper;

        public ApplicationServiceProfession(IServiceProfession serviceProfession, IMapper mapper)
        {
            _serviceProfession = serviceProfession;
            _mapper = mapper;
        }

        public void Add(ProfessionDTO obj)
        {
            var profession = _mapper.Map<Profession>(obj);
            _serviceProfession.Add(profession);
        }

        public IEnumerable<ProfessionDTO> GetAll()
        {
            var profession = _serviceProfession.GetAll();
            return _mapper.Map< IEnumerable<ProfessionDTO>>(profession);

        }

        public ProfessionDTO GetById(int id)
        {
            var profession = _serviceProfession.GetById(id);
            return _mapper.Map<ProfessionDTO>(profession);
        }

        public void Remove(ProfessionDTO obj)
        {
            var profession = _mapper.Map<Profession>(obj);
            _serviceProfession.Remove(profession);
        }

        public void Update(ProfessionDTO obj)
        {
            var profession = _mapper.Map<Profession>(obj);
            _serviceProfession.Update(profession);
        }
    }
}
