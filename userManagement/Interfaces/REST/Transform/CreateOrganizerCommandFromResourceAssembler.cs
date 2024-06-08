using UserManagement.userManagement.Domain.Model.Commands;
using UserManagement.userManagement.Interfaces.REST.Resources;

namespace UserManagement.userManagement.Interfaces.REST.Transform;

public class CreateOrganizerCommandFromResourceAssembler
{
    public static CreateOrganizerCommand ToCommandFromResource(CreateOrganizerResource resource) =>
        new(resource.UserId);
}