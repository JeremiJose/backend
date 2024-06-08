using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Model.Queries;
using CenterManagement.centerManagement.Domain.Repositories;
using CenterManagement.centerManagement.Domain.Services;

namespace CenterManagement.centerManagement.Application.Internal.QueriesServices;

public class CompanyQueryService(ICompanyRepository companyRepository): ICompanyQueryService
{
    public async Task<Company?> Handle(GetCompanyByIdQuery query)
    {
        return await companyRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<Company>> Handle(GetCompanyByPlaceIdQuery query)
    {
        return await companyRepository.FindByPlaceIdAsync(query.IdPlace);
    }

    public async Task<IEnumerable<Company>> Handle(GetAllCompanysQuery query)
    {
        return await companyRepository.FindAllAsync();
    }
}