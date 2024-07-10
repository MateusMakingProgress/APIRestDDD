using API_Rest_DDD.Application.Dtos;
using API_Rest_DDD.Domain.Entitys;
using System.Collections.Generic;

namespace API_Rest_DDD.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);

        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}