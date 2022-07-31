using NLayer.Core.UnitOfWork;
using NLayer.Repository.Context;

namespace NLayer.Repository.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly BaseContext _context;

    public UnitOfWork(BaseContext context)
    {
        _context = context;
    }
    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Commit()
    {
        _context.SaveChanges();
    }
}