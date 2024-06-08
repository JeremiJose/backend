using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Model.Queries;
using UserManagement.userManagement.Domain.Repositories;
using UserManagement.userManagement.Domain.Services;

namespace UserManagement.userManagement.Application.Internal.QueriesServices;

public class ClientQueryService(IClientRepository clientRepository): IClientQueryService
{
    public async Task<IEnumerable<Client>> Handle(GetAllClientsQuery query)
    {
        return await clientRepository.FindAllAsync();
    }

    public async Task<Client?> Handle(GetClientByIdQuery query)
    {
        return await clientRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<Client>> Handle(GetClientsByUserIdQuery query)
    {
        return await clientRepository.FindByUserIdAsync(query.UserId);
    }
}