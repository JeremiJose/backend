using CenterManagement.centerManagement.Domain.Model.Commands;
using CenterManagement.centerManagement.Interfaces.REST.Resources;

namespace CenterManagement.centerManagement.Interfaces.REST.Transform;

public static class CreateHeadquartersCommandFromResourceAssembler
{
    public static CreateHeadquartersCommand ToCommandFromResource(CreateHeadquartersResource resource) =>
        new(resource.Name,resource.Capacity);
}