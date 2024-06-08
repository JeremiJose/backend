using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.Shared.Domain.Repositories;

namespace Backend_MyEventec.EventAndTicketing.Domain.Repositories;

public interface IEventRepository : IBaseRepository<Event>
{
    Task<IEnumerable<Event>> FindByAllEventAsync();
    Task<Event?> FindByEventIdAsync(int id);
    Task<IEnumerable<Event>> FindByHeadquartersAsync(int idHeadquarters); 
    Task<IEnumerable<Event>> FindByOrganizerIdAsync(int idOrganizer);
}