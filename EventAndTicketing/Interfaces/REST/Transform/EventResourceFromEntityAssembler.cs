using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.EventAndTicketing.Interfaces.REST.Resources;

namespace Backend_MyEventec.EventAndTicketing.Interfaces.REST.Transform;

public class EventResourceFromEntityAssembler
{
    public static EventResource ToResourceFromEntity(Event entity) =>
        new EventResource(entity.Id, entity.IdHeadquarters, entity.IdOrganizer, entity.Name, entity.StartDate, entity.FinishDate, entity.Description, entity.TotalTicket,
            entity.Status);
}