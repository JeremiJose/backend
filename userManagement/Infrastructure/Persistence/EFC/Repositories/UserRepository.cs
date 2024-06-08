using Microsoft.EntityFrameworkCore;
using UserManagement.Shared.Infraestructure.Persistence.EFC.Configuration;
using UserManagement.Shared.Infraestructure.Persistence.EFC.Repositories;
using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Repositories;

namespace UserManagement.userManagement.Infrastructure.Persistence.EFC.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<User>> FindAllAsync()
    {
        return await Context.Set<User>().ToListAsync();
    }
    public  async Task<User?> FindByIdAsync(int id)
    {
        return await Context.Set<User>().FindAsync(id);
    }

    public async Task<IEnumerable<User>> FindByWalletIdAsync(int idWallet)
    {
        return await Context.Set<User>().Where(c => c.IdWallet == idWallet).ToListAsync();
    }
}