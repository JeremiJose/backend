using CenterManagement.centerManagement.Domain.Model.Commands;
using CenterManagement.centerManagement.Interfaces.REST.Resources;

namespace CenterManagement.centerManagement.Interfaces.REST.Transform;

public static class CreatePlaceCommandFromResourceAssembler
{
    public static CreatePlaceCommand ToCommandFromResource(CreatePlaceResource resource) =>
        new(resource.Name,resource.Address,resource.Capacity,resource.Ruc);
}