﻿using System.Linq.Expressions;
using NLayer.Core.Entities;

namespace NLayer.Core.Repositories;

public interface IBaseRepository<TEntity> where TEntity : class, IBaseEntity, new()
{
    #region Create

    Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken);

    #endregion

    #region Read
    
    Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken);
    
    IQueryable<TEntity> GetAll(bool includeDeleted = false);
   
    IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> filter);
   
    Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter, CancellationToken cancellationToken);
    
    #endregion

    #region Update

    void Update(TEntity entity);

    #endregion

    #region Delete

    void Delete(TEntity entity);

    #endregion
}