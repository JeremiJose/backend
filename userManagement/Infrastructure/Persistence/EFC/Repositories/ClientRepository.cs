using Microsoft.EntityFrameworkCore;
using UserManagement.Shared.Infraestructure.Persistence.EFC.Configuration;
using UserManagement.Shared.Infraestructure.Persistence.EFC.Repositories;
using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Repositories;

namespace UserManagement.userManagement.Infrastructure.Persistence.EFC.Repositories;

public class ClientRepository: BaseRepository<Client>, IClientRepository
{
    public ClientRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Client>> FindAllAsync()
    {
        return await Context.Set<Client>().ToListAsync();
    }

    public async Task<Client?> FindByIdAsync(int id)
    {
        return await Context.Set<Client>().FindAsync(id);
    }

    public async Task<IEnumerable<Client>> FindByUserIdAsync(int userId)
    {
        return await Context.Set<Client>().Where(c => c.UserId == userId).ToListAsync();
    }
}