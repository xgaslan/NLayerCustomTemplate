using NLayer.Repository.Repositories.Category;
using NLayer.Repository.Repositories.Product;
using NLayer.Repository.Repositories.User;

namespace NLayer.Core.UnitOfWork;

public interface IUnitOfWork
{
    ICategoryRepository CategoryRepository { get; }
    IProductRepository ProductRepository { get; }
    IUserRepository UserRepository { get; }
    Task CommitAsync(CancellationToken cancellationToken);
    void Commit();
}