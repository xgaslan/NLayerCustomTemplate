using NLayer.Core.UnitOfWork;
using NLayer.Repository.Context;
using NLayer.Repository.Repositories.Category;
using NLayer.Repository.Repositories.Product;
using NLayer.Repository.Repositories.User;

namespace NLayer.Repository.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly BaseContext _context;

    private ICategoryRepository _categoryRepository;
    private IProductRepository _productRepository;
    private IUserRepository _userRepository;

    public UnitOfWork(BaseContext context)
    {
        _context = new BaseContext();
    }

    public ICategoryRepository CategoryRepository => _categoryRepository ??= new CategoryRepository(_context);
    public IProductRepository ProductRepository => _productRepository ??= new ProductRepository(_context);
    public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Commit()
    {
        _context.SaveChanges();
    }
}