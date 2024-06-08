using UserManagement.Shared.Domain.Repositories;
using UserManagement.userManagement.Domain.Model.Aggregates;

namespace UserManagement.userManagement.Domain.Repositories;

public interface IClientRepository : IBaseRepository<Client>
{
    Task<IEnumerable<Client>> FindAllAsync();
    Task<Client?> FindByIdAsync(int id);
    Task<IEnumerable<Client>> FindByUserIdAsync(int userId);
}