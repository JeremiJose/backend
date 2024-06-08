using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Interfaces.REST.Resources;

namespace CenterManagement.centerManagement.Interfaces.REST.Transform;

public class HeadquartersResourceFromEntityAssembler
{
    public static HeadquartersResource ToResourceFromEntity(Headquarters entity) =>
        new HeadquartersResource(entity.Id, entity.Name,entity.IdPlace,entity.Capacity);
}