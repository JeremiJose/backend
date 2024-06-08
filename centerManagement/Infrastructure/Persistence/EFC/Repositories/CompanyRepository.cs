using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Repositories;
using CenterManagement.Shared.Infraestructure.Persistence.EFC.Configuration;
using CenterManagement.Shared.Infraestructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CenterManagement.centerManagement.Infrastructure.Persistence.EFC.Repositories;

public class CompanyRepository: BaseRepository<Company>, ICompanyRepository
{
    public CompanyRepository(AppDbContext context) : base(context)
    {
    }
    public async Task<IEnumerable<Company>> FindAllAsync()
    {
        return await Context.Set<Company>().ToListAsync();
    }

    public async Task<Company?> FindByIdAsync(int id)
    {
        return await Context.Set<Company>().FindAsync(id);
    }

    public async Task<IEnumerable<Company>> FindByPlaceIdAsync(int idPlace)
    {
        return await Context.Set<Company>().Where(c=>c.IdPlace== idPlace).ToListAsync();
    }
}