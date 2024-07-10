using API_Rest_DDD.Application.Dtos;
using System.Collections.Generic;

namespace API_Rest_DDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);

        void Update(ProdutoDto produtoDto);

        void Delete(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> GetAll();

        ProdutoDto GetById(int id);
    }
}