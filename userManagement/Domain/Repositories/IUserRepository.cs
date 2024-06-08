using UserManagement.Shared.Domain.Repositories;
using UserManagement.userManagement.Domain.Model.Aggregates;

namespace UserManagement.userManagement.Domain.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<IEnumerable<User>> FindAllAsync();
    Task<User?> FindByIdAsync(int id);
    Task<IEnumerable<User>> FindByWalletIdAsync(int idWallet);
}