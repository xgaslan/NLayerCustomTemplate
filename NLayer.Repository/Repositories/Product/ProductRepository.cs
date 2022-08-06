using NLayer.Core.Repositories;
using NLayer.Repository.Context;

namespace NLayer.Repository.Repositories.Product;

public class ProductRepository : BaseRepository<Entity.Product>, IProductRepository
{
    public ProductRepository(BaseContext context) : base(context)
    {
    }
}