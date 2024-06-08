using Microsoft.EntityFrameworkCore;
using UserManagement.Shared.Infraestructure.Persistence.EFC.Configuration;
using UserManagement.Shared.Infraestructure.Persistence.EFC.Repositories;
using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Repositories;

namespace UserManagement.userManagement.Infrastructure.Persistence.EFC.Repositories;

public class OrganizerRepository : BaseRepository<Organizer>, IOrganizerRepository
{
    public OrganizerRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Organizer>> FindAllAsync()
    {
        return await Context.Set<Organizer>().ToListAsync();
    }

    public async Task<Organizer?> FindByIdAsync(int id)
    {
        return await Context.Set<Organizer>().FindAsync(id);
    }

    public async Task<IEnumerable<Organizer>> FindByUserIdAsync(int userId)
    {
        return await Context.Set<Organizer>().Where(o => o.UserId == userId).ToListAsync();
    }

    public async Task<IEnumerable<Organizer>> FindByCompanyIdAsync(int companyId)
    {
        return await Context.Set<Organizer>().Where(o => o.CompanyId == companyId).ToListAsync();
    }
}