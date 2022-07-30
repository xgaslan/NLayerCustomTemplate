using System.Linq.Expressions;

namespace NLayer.Core.Repositories;

public interface IRepository<T> where T : class, new()
{
    #region Create

    #region Add Async
    Task<T> AddAsync(T entity);
    #endregion

    #endregion

    #region Read

    #region Get By Id Async
    Task<T> GetByIdAsync(int id);
    #endregion

    #region Get All
    IQueryable<T> GetAll();
    #endregion

    #region Where
    IQueryable<T> Where(Expression<Func<T, bool>> filter);
    #endregion

    #region Any Async
    Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
    #endregion

    #endregion

    #region Update

    #region Update 
    void Update(T entity);
    #endregion

    #endregion

    #region Delete

    #region Delete
    void Delete(T entity); 
    #endregion

    #endregion
}