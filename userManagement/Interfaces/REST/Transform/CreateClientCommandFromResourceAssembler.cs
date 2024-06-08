using UserManagement.userManagement.Domain.Model.Commands;
using UserManagement.userManagement.Interfaces.REST.Resources;

namespace UserManagement.userManagement.Interfaces.REST.Transform;

public static class CreateClientCommandFromResourceAssembler
{
    public static CreateClientCommand ToCommandFromResource(CreateClientResource resource) =>
        new(resource.UserId);
}