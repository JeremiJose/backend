using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Interfaces.REST.Resources;

namespace UserManagement.userManagement.Interfaces.REST.Transform;

public class UserResourceFromEntityAssembler
{
    public static UserResource ToResourceFromEntity(User entity) =>
        new UserResource(entity.Id, entity.IdWallet, entity.FirstName, entity.LastName, entity.Address, entity.Email,
            entity.Phone, entity.CreationDate, entity.SuspensionDate);
}