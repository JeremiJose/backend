using Backend_MyEventec.Shared.Domain.Repositories;
using Backend_MyEventec.Shared.Infraestructure.Persistence.EFC.Configuration;

namespace Backend_MyEventec.Shared.Infraestructure.Persistence.EFC.Repositories;

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