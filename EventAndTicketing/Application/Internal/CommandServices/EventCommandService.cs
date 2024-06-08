using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.EventAndTicketing.Domain.Model.Commands;
using Backend_MyEventec.EventAndTicketing.Domain.Repositories;
using Backend_MyEventec.EventAndTicketing.Domain.Services;
using Backend_MyEventec.Shared.Domain.Repositories;

namespace Backend_MyEventec.EventAndTicketing.Application.Internal.CommandServices;

public class EventCommandService(IEventRepository eventRepository, IUnitOfWork unitOfWork) : IEventCommandService
{
    public async Task<Event?> Handle(CreateEventCommand command)
    {
        var eventNew = new Event(command);
        try
        {
            await eventRepository.AddAsync(eventNew);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return eventNew;
    }
}