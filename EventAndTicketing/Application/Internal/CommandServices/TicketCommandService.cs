using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.EventAndTicketing.Domain.Model.Commands;
using Backend_MyEventec.EventAndTicketing.Domain.Repositories;
using Backend_MyEventec.EventAndTicketing.Domain.Services;
using Backend_MyEventec.EventAndTicketing.Infraestructure.Persistence.EFC.Repositories;
using Backend_MyEventec.Shared.Domain.Repositories;

namespace Backend_MyEventec.EventAndTicketing.Application.Internal.CommandServices;

public class TicketCommandService(ITicketRepository ticketRepository, IUnitOfWork unitOfWork) : ITicketCommandService
{
    public async Task<Ticket?> Handle(CreateTicketCommand command)
    {
        var ticket = new Ticket(command);
        try
        {
            await ticketRepository.AddAsync(ticket);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return ticket;
    }
}