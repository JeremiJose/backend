using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.Shared.Domain.Repositories;

namespace Paymethods.paymethods.Domain.Repositories;

public interface IWalletRepository : IBaseRepository<Wallet>
{
    Task<IEnumerable<Wallet>> FindAllAsync();
    Task<Wallet?> FindByIdAsync(int id);
    Task<IEnumerable<Wallet>> FindByUserIdAsync(int userId);
}