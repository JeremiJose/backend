using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Model.Queries;
using UserManagement.userManagement.Domain.Repositories;
using UserManagement.userManagement.Domain.Services;

namespace UserManagement.userManagement.Application.Internal.QueriesServices;

public class OrganizerQueryService(IOrganizerRepository organizerRepository): IOrganizerQueryService
{
    public async Task<Organizer?> Handle(GetOrganizerByIdQuery query)
    {
        return await organizerRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<Organizer>> Handle(GetOrganizersByUserIdQuery query)
    {
        return await organizerRepository.FindByUserIdAsync(query.UserId);
    }

    public async Task<IEnumerable<Organizer>> Handle(GetOrganizersByCompanyIdQuery query)
    {
        return await organizerRepository.FindByCompanyIdAsync(query.CompanyId);
    }

    public async Task<IEnumerable<Organizer>> Handle(GetAllOrganizersQuery query)
    {
        return await organizerRepository.FindAllAsync();
    }
}