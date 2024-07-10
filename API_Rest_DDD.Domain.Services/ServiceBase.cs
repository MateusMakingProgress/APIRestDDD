using API_Rest_DDD.Domain.Core.Interfaces.Repositorys;
using API_Rest_DDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace API_Rest_DDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }

        public void Add(TEntity entity)
        {
            repositoryBase.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            repositoryBase.Delete(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repositoryBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repositoryBase.GetById(id);
        }

        public void Update(TEntity entity)
        {
            repositoryBase.Update(entity);
        }
    }
}