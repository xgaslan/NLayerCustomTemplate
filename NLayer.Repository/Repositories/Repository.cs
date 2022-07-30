using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;

namespace NLayer.Repository.Repositories;

public class Repository<T>: IRepository<T> where T : class, new()
{
    //TODO DbContext eklenince açılacak
    //protected readonly BaseContext _context;
    //private readonly DbSet<T> _dbSet;

    //public Repository(BaseContext context)
    //{
    //    _context = context;
    //    _dbSet = context.Set<T>();
    //}
    public async Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }
}