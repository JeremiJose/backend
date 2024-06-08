using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.EventAndTicketing.Domain.Model.Queries;

namespace Backend_MyEventec.EventAndTicketing.Domain.Services;

public interface ITicketQueryService
{
    Task<IEnumerable<Ticket>> Handle(GetAllTicketsQuery query);
    Task<Ticket?> Handle(GetTicketByIdQuery query);
    Task<IEnumerable<Ticket>> Handle(GetTicketsByEventIdQuery query);
}