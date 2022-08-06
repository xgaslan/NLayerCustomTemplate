using NLayer.Core.Entities;

namespace NLayer.Core.Repositories;

public interface IBaseRepositoryExtension<TEntity> where TEntity : class, IBaseEntity, new()
{
   
}