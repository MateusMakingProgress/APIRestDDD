using API_Rest_DDD.Domain.Core.Interfaces.Repositorys;
using API_Rest_DDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Rest_DDD.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;
        
        public RepositoryCliente(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
