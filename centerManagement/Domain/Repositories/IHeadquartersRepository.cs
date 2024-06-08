using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.Shared.Domain.Repositories;

namespace CenterManagement.centerManagement.Domain.Repositories;

public interface IHeadquartersRepository : IBaseRepository<Headquarters>
{
    Task<IEnumerable<Headquarters>> FindAllAsync();
    Task<Headquarters?> FindByIdAsync(int id);
    Task<IEnumerable<Headquarters>> FindByPlaceIdAsync(int idPlace);
}