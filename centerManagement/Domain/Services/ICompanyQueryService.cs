using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Model.Queries;

namespace CenterManagement.centerManagement.Domain.Services;

public interface ICompanyQueryService
{
    Task<IEnumerable<Company>> Handle(GetAllCompanysQuery query);
    Task<Company?> Handle(GetCompanyByIdQuery query);
    Task<IEnumerable<Company>> Handle(GetCompanyByPlaceIdQuery query);
}