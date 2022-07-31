using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;
using NLayer.Repository.Context;

namespace NLayer.Repository.Repositories;

public class Repository<T> : IRepository<T> where T : class, new()
{
    #region Definitions
    protected readonly BaseContext _context;
    private readonly DbSet<T> _dbSet;
    #endregion

    #region Constructor
    public Repository(BaseContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
    #endregion
    public async Task<T> AddAsync(T entity)
    {
        var addedEntity = await _dbSet.AddAsync(entity);
        return addedEntity.Entity;
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        return entity;
    }

    public IQueryable<T> GetAll()
    {
        var queryableEntities = _dbSet.AsNoTracking().AsQueryable();
        return queryableEntities;
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> filter)
    {
        var queryableEntities = _dbSet.Where(filter);
        return queryableEntities;
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
    {
        var isExists = await _dbSet.AnyAsync(filter);
        return isExists;
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }
}