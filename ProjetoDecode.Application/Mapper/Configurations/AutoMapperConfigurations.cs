using AutoMapper;
using ProjetoDecode.Application.DTO;
using ProjetoDecode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProjetoDecode.Application.Mapper.Configurations
{
    public class AutoMapperConfigurations : Profile
    {
        public AutoMapperConfigurations()
        {
            CreateMap<Person, PersonDTO>();
            CreateMap<PersonDTO, Person>();

            CreateMap<Profession, ProfessionDTO>();
            CreateMap<ProfessionDTO, Profession>();

            CreateMap<Hobby, HobbyDTO>();
            CreateMap<HobbyDTO, Hobby>();

            CreateMap<PeopleHobbies, PeopleHobbiesDTO>();
            CreateMap<PeopleHobbiesDTO, PeopleHobbies>();
        }
    }
}
