﻿using System.Collections.Generic;

namespace API_Rest_DDD.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}