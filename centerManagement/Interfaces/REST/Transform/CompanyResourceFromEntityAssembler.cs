using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Interfaces.REST.Resources;

namespace CenterManagement.centerManagement.Interfaces.REST.Transform;

public class CompanyResourceFromEntityAssembler
{
    public static CompanyResource ToResourceFromEntity(Company entity) =>
        new CompanyResource(entity.Id, entity.Name,entity.IdPlace,entity.QuantityOrganizer);
}