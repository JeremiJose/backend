using Backend_MyEventec.EventAndTicketing.Domain.Model.Commands;
using Backend_MyEventec.EventAndTicketing.Interfaces.REST.Resources;

namespace Backend_MyEventec.EventAndTicketing.Interfaces.REST.Transform;

public static class CreateEventCommandFromResourceAssembler
{
    public static CreateEventCommand ToCommandFromResource(CreateEventResource resource) =>
        new CreateEventCommand(resource.Name, resource.Description, resource.Status);
}