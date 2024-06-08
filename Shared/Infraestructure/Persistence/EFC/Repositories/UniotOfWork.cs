using UserManagement.Shared.Domain.Repositories;
using UserManagement.Shared.Infraestructure.Persistence.EFC.Configuration;

namespace UserManagement.Shared.Infraestructure.Persistence.EFC.Repositories;

public class UniotOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UniotOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}