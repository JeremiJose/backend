using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Model.Queries;
using UserManagement.userManagement.Domain.Repositories;
using UserManagement.userManagement.Domain.Services;

namespace UserManagement.userManagement.Application.Internal.QueriesServices;

public class UserQueryService(IUserRepository userRepository): IUserQueryService
{
    public async Task<IEnumerable<User>> Handle(GetAllUserQuery query)
    {
        return await userRepository.FindAllAsync();
    }

    public async Task<User?> Handle(GetUserByIdQuery query)
    {
        return await userRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<User>> Handle(GetUserByWalletIdQuery query)
    {
        return await userRepository.FindByWalletIdAsync(query.IdWallet);
    }
}