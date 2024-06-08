using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.Shared.Domain.Repositories;

namespace Backend_MyEventec.EventAndTicketing.Domain.Repositories;

public interface ITicketRepository : IBaseRepository<Ticket>
{
    Task<IEnumerable<Ticket>> FindByAllEventAsync();
    Task<Ticket?> FindByTicketsIdAsync(int id);
    Task<IEnumerable<Ticket>> FindByEventsAsync(int idEvent); 
    
}