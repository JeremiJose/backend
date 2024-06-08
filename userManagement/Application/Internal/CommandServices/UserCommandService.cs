using UserManagement.Shared.Domain.Repositories;
using UserManagement.userManagement.Domain.Model.Aggregates;
using UserManagement.userManagement.Domain.Model.Commands;
using UserManagement.userManagement.Domain.Repositories;
using UserManagement.userManagement.Domain.Services;

namespace UserManagement.userManagement.Application.Internal.CommandServices;

public class UserCommandService(IUserRepository userRepository,IUnitOfWork unitOfWork): IUserCommandService
{
    public async Task<User?> Handle(CreateUserCommand command)
    {
        var user = new User(command);
        try
        {
            await userRepository.AddAsync(user);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return user;
    }
}