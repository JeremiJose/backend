using Microsoft.EntityFrameworkCore;
using Paymethods.paymethods.Domain.Model.Aggregates;
using Paymethods.paymethods.Domain.Repositories;
using Paymethods.Shared.Infraestructure.Persistence.EFC.Configuration;
using Paymethods.Shared.Infraestructure.Persistence.EFC.Repositories;

namespace Paymethods.paymethods.Infrastructure.Persistence.EFC.Repositories
{
    public class CardRepository : BaseRepository<Card>, ICardRepository
    {
        public CardRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Card>> FindAllAsync()
        {
            return await Context.Set<Card>().ToListAsync();
        }

        public  async Task<Card?> FindByIdAsync(int id)
        {
            return await Context.Set<Card>().FindAsync(id);
        }

        public async Task<IEnumerable<Card>> FindByWalletIdAsync(int idWallet)
        {
            return await Context.Set<Card>().Where(c => c.IdWallet == idWallet).ToListAsync();
        }
    }
}

