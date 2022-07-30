using NLayer.Core.UnitOfWork;

namespace NLayer.Repository.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    //TODO Context instance alınacak ctor oluşturulacak
    public async Task CommitAsync()
    {
        //await _context.SaveChangesAsync();
        throw new NotImplementedException();
    }

    public void Commit()
    {
        //_context.SaveChanges();
        throw new NotImplementedException();
    }
}