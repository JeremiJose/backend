namespace CenterManagement.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}