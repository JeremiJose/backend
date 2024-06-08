using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Model.Queries;
using CenterManagement.centerManagement.Domain.Repositories;
using CenterManagement.centerManagement.Domain.Services;

namespace CenterManagement.centerManagement.Application.Internal.QueriesServices;

public class PlaceQueryService(IPlaceRepository placeRepository): IPlaceQueryService
{
    public async Task<IEnumerable<Place>> Handle(GetAllPlacesQuery query)
    {
        return await placeRepository.FindAllAsync();
    }

    public async Task<Place?> Handle(GetPlaceByIdQuery query)
    {
        return await placeRepository.FindByIdAsync(query.Id);
    }
}