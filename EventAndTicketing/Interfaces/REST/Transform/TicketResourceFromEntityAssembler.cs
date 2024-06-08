using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.EventAndTicketing.Interfaces.REST.Resources;

namespace Backend_MyEventec.EventAndTicketing.Interfaces.REST.Transform;

public class TicketResourceFromEntityAssembler
{
    public static TicketResource ToResourceFromEntity(Ticket entity) =>
        new TicketResource(entity.Id, entity.EventId, entity.ClientId, entity.Price, entity.Category);
}