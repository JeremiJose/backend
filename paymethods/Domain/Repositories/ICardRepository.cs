using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.Shared.Domain.Repositories;

namespace Paymethods.paymethods.Domain.Repositories
{
    public interface ICardRepository : IBaseRepository<Card>
    {
        Task<IEnumerable<Card>> FindAllAsync();
        Task<Card?> FindByIdAsync(int id);
        Task<IEnumerable<Card>> FindByWalletIdAsync(int idWallet);
    }
}