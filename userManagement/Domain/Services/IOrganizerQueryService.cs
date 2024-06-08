using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Model.Queries;

namespace UserManagement.userManagement.Domain.Services;

public interface IOrganizerQueryService
{
    Task<Organizer?> Handle(GetOrganizerByIdQuery query);
    Task<IEnumerable<Organizer>> Handle(GetOrganizersByUserIdQuery query);
    Task<IEnumerable<Organizer>> Handle(GetOrganizersByCompanyIdQuery query);
    Task<IEnumerable<Organizer>> Handle(GetAllOrganizersQuery query);
}