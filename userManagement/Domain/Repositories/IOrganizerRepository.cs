using UserManagement.Shared.Domain.Repositories;
using UserManagement.userManagement.Domain.Model.Aggregates;

namespace UserManagement.userManagement.Domain.Repositories;

public interface IOrganizerRepository : IBaseRepository<Organizer>
{
    Task<IEnumerable<Organizer>> FindAllAsync();
    Task<Organizer?> FindByIdAsync(int id);
    Task<IEnumerable<Organizer>> FindByUserIdAsync(int userId);
    Task<IEnumerable<Organizer>> FindByCompanyIdAsync(int companyId);
}