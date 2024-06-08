using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Interfaces.REST.Resources;

namespace UserManagement.userManagement.Interfaces.REST.Transform;

public class ClientResourceFromEntityAssembler
{
    public static ClientResource ToResourceFromEntity(Client entity) =>
        new ClientResource(entity.Id, entity.UserId);
}