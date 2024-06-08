using UserManagement.Shared.Domain.Repositories;
using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Model.Commands;
using UserManagement.userManagement.Domain.Repositories;
using UserManagement.userManagement.Domain.Services;

namespace UserManagement.userManagement.Application.Internal.CommandServices;

public class OrganizerCommandService(IOrganizerRepository organizerRepository,IUnitOfWork unitOfWork): IOrganizerCommandService
{
    public async Task<Organizer?> Handle(CreateOrganizerCommand command)
    {
        var organizer = new Organizer(command);
        try
        {
            await organizerRepository.AddAsync(organizer);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return organizer;
    } 
}