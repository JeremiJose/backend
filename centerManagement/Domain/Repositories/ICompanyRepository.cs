using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.Shared.Domain.Repositories;

namespace CenterManagement.centerManagement.Domain.Repositories;

public interface ICompanyRepository : IBaseRepository<Company>
{
    Task<IEnumerable<Company>> FindAllAsync();
    Task<Company?> FindByIdAsync(int id);
    Task<IEnumerable<Company>> FindByPlaceIdAsync(int idPlace);
}