using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Model.Queries;

namespace CenterManagement.centerManagement.Domain.Services;

public interface IPlaceQueryService
{
    Task<IEnumerable<Place>> Handle(GetAllPlacesQuery query);
    Task<Place?> Handle(GetPlaceByIdQuery query);
    
}