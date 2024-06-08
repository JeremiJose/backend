using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.EventAndTicketing.Domain.Model.Queries;
using Backend_MyEventec.EventAndTicketing.Domain.Repositories;
using Backend_MyEventec.EventAndTicketing.Domain.Services;

namespace Backend_MyEventec.EventAndTicketing.Application.Internal.QueryServices;

public class EventQueryService(IEventRepository eventRepository) : IEventQueryService
{
    public async Task<IEnumerable<Event>> Handle(GetAllEventQuery query)
    {
        return await eventRepository.FindByAllEventAsync();
    }

    public async Task<Event?> Handle(GetEventByIdQuery query)
    {
        return await eventRepository.FindByEventIdAsync(query.Id);
    }

    public async Task<IEnumerable<Event>> Handle(GetEventByHeadquarters query)
    {
        return await eventRepository.FindByHeadquartersAsync(query.IdHeadquarters);
    }

    public async Task<IEnumerable<Event>> Handle(GetEventByOrganizerIdQuery query)
    {
        return await eventRepository.FindByOrganizerIdAsync(query.IdOrganizer);
    }
}
    
