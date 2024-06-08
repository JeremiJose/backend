namespace Backend_MyEventec.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}