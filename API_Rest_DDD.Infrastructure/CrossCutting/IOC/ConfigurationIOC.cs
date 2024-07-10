using API_Rest_DDD.Application;
using API_Rest_DDD.Application.Interfaces;
using API_Rest_DDD.Domain.Core.Interfaces.Repositorys;
using API_Rest_DDD.Domain.Core.Interfaces.Services;
using API_Rest_DDD.Domain.Services;
using API_Rest_DDD.Infrastructure.CrossCutting.Interfaces;
using API_Rest_DDD.Infrastructure.CrossCutting.Mapper;
using API_Rest_DDD.Infrastructure.Data.Repositorys;
using Autofac;

namespace API_Rest_DDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion
        }
    }
}