using Microsoft.EntityFrameworkCore;
using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Domain.Repositories;
using Paymethods.Shared.Infraestructure.Persistence.EFC.Configuration;
using Paymethods.Shared.Infraestructure.Persistence.EFC.Repositories;

namespace Paymethods.paymethods.Infrastructure.Persistence.EFC.Repositories;

public class WalletRepository : BaseRepository<Wallet>, IWalletRepository
{
    public WalletRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Wallet>> FindAllAsync()
    {
        return await Context.Set<Wallet>().ToListAsync();
    }

    public  async Task<Wallet?> FindByIdAsync(int id)
    {
        return await Context.Set<Wallet>().FindAsync(id);
    }

    public async Task<IEnumerable<Wallet>> FindByUserIdAsync(int userId)
    {
        return await Context.Set<Wallet>().Where(c => c.UserId == userId).ToListAsync();
    }
}
