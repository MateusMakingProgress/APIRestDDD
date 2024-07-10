using API_Rest_DDD.Application.Dtos;
using System.Collections.Generic;

namespace API_Rest_DDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto clienteDto);

        void Delete(ClienteDto clienteDto);

        void Update(ClienteDto clienteDto);

        IEnumerable<ClienteDto> GetAll();

        ClienteDto GetById(int id);
    }
}