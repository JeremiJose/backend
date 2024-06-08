using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Repositories;
using CenterManagement.Shared.Infraestructure.Persistence.EFC.Configuration;
using CenterManagement.Shared.Infraestructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CenterManagement.centerManagement.Infrastructure.Persistence.EFC.Repositories;

public class HeadquartersRepository: BaseRepository<Headquarters>, IHeadquartersRepository
{
    public HeadquartersRepository(AppDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<Headquarters>> FindAllAsync()
    {
        return await Context.Set<Headquarters>().ToListAsync();
    }

    public async Task<Headquarters?> FindByIdAsync(int id)
    {
        return await Context.Set<Headquarters>().FindAsync(id);
    }

    public async Task<IEnumerable<Headquarters>> FindByPlaceIdAsync(int idPlace)
    {
        return await Context.Set<Headquarters>().Where(h=>h.IdPlace== idPlace).ToListAsync();
    }
}