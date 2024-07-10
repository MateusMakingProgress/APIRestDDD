using API_Rest_DDD.Domain.Entitys;
using System;

namespace API_Rest_DDD.Application.Dtos
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}