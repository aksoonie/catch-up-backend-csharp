using catch_up_platform2.Shared.Domain.Repositories;
using catch_up_platform2.Shared.Infraestructure.Persistence.EFC.Configuration;

namespace catch_up_platform2.Shared.Infraestructure.Persistence.EFC.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}