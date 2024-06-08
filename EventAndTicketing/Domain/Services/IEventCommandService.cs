using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.EventAndTicketing.Domain.Model.Commands;

namespace Backend_MyEventec.EventAndTicketing.Domain.Services;

public interface IEventCommandService
{
    Task<Event?> Handle(CreateEventCommand command);
}