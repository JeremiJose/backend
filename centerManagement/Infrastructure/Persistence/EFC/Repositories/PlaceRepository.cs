using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Repositories;
using CenterManagement.Shared.Infraestructure.Persistence.EFC.Configuration;
using CenterManagement.Shared.Infraestructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CenterManagement.centerManagement.Infrastructure.Persistence.EFC.Repositories;

public class PlaceRepository : BaseRepository<Place>, IPlaceRepository
{
    public PlaceRepository(AppDbContext context) : base(context)
    {
    }
    public async Task<IEnumerable<Place>> FindAllAsync()
    {
        return await Context.Set<Place>().ToListAsync();
    }

    public async Task<Place?> FindByIdAsync(int id)
    {
        return await Context.Set<Place>().FindAsync(id);
    }
}