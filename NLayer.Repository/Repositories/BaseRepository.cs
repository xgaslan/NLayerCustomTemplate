using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using NLayer.Repository.Context;

namespace NLayer.Repository.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseEntity, new()
{
    #region Definition

    protected readonly BaseContext _context;
    private readonly DbSet<TEntity> _dbSet;

    #endregion

    #region Constructor

    public BaseRepository(BaseContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    #endregion

    #region Create

    #region Add Async

    public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken)
    {
        var addedEntity = await _dbSet.AddAsync(entity, cancellationToken);
        addedEntity.Entity.CreatedAt = DateTime.Now;
        addedEntity.Entity.ChangedAt = DateTime.Now;
        await _context.SaveChangesAsync(cancellationToken);
        return addedEntity.Entity;
    }

    #endregion

    #endregion

    #region Read

    #region Get By Id Async
    public async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var getEntityById = await _dbSet.Where(e => e.Id == id).SingleOrDefaultAsync(cancellationToken);
        return getEntityById;
    }
    #endregion

    #region Get All
    public IQueryable<TEntity> GetAll(bool includeDeleted = false)
    {
        IQueryable<TEntity> queryableEntities;
        if (!includeDeleted)
        {
            queryableEntities = _dbSet.Where(e => !e.IsDeleted).AsNoTracking().AsQueryable();
            return queryableEntities;
        }

        queryableEntities = _dbSet.AsNoTracking().AsQueryable();
        return queryableEntities;
    }
    #endregion

    #region Where
    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> filter)
    {
        var query = _dbSet.Where(filter);
        return query;
    }
    #endregion

    #region Any Async
    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter, CancellationToken cancellationToken)
    {
        var checkEntityExist = await _dbSet.AnyAsync(filter, cancellationToken);
        return checkEntityExist;
    }
    #endregion

    #endregion

    #region Update

    #region Update
    public void Update(TEntity entity)
    {
        entity.ChangedAt = DateTime.Now;
        _dbSet.Update(entity);

    }
    #endregion

    #endregion

    #region Delete

    #region Delete
    public void Delete(TEntity entity)
    {
        _dbSet.Remove(entity);
    }
    #endregion

    #endregion
}