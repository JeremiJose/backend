using UserManagement.userManagement.Domain.Model.Commands;
using UserManagement.userManagement.Interfaces.REST.Resources;

namespace UserManagement.userManagement.Interfaces.REST.Transform;

public static class CreateUserCommandFromResourceAssembler
{
    public static CreateUserCommand ToCommandFromResource(CreateUserResource resource) =>
        new(resource.FirstName, resource.LastName, resource.Address, resource.Email, resource.Phone, resource.Password);
}