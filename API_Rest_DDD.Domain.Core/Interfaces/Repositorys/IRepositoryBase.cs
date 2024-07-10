using System.Collections.Generic;

namespace API_Rest_DDD.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}