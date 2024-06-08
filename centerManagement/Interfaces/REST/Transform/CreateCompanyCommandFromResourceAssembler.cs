using CenterManagement.centerManagement.Domain.Model.Commands;
using CenterManagement.centerManagement.Interfaces.REST.Resources;

namespace CenterManagement.centerManagement.Interfaces.REST.Transform;

public static class CreateCompanyCommandFromResourceAssembler
{
    public static CreateCompanyCommand ToCommandFromResource(CreateCompanyResource resource) =>
        new(resource.Name,resource.QuantityOrganizer);
}