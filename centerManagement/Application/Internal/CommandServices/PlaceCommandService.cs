using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Model.Commands;
using CenterManagement.centerManagement.Domain.Repositories;
using CenterManagement.centerManagement.Domain.Services;
using CenterManagement.Shared.Domain.Repositories;

namespace CenterManagement.centerManagement.Application.Internal.CommandServices;

public class PlaceCommandService(IPlaceRepository placeRepository,IUnitOfWork unitOfWork): IPlaceCommandService
{
    public async Task<Place?> Handle(CreatePlaceCommand command)
    {
        var place = new Place(command);
        try
        {
            await placeRepository.AddAsync(place);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return place;
    }    
}