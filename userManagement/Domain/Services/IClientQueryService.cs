using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Model.Queries;

namespace UserManagement.userManagement.Domain.Services;

public interface IClientQueryService
{
    Task<IEnumerable<Client>> Handle(GetAllClientsQuery query);
    Task<Client?> Handle(GetClientByIdQuery query);
    Task<IEnumerable<Client>> Handle(GetClientsByUserIdQuery query);
}