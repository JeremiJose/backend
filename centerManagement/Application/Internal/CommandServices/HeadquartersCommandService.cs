using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Model.Commands;
using CenterManagement.centerManagement.Domain.Repositories;
using CenterManagement.centerManagement.Domain.Services;
using CenterManagement.Shared.Domain.Repositories;

namespace CenterManagement.centerManagement.Application.Internal.CommandServices;

public class HeadquartersCommandService(IHeadquartersRepository headquartersRepository,IUnitOfWork unitOfWork): IHeadquartersCommandService
{
    public async Task<Headquarters?> Handle(CreateHeadquartersCommand command)
    {
        var headquarters = new Headquarters(command);
        try
        {
            await headquartersRepository.AddAsync(headquarters);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return headquarters;
    }    
}