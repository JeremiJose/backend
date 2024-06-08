using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Model.Commands;

namespace UserManagement.userManagement.Domain.Services;

public interface IOrganizerCommandService
{
    Task<Organizer?> Handle(CreateOrganizerCommand command);
}