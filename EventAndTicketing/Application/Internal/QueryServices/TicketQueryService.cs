using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.EventAndTicketing.Domain.Model.Queries;
using Backend_MyEventec.EventAndTicketing.Domain.Repositories;
using Backend_MyEventec.EventAndTicketing.Domain.Services;

namespace Backend_MyEventec.EventAndTicketing.Application.Internal.QueryServices;

public class TicketQueryService(ITicketRepository ticketRepository) : ITicketQueryService
{
        public async Task<IEnumerable<Ticket>> Handle(GetAllTicketsQuery query)
        {
            return await ticketRepository.FindByAllEventAsync();
        }

        public async Task<Ticket?> Handle(GetTicketByIdQuery query)
        {
            return await ticketRepository.FindByTicketsIdAsync(query.Id);
        }

        public async Task<IEnumerable<Ticket>> Handle(GetTicketsByEventIdQuery query)
        {
            return await ticketRepository.FindByEventsAsync(query.IdEvent);
        }
}
