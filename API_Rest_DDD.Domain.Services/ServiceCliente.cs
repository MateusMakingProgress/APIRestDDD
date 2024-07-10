using API_Rest_DDD.Domain.Core.Interfaces.Repositorys;
using API_Rest_DDD.Domain.Core.Interfaces.Services;
using API_Rest_DDD.Domain.Entitys;

namespace API_Rest_DDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente)
            : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}