using Autofac;
using ProjetoDecode.Application;
using ProjetoDecode.Application.Interfaces;
using ProjetoDecode.Application.Mapper;
using ProjetoDecode.Domain.Interfaces.Repositories;
using ProjetoDecode.Domain.Interfaces.Servicies;
using ProjetoDecode.Domain.Servicies;
using ProjetoDecode.Infrastructure.Data.Repositories;

namespace ProjetoDecode.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServicePerson>().As<IApplicationServicePerson>();
            builder.RegisterType<ApplicationServiceProfession>().As<IApplicationServiceProfession>();
            builder.RegisterType<ApplicationServiceHobby>().As<IApplicationServiceHobby>();
            builder.RegisterType<ApplicationServicePeopleHobbies>().As<IApplicationServicePeopleHobbies>();


            builder.RegisterType<ServicePerson>().As<IServicePerson>();
            builder.RegisterType<ServiceProfession>().As<IServiceProfession>();
            builder.RegisterType<ServiceHobby>().As<IServiceHobby>();
            builder.RegisterType<ServicePeopleHobbies>().As<IServicePeopleHobbies>();

            builder.RegisterType<RepositoryPerson>().As<IRepositoryPerson>();
            builder.RegisterType<RepositoryProfession>().As<IRepositoryProfession>();
            builder.RegisterType<RepositoryHobby>().As<IRepositoryHobby>();
            builder.RegisterType<RepositoryPeopleHobbies>().As<IRepositoryPeopleHobbies>();
        }
    }
}
