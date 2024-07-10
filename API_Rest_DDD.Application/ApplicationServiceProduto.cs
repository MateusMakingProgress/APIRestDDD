using API_Rest_DDD.Application.Dtos;
using API_Rest_DDD.Application.Interfaces;
using API_Rest_DDD.Domain.Core.Interfaces.Services;
using API_Rest_DDD.Infrastructure.CrossCutting.Interfaces;
using System.Collections.Generic;

namespace API_Rest_DDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Add(produto);
        }

        public void Delete(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Delete(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            return mapperProduto.MapperListProdutosDto(produtos);
        }

        public ProdutoDto GetById(int id)
        {
            var produto = serviceProduto.GetById(id);
            return mapperProduto.MapperEntityToDto(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Update(produto);
        }
    }
}