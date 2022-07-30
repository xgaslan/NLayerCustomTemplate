using System.Linq.Expressions;

namespace NLayer.Core.Services;

public interface IService<T> where T : class, new()
{
    #region Create

    #region Add Async
    Task<T> AddAsync(T entity, CancellationToken cancellationToken);
    #endregion

    #endregion

    #region Read

    #region Get By Id Async
    Task<T> GetByIdAsync(int id, CancellationToken cancellationToken);
    #endregion

    #region Get All
    Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken);
    #endregion

    #region Where
    IQueryable<T> Where(Expression<Func<T, bool>> filter, CancellationToken cancellationToken);
    #endregion

    #region Any Async
    Task<bool> AnyAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken);
    #endregion

    #endregion

    #region Update

    #region Update
    Task<T> Update(T entity, CancellationToken cancellationToken);
    #endregion

    #endregion

    #region Delete

    #region Delete
    Task Delete(T entity, CancellationToken cancellationToken);
    #endregion

    #endregion
}