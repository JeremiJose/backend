using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Interfaces.REST.Resources;

namespace CenterManagement.centerManagement.Interfaces.REST.Transform;

public class PlaceResourceFromEntityAssembler
{
    public static PlaceResource ToResourceFromEntity(Place entity) =>
        new PlaceResource(entity.Id, entity.Name,entity.Address,entity.Capacity,entity.Ruc);
}