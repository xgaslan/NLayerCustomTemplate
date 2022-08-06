using System.Linq.Expressions;
using NLayer.Core.Entities;

namespace NLayer.Core.Repositories;

public interface IBaseRepository<TEntity> where TEntity : class, IBaseEntity, new()
{
    #region Create

    #region Add Async
    Task<TEntity> AddAsync(TEntity entity);
    #endregion

    #endregion

    #region Read

    #region Get By Id Async
    Task<TEntity?> GetByIdAsync(int id);
    #endregion

    #region Get All
    IQueryable<TEntity> GetAll();
    #endregion

    #region Where
    IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> filter);
    #endregion

    #region Any Async
    Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter);
    #endregion

    #endregion

    #region Update

    #region Update 
    void Update(TEntity entity);
    #endregion

    #endregion

    #region Delete

    #region Delete
    void Delete(TEntity entity); 
    #endregion

    #endregion
}