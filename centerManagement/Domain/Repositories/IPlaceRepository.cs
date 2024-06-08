using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.Shared.Domain.Repositories;

namespace CenterManagement.centerManagement.Domain.Repositories;

public interface IPlaceRepository : IBaseRepository<Place>
{
    Task<IEnumerable<Place>> FindAllAsync();
    Task<Place?> FindByIdAsync(int id);
}