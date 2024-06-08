using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.EventAndTicketing.Domain.Model.Queries;

namespace Backend_MyEventec.EventAndTicketing.Domain.Services;

public interface IEventQueryService
{
    Task<IEnumerable<Event>> Handle(GetAllEventQuery query);
    Task<Event?> Handle(GetEventByIdQuery query);
    Task<IEnumerable<Event>> Handle(GetEventByHeadquarters query);
    Task<IEnumerable<Event>> Handle(GetEventByOrganizerIdQuery query);
}