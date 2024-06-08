using Backend_MyEventec.EventAndTicketing.Domain.Model.Commands;
using Backend_MyEventec.EventAndTicketing.Interfaces.REST.Resources;

namespace Backend_MyEventec.EventAndTicketing.Interfaces.REST.Transform;

public static class CreateTicketCommandFromResourceAssembler
{
    public static CreateTicketCommand ToCommandFromResource(CreateTicketResource resource) =>
        new CreateTicketCommand(resource.Price,resource.Category);
}