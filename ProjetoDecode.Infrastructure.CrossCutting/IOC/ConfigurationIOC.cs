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

            builder.RegisterType<ServicePerson>().As<IServicePerson>();
            builder.RegisterType<ServiceProfession>().As<IServiceProfession>();
            builder.RegisterType<ServiceHobby>().As<IServiceHobby>();

            builder.RegisterType<RepositoryPerson>().As<IRepositoryPerson>();
            builder.RegisterType<RepositoryProfession>().As<IRepositoryProfession>();
            builder.RegisterType<RepositoryHobby>().As<IRepositoryHobby>();

            builder.RegisterType<MapperPerson>().As<IMapperPerson>();
            builder.RegisterType<MapperProfession>().As<IMapperProfession>();
            builder.RegisterType<MapperHobby>().As<IMapperHobby>();
        }
    }
}
