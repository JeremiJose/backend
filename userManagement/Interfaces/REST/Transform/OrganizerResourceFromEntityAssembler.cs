using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Interfaces.REST.Resources;

namespace UserManagement.userManagement.Interfaces.REST.Transform;

public class OrganizerResourceFromEntityAssembler
{
    public static OrganizerResource ToResourceFromEntity(Organizer entity) =>
        new OrganizerResource(entity.Id, entity.CompanyId, entity.UserId, entity.EventsInCharge);
}