using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Model.Queries;
using CenterManagement.centerManagement.Domain.Repositories;
using CenterManagement.centerManagement.Domain.Services;


namespace CenterManagement.centerManagement.Application.Internal.QueriesServices;

public class HeadquartersQueryService(IHeadquartersRepository headquartersRepository): IHeadquartersQueryService
{
    public async Task<Headquarters?> Handle(GetHeadquartersByIdQuery query)
    {
        return await headquartersRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<Headquarters>> Handle(GetHeadquartersByPlaceIdQuery query)
    {
        return await headquartersRepository.FindByPlaceIdAsync(query.IdPlace);
    }

    public async Task<IEnumerable<Headquarters>> Handle(GetAllHeadquartersQuery query)
    {
        return await headquartersRepository.FindAllAsync();
    }
}