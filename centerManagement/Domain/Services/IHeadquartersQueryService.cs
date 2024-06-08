using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Model.Queries;

namespace CenterManagement.centerManagement.Domain.Services;

public interface IHeadquartersQueryService
{
    Task<IEnumerable<Headquarters>> Handle(GetAllHeadquartersQuery query);
    Task<Headquarters?> Handle(GetHeadquartersByIdQuery query);
    Task<IEnumerable<Headquarters>> Handle(GetHeadquartersByPlaceIdQuery query);
}