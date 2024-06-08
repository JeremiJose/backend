using CenterManagement.centerManagement.Domain.Model.Aggregates;
using CenterManagement.centerManagement.Domain.Model.Commands;
using CenterManagement.centerManagement.Domain.Repositories;
using CenterManagement.centerManagement.Domain.Services;
using CenterManagement.Shared.Domain.Repositories;

namespace CenterManagement.centerManagement.Application.Internal.CommandServices;

public class CompanyCommandService(ICompanyRepository companyRepository,IUnitOfWork unitOfWork): ICompanyCommandService
{
    public async Task<Company?> Handle(CreateCompanyCommand command)
    {
        var company = new Company(command);
        try
        {
            await companyRepository.AddAsync(company);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return company;
    }    
}