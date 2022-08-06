using System.Linq.Expressions;
using NLayer.Core.DTOs;

namespace NLayer.Core.Services;

public interface IBaseService<TEntityView, TEntityService> 
    where TEntityView : class,  new()
    where TEntityService : class, new()
{
    #region Create

    #region Add Async
    Task<TEntityService> AddAsync(TEntityView entity, CancellationToken cancellationToken);
    #endregion

    #endregion

    #region Read

    #region Get By Id Async
    Task<TEntityService> GetByIdAsync(int id, CancellationToken cancellationToken);
    #endregion

    #region Get All
    Task<List<TEntityService>> GetAll(CancellationToken cancellationToken);
    #endregion

    #region Where
    IQueryable<TEntityService> Where(Expression<Func<TEntityView, bool>> filter, CancellationToken cancellationToken);
    #endregion

    #region Any Async
    Task<bool> AnyAsync(Expression<Func<TEntityView, bool>> filter, CancellationToken cancellationToken);
    #endregion

    #endregion

    #region Update

    #region Update
    Task<TEntityService> Update(TEntityView entity, CancellationToken cancellationToken);
    #endregion

    #endregion

    #region Delete

    #region Delete
    Task Delete(TEntityView entity, CancellationToken cancellationToken);
    #endregion

    #endregion
}