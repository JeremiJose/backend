using UserManagement.Shared.Domain.Repositories;
using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Model.Commands;
using UserManagement.userManagement.Domain.Repositories;
using UserManagement.userManagement.Domain.Services;

namespace UserManagement.userManagement.Application.Internal.CommandServices;

public class ClientCommandService(IClientRepository clientRepository,IUnitOfWork unitOfWork): IClientCommandService
{
    public async Task<Client?> Handle(CreateClientCommand command)
    {
        var client = new Client(command);
        try
        {
            await clientRepository.AddAsync(client);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return client;
    }    
}