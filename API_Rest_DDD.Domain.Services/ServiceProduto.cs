using API_Rest_DDD.Domain.Core.Interfaces.Repositorys;
using API_Rest_DDD.Domain.Core.Interfaces.Services;
using API_Rest_DDD.Domain.Entitys;

namespace API_Rest_DDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
            : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}