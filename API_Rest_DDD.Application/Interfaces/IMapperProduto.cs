using API_Rest_DDD.Application.Dtos;
using API_Rest_DDD.Domain.Entitys;
using System.Collections.Generic;

namespace API_Rest_DDD.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos);

        ProdutoDto MapperEntityToDto(Produto produto);
    }
}