using API_Rest_DDD.Domain.Entitys;
using System;

namespace API_Rest_DDD.Application.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set;}
        public string Email { get; set;}
    }
}
